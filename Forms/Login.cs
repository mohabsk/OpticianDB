using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpticianDB.Forms
{
    public partial class LogOnForm : Form
    {
        public LogOnForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            using (DBBackEnd dbb = new DBBackEnd())
            {
                if (dbb.LogOn(UsernameTextBox.Text, PasswordTextBox.Text) == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                	MessageBox.Show("Unrecognised Username or Password\nPlease check and try again", "Login Error"); // FIXME
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
