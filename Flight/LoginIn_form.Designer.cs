namespace Flight {
    partial class LoginIn_Form {
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
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.LoginIn_button = new System.Windows.Forms.Button();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(55, 48);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(35, 13);
            this.Login_label.TabIndex = 0;
            this.Login_label.Text = "label1";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(55, 108);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(35, 13);
            this.Password_label.TabIndex = 1;
            this.Password_label.Text = "label2";
            // 
            // LoginIn_button
            // 
            this.LoginIn_button.Location = new System.Drawing.Point(105, 182);
            this.LoginIn_button.Name = "LoginIn_button";
            this.LoginIn_button.Size = new System.Drawing.Size(75, 23);
            this.LoginIn_button.TabIndex = 2;
            this.LoginIn_button.Text = "button1";
            this.LoginIn_button.UseVisualStyleBackColor = true;
            this.LoginIn_button.Click += new System.EventHandler(this.LoginIn_button_Click);
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(157, 48);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(100, 20);
            this.Login_textBox.TabIndex = 3;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(157, 108);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(100, 20);
            this.Password_textbox.TabIndex = 4;
            this.Password_textbox.UseSystemPasswordChar = true;
            // 
            // LoginIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.LoginIn_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Name = "LoginIn_Form";
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginIn_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button LoginIn_button;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textbox;
    }
}

