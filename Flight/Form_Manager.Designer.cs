namespace Flight {
    partial class Form_Manager {
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
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиЭкипажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыСамолетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экипажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(284, 24);
            this.StripMenu.TabIndex = 0;
            this.StripMenu.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.сотрудникиЭкипажаToolStripMenuItem,
            this.типыСамолетовToolStripMenuItem,
            this.экипажToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            // 
            // сотрудникиЭкипажаToolStripMenuItem
            // 
            this.сотрудникиЭкипажаToolStripMenuItem.Name = "сотрудникиЭкипажаToolStripMenuItem";
            this.сотрудникиЭкипажаToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.сотрудникиЭкипажаToolStripMenuItem.Text = "Сотрудники экипажа";
            // 
            // типыСамолетовToolStripMenuItem
            // 
            this.типыСамолетовToolStripMenuItem.Name = "типыСамолетовToolStripMenuItem";
            this.типыСамолетовToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.типыСамолетовToolStripMenuItem.Text = "Типы самолетов";
            // 
            // экипажToolStripMenuItem
            // 
            this.экипажToolStripMenuItem.Name = "экипажToolStripMenuItem";
            this.экипажToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.экипажToolStripMenuItem.Text = "Экипаж";
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.StripMenu);
            this.MainMenuStrip = this.StripMenu;
            this.Name = "Form_Manager";
            this.Text = "Form_Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Manager_FormClosing);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиЭкипажаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыСамолетовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экипажToolStripMenuItem;
    }
}