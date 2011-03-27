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
using OpticianDB.Adaptor;
using System.Drawing;

namespace OpticianDB.Forms
{

    public partial class UserEditor : Form //TODO: delete user
    {
        DBBackEnd dbb;
        const string passwordempty = "........";
        public UserEditor()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            dbb = Program.OProg.dbb;

            foreach (string enumval in Enum.GetNames(typeof(HashMethods)))
            {
                hashingMethod_ComboBox.Items.Add(enumval);
            }

        }

        void UserEditorLoad(object sender, EventArgs e)
        {
            hashingMethod_ComboBox.SelectedItem = HashMethods.Sha1.ToString();
            ReloadUsers();
        }
        void ReloadUsers()
        {
            user_List.Items.Clear();
            foreach (string UserName in dbb.UserNameList)
            {
                user_List.Items.Add(UserName);
            }
        }

        // Cant change own username
        void User_ListSelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: ask if save is needed
            if (user_List.SelectedIndex == -1)
                return;
            username_Text.Enabled = true;
            errorProvider.Clear();
            Users user = dbb.GetUserInfo(user_List.SelectedItem.ToString());
            if (Program.OProg.UserName == user.Username)
            {
                username_Text.Enabled = false;
            }
            this.username_Text.Text = user.Username;
            this.password_Text.Text = passwordempty;
            this.fullName_Text.Text = user.Fullname;
            this.hashingMethod_ComboBox.SelectedItem = ((HashMethods)user.PasswordHashMethod).ToString(); //TODO: standards this
            this.hashingMethod_ComboBox.Enabled = false;
        }

        void Password_TextEnter(object sender, EventArgs e)
        {
            if (password_Text.Text == passwordempty)
                password_Text.Text = string.Empty;
            //toolTip1.Show("If a blank password is entered the password will not be changed",password_Text,5000);
        }

        void Password_TextLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password_Text.Text))
            {
                password_Text.Text = passwordempty;
                //hashingMethod_ComboBox.Enabled = false;
            }
        }

        void CutToolStripButtonClick(object sender, EventArgs e)
        {
            //TODO
            throw new NotImplementedException();
        }

        void CopyToolStripButtonClick(object sender, EventArgs e)
        {
            //TODO
            throw new NotImplementedException();
        }

        void PasteToolStripButtonClick(object sender, EventArgs e)
        {
            //TODO
            throw new NotImplementedException();
        }

        void NewToolStripButtonClick(object sender, EventArgs e)
        {
            errorProvider.Clear();
            ClearForm();
        }

        void SaveToolStripButtonClick(object sender, EventArgs e)
        {
            bool newuser = user_List.SelectedIndex == -1;
            errorProvider.Clear();
            bool errortriggered = false;
            if (string.IsNullOrEmpty(username_Text.Text))
            {
                errorProvider.SetError(username_Text, "No username set");
                errortriggered = true;
            }
            if (newuser && (password_Text.Text == passwordempty || string.IsNullOrEmpty(password_Text.Text)))
            {
                errorProvider.SetError(password_Text, "No password set");
                errortriggered = true;
            }
            if (string.IsNullOrEmpty(fullName_Text.Text))
            {
                errorProvider.SetError(fullName_Text, "No name set");
                errortriggered = true;
            }
            if (errortriggered)
                return;
            bool result;
            if (newuser)
            {
                result = dbb.CreateNewUser(username_Text.Text, password_Text.Text, fullName_Text.Text,
                                           (HashMethods)Enum.Parse(typeof(HashMethods), hashingMethod_ComboBox.SelectedItem.ToString()));
            }
            else
            {
                result = dbb.AmendUser(user_List.SelectedItem.ToString(), username_Text.Text, password_Text.Text, fullName_Text.Text);
            }

            if (!result)
            {
                errorProvider.SetError(username_Text, "User exists");
                return;
            }
            ReloadUsers();

            ClearForm();
        }

        void ClearForm()
        {
            user_List.ClearSelected();
            username_Text.Text = "";
            password_Text.Text = passwordempty;
            fullName_Text.Text = "";
            username_Text.Focus();
            username_Text.Enabled = true;
            hashingMethod_ComboBox.SelectedItem = HashMethods.Sha1.ToString();
            hashingMethod_ComboBox.Enabled = true;
        }

        private void password_Text_TextChanged(object sender, EventArgs e)
        {
            //hashingMethod_ComboBox.Enabled = true;
        }


    }
}
