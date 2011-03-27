/*
 * Copyright (c) 2011 Geoffrey Prytherch
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Windows.Forms;
using System.Drawing;

namespace OpticianDB.Forms
{
    public partial class LogOnForm : Form //TODO
    {
        public LogOnForm()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            FormState = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!FormState)
                return;
            progressIndicator1.Visible = true;
            Adaptor.Users u1 = new Adaptor.Users {Username = UsernameTextBox.Text, Password = PasswordTextBox.Text};
            FormState = false;
            login_BackgroundWorker.RunWorkerAsync(u1);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void Login_BackgroundWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Adaptor.Users u1 = (Adaptor.Users)e.Argument;
            using (DBBackEnd dbb = new DBBackEnd())
            {
                e.Result = dbb.LogOn(u1.Username, u1.Password);
            }
        }

        void Login_BackgroundWorkerRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressIndicator1.Visible = false;
            switch ((bool)e.Result)
            {
                case true:
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case false:
                    FormState = true;
                    MessageBox.Show("Unrecognised Username or Password\nPlease check and try again", "Login Error"); // FIXME
                    break;
            }
        }

        private bool _formState;
        public bool FormState
        {
            get
            {
                return _formState;
            }
            set
            {
                _formState = value;
                // OK.Enabled = value;
                UsernameTextBox.Enabled = value;
                PasswordTextBox.Enabled = value;
            }
        }
    }
}
