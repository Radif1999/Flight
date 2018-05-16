using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight {
    public partial class Form_AddUpdateDelete : Form {
        string Method;
        string Table;
        int ColumnsCount;
        
        TextBox textbox;
        TextBox textbox2;
        ComboBox comboBox;
        Button button;
        public Form_AddUpdateDelete(string Method, string Table, int ColumnsCount) {
            InitializeComponent();
            this.Method = Method;
            this.Table = Table;
            this.ColumnsCount = ColumnsCount;
            createTextBoxes();
            createButton();
        }
        public void createTextBoxes() {
            if (Table == "User_tbl") {
                textbox = new TextBox();
                textbox.Location = new System.Drawing.Point(20, 100);
                textbox.Name = "Login";
                textbox.Size = new System.Drawing.Size(75, 23);
                textbox.Visible = true;
                this.Controls.Add(textbox);

                textbox2 = new TextBox();
                textbox2.Location = new System.Drawing.Point(20, 150);
                textbox2.Name = "Password";
                textbox2.Size = new System.Drawing.Size(75, 23);
                textbox2.Visible = true;
                this.Controls.Add(textbox2);

                comboBox = new ComboBox();
                comboBox.Location = new System.Drawing.Point(20, 150);
                comboBox.Name = "Role";
                comboBox.Size = new System.Drawing.Size(75, 23);
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.Items.Add("asd");
                comboBox.Visible = true;
                this.Controls.Add(comboBox);
            }

            //TextBoxes = new TextBox[ColumnsCount];
            //for (int u = 0; u < TextBoxes.Count(); u++) {
            //    TextBoxes[u] = new TextBox();
            //}
            //int i = 0;
            //foreach (TextBox txt in TextBoxes) {
            //    string name = "Column" + i.ToString();
            //    txt.Name = name;
            //    txt.Location = new Point(10, 32 + (i * 28));
            //    txt.Visible = true;
            //    this.Controls.Add(txt);
            //    i++;
            //}
        }

        public void createButton() {
            button = new Button();
            button.Location = new System.Drawing.Point(105, 182);
            button.Name = "LoginIn_button";
            button.Size = new System.Drawing.Size(75, 23);
            button.Text = "button1";
            button.UseVisualStyleBackColor = true;
            button.Click += new System.EventHandler(this.LoginIn_button_Click);
            Controls.Add(button);
        }
        private void LoginIn_button_Click(object sender, EventArgs e) {
            //if (Table == "dbo_users") {
            //    User user = new User();
            //    user.Login = TextBoxes[0].Text;
            //    user.Password = TextBoxes[1].Text;
            //    user.Role = TextBoxes[2].Text; 
            //    string query = "INSERT INTO dbo.User_tbl (Login, Password, Role) VALUES ";
            //    using (SqlConnection connection = new SqlConnection(Connect.connectionString)) {
            //        SqlCommand command = new SqlCommand(query, connection);
            //        connection.Open();
                    
                    
            //    }
            //    if (Method == "add") {

            //    } else if (Method == "add") {

            //    } else if (Method == "add") {

            //    }
            //}
        }
        private void Form_AddUpdateDelete_Load(object sender, EventArgs e) {

        }
    }
}
