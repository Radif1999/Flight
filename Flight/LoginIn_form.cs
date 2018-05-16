using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flight {
    public partial class LoginIn_Form : Form {
        public LoginIn_Form() {
            InitializeComponent();
            this.Login_label.Text = "Логин";
            this.Password_label.Text = "Пароль";
            this.LoginIn_button.Text = "Вход";
        }

        private void LoginIn_button_Click(object sender, EventArgs e) {
            //Login_textBox.Text = "Admin";
            //Password_textbox.Text = "1";
            string queryString = "SELECT * from dbo.User_tbl";
            using (SqlConnection connection = new SqlConnection(Connect.connectionString)) {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try {
                    while (reader.Read()) {
                        User user = new User();
                        user.Login = reader[0].ToString();
                        user.Password = reader[1].ToString();
                        user.Role = reader[2].ToString();

                        if ((user.Login == Login_textBox.Text) && (user.Password == Password_textbox.Text)) {
                            if (user.Role.ToString() == "Admin") {
                                Form_Manager form_ = new Form_Manager();
                                this.Hide();
                                form_.Show();
                            } else if (user.Role == "User"){
                                Form_User form_ = new Form_User();
                                this.Hide();
                                form_.Show();
                            } else {
                                MessageBox.Show("У пользователя нет роли");
                            }
                            break;
                        }
                    }
                } finally {
                    reader.Close();
                }
            }
        }

        private void LoginIn_Form_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
