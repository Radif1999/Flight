using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight {
    public partial class Form_Manager : Form {
        public Form_Manager() {
            InitializeComponent();
        }

        private void Form_Manager_FormClosing(object sender, FormClosingEventArgs e) {
            this.Hide();
            LoginIn_Form loginIn_ = new LoginIn_Form();
            loginIn_.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_Manager_Users _Manager_Users = new Form_Manager_Users();
            _Manager_Users.Show();
        }
    }
}