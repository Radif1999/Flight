using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flight {
    public partial class Form_Manager_Users : Form {
        string table = "dbo_users";
        int ColumnsCount = 3;
        public Form_Manager_Users() {
            InitializeComponent();
            DataTableUpdate();
        }

        private void Form_Manager_Users_Load(object sender, EventArgs e) {
        }

        private void DataTableUpdate() {
            this.Users_dataGridView.Rows.Clear();
            Users_dataGridView.ClearSelection();
            this.Users_dataGridView.ColumnCount = 3;
            this.Users_dataGridView.ColumnHeadersVisible = true;

            this.Users_dataGridView.Columns[0].Name = "Login";
            this.Users_dataGridView.Columns[1].Name = "Password";
            this.Users_dataGridView.Columns[2].Name = "Role";

            string query = "select * from dbo.User_tbl";
            using (SqlConnection connection = new SqlConnection(Connect.connectionString)) {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                try {
                    while (dataReader.Read()) {
                        User user = new User();
                        user.Login = dataReader[0].ToString();
                        user.Password = dataReader[1].ToString();
                        user.Role = dataReader[2].ToString();
                        this.Users_dataGridView.Rows.Add(user.Login, user.Password, user.Role);
                    }
                } finally {
                    dataReader.Close();
                }
            }
        }

        private void Button_Add_Click(object sender, EventArgs e) {
            bool userExist = false;
            string query = $"select count(*) from dbo.User_tbl where Login = '{Login_textbox.Text}'";
            using (SqlConnection connection = new SqlConnection(Connect.connectionString)) {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                try {
                    while (dataReader.Read()) {
                        if (Convert.ToInt32(dataReader[0]) == 1) {
                            userExist = true;
                            break;
                        }
                    }
                } finally {
                    dataReader.Close();
                }
                if (userExist == true) {
                    MessageBox.Show("Пользователь существует");
                } else {
                    query = $@"INSERT INTO dbo.User_tbl(Login, Password, Role) 
                            VALUES ('{Login_textbox.Text}','{Password_textbox.Text}','{Role_combobox.Text}')";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            DataTableUpdate();
        }

        private void Button_Delete_Click(object sender, EventArgs e) {
            bool userExist = false;
            string query = $"select count(*) from dbo.User_tbl where Login = '{Login_textbox.Text}'";
            using (SqlConnection connection = new SqlConnection(Connect.connectionString)) {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                try {
                    while (dataReader.Read()) {
                        if (Convert.ToInt32(dataReader[0]) == 1) {
                            userExist = true;
                            break;
                        }
                    }
                } finally {
                    dataReader.Close();
                }
                if (userExist == false) {
                    MessageBox.Show("Пользователь не существует");
                } else {
                    query = $@"DELETE FROM dbo.User_tbl  
                            Where Login = '{Login_textbox.Text}'";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            DataTableUpdate();
        }

        private void Button_Update_Click(object sender, EventArgs e) {
            bool userExist = false;
            string query = $"select count(*) from dbo.User_tbl where Login = '{Login_textbox.Text}'";
            using (SqlConnection connection = new SqlConnection(Connect.connectionString)) {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                try {
                    while (dataReader.Read()) {
                        if (Convert.ToInt32(dataReader[0]) == 1) {
                            userExist = true;
                            break;
                        }
                    }
                } finally {
                    dataReader.Close();
                }
                if (userExist == false) {
                    MessageBox.Show("Пользователь не существует");
                } else {
                    query = $@"UPDATE dbo.User_tbl
                            SET Login = '{Login_textbox.Text}', Password = '{Password_textbox.Text}', Role = '{Role_combobox.Text}'
                            Where Login = '{Login_textbox.Text}'";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            DataTableUpdate();
        }

        private void Users_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                string Login = Users_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Password = Users_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string Role = Users_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                Login_textbox.Text = Login;
                Password_textbox.Text = Password;
                Role_combobox.Text = Role;
            } catch {

            }
        }
    }
}
