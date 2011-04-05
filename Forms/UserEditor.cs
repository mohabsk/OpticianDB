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

    /// <summary>
    /// A form for editing and adding users to the form
    /// </summary>
    public partial class UserEditor : Form //TODO: delete user
    {
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        DBBackEnd dbb;
        /// <summary>
        /// The string reprisenting an empty password field (So the user does not feel like their password is empty when loading a new record
        /// </summary>
        const string passwordempty = "........"; //TODO: notalways
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEditor"/> class. Adds all the hashing methods to the combo box in the form.
        /// </summary>
        public UserEditor()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            dbb = new DBBackEnd();

            foreach (string enumval in Enum.GetNames(typeof(HashMethods)))
            {
                hashingMethod_ComboBox.Items.Add(enumval);
            }

        }
        /// <summary>
        /// Handles the Load event of the UserEditor control. Selects the system preferred hashing method (SHA1) and reloads the users in the side bar.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void UserEditorLoad(object sender, EventArgs e)
        {
            hashingMethod_ComboBox.SelectedItem = HashMethods.Sha1.ToString();
            ReloadUsers();
        }
        /// <summary>
        /// Reloads the users from the database into the side bar
        /// </summary>
        void ReloadUsers()
        {
            user_List.Items.Clear();
            foreach (string UserName in dbb.UserNameList)
            {
                user_List.Items.Add(UserName);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the User_List control. If a user is selected then the user is loaded into the form and all the editing functionality is enabled. If the user is the current user then editing the username is disabled
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void User_ListSelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: ask if save is needed
            if (user_List.SelectedIndex == -1)
                return;
            username_Text.Enabled = true;
            errorProvider.Clear(); //TODO: this in email form?
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

        /// <summary>
        /// Handles the Enter event of the Password_Text control. If the string is the empty password sequence then replace it with an empty string
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Password_TextEnter(object sender, EventArgs e)
        {
            if (password_Text.Text == passwordempty)
                password_Text.Text = string.Empty;
            //toolTip1.Show("If a blank password is entered the password will not be changed",password_Text,5000);
        }

        /// <summary>
        /// Handles the Leave event of the Password_Text control. If the password is blank then change the password text box to the empty password sequence
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Password_TextLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password_Text.Text))
            {
                password_Text.Text = passwordempty;
                //hashingMethod_ComboBox.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the NewToolStripButton control. Clears the form and Error Provider for data entry
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void NewToolStripButtonClick(object sender, EventArgs e)
        {
            errorProvider.Clear();
            ClearForm();
        }

        /// <summary>
        /// Handles the Click event of the SaveToolStripButton control. If the form can be validated then the user is created or amended respectively. If the username changed to/added is the same as an existing username the operation fails and the user is informed. Finally the form is cleared.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void SaveToolStripButtonClick(object sender, EventArgs e)
        {

            if (!CanSave())
                return;
            bool newuser = user_List.SelectedIndex == -1;
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

        /// <summary>
        /// Checks the form to see if it validates correctly. If not then it stops saving from occur
        /// </summary>
        /// <returns><c>true</c> if the form can be saved; Otherwise, <c>false</c></returns>
        private bool CanSave()
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
            return !errortriggered;
        }

        /// <summary>
        /// Clears the form for data entry
        /// </summary>
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


    }
}
