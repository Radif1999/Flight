namespace Flight {
    partial class Form_Manager_Users {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Users_dataGridView = new System.Windows.Forms.DataGridView();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Role_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_dataGridView
            // 
            this.Users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Users_dataGridView.Name = "Users_dataGridView";
            this.Users_dataGridView.Size = new System.Drawing.Size(984, 256);
            this.Users_dataGridView.TabIndex = 0;
            this.Users_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_dataGridView_CellClick);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(56, 407);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(158, 41);
            this.Button_Add.TabIndex = 1;
            this.Button_Add.Text = "Добавить запись";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(234, 407);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(138, 41);
            this.Button_Delete.TabIndex = 2;
            this.Button_Delete.Text = "Удалить запись";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(396, 407);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(150, 41);
            this.Button_Update.TabIndex = 3;
            this.Button_Update.Text = "Изменить запись";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Login_textbox
            // 
            this.Login_textbox.Location = new System.Drawing.Point(216, 289);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(100, 20);
            this.Login_textbox.TabIndex = 4;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(216, 329);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(100, 20);
            this.Password_textbox.TabIndex = 5;
            // 
            // Role_combobox
            // 
            this.Role_combobox.FormattingEnabled = true;
            this.Role_combobox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.Role_combobox.Location = new System.Drawing.Point(216, 366);
            this.Role_combobox.Name = "Role_combobox";
            this.Role_combobox.Size = new System.Drawing.Size(121, 21);
            this.Role_combobox.TabIndex = 6;
            // 
            // Form_Manager_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Role_combobox);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Login_textbox);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Users_dataGridView);
            this.Name = "Form_Manager_Users";
            this.Text = "Form_Manager_Users";
            this.Load += new System.EventHandler(this.Form_Manager_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Users_dataGridView;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.ComboBox Role_combobox;
    }
}