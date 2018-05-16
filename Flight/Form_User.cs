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
    public partial class Form_User : Form {
        public Form_User() {
            InitializeComponent();
        }

        private void Form_User_FormClosing(object sender, FormClosingEventArgs e) {
            this.Hide();
            LoginIn_Form loginIn_ = new LoginIn_Form();
            loginIn_.Show();
        }
    }
}
