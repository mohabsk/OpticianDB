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
    /// <summary>
    /// A form used for authenticating a user to the system
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            FormState = true;
        }

        /// <summary>
        /// Handles the Click event of the OK control. Disables the form, passes the users information to the Asyncronous worker to start logon and enables the progress indicator.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OK_Click(object sender, EventArgs e)
        {
            if (!FormState)
                return;
            progressIndicator1.Visible = true;
            Adaptor.Users u1 = new Adaptor.Users { Username = UsernameTextBox.Text, Password = PasswordTextBox.Text };
            FormState = false;
            login_BackgroundWorker.RunWorkerAsync(u1);
        }

        /// <summary>
        /// Handles the Click event of the Cancel control. Immediatly stops login and exits the program
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Handles the DoWork event of the Login_BackgroundWorker control. Logs the user using the inbuilt method. Runs in a seperate thread to the GUI as running it in the same thread can block the GUI for several seconds leading the user to assume the program has crashed. Returns the result of the login
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e"></param>
        void Login_BackgroundWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Adaptor.Users u1 = (Adaptor.Users)e.Argument;
            using (DBBackEnd dbb = new DBBackEnd())
            {
                e.Result = dbb.LogOn(u1.Username, u1.Password);
            }
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the Login_BackgroundWorker control. Makes the progress indicator invisible once more, if the login is successful the form closes and the user is redirected to the Main form, else the user is informed and is allowed to attempt to login again
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// A value indicating whether the form is enabled or disabled for input
        /// </summary>
        private bool _formState;
        /// <summary>
        /// Gets or sets the FormState. A value which enables and disables input on the form.
        /// </summary>
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
