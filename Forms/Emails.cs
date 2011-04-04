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
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace OpticianDB.Forms
{
    /// <summary>
    /// A form for working with email templates
    /// </summary>
    public partial class Emails : Form //TODO: a blank email can be given
    {
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        DBBackEnd dbb;
        /// <summary>
        /// The id of the currently open email record or -1 if no record is open
        /// </summary>
        int openRecID = -1;
        /// <summary>
        /// Initializes a new instance of the <see cref="Emails"/> class. Refreshes the list of emails
        /// </summary>
        public Emails()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();
            RefreshList();

        }
        /// <summary>
        /// Refreshes the list of emails with values from the database.
        /// </summary>
        void RefreshList()
        {
            email_List.Items.Clear();
            foreach (string email in dbb.EmailList)
            {
                email_List.Items.Add(email);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Email_List control. Opens the selected record and fills out the values in the form so it can be edited aswell as storing the record id globally.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Email_ListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (email_List.SelectedIndex == -1)
                return;
            var erec = dbb.GetEmailRecord(email_List.SelectedItem.ToString());
            openRecID = erec.EmailID;
            name_Text.Text = erec.Name;
            email_Text.Text = erec.Value;
        }

        /// <summary>
        /// Handles the Click event of the Help_Button control. Shows a small dialogs showing the constants for writing emails.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Help_ButtonClick(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.AppendLine("Constants for writing emails:");
            sb1.AppendLine();
            sb1.AppendLine("$NAME$ for the patients name");
            MessageBox.Show(sb1.ToString(), "Email Editor Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the Click event of the NewEmail_Button control. Clears the form and the currently open record so a new record can be made.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void NewEmail_ButtonClick(object sender, EventArgs e) //TODO: Messsagebox
        {
            email_List.ClearSelected();
            openRecID = -1;
            email_Text.Text = string.Empty;
            name_Text.Text = string.Empty;

        }

        /// <summary>
        /// Handles the Click event of the Delete_Button control. If no record is opened then a message is shown to the user and no further action is taken otherwise the selected record is deleted from the database, the emails list is updated and the form is cleared for editing
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Delete_ButtonClick(object sender, EventArgs e)
        {
            if (openRecID == -1)
            {
                MessageBox.Show("No database record open", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbb.DeleteEmailRecord(openRecID);
            openRecID = -1;
            email_Text.Text = string.Empty;
            name_Text.Text = string.Empty;
            email_List.ClearSelected();
            RefreshList();

        }

        /// <summary>
        /// Handles the Click event of the Save_Button control. If a record already exists with the specified name then the record addition fails and the user is shown an informative message. Otherwise the email is added to the database. The form is cleared for new input and the list of emails is refreshed
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
       void Save_ButtonClick(object sender, EventArgs e) //TODO: email.text is not empty
        {
            if (openRecID == -1)
            {
                bool saved = dbb.SaveEmailRecord(name_Text.Text, email_Text.Text);
                if (!saved)
                {
                    MessageBox.Show("Record already exists with the specified name, Did not save", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                bool saved = dbb.AmendEmailRecord(openRecID, name_Text.Text, email_Text.Text);
                if (!saved)
                {
                    MessageBox.Show("Record already exists with the specified name, Did not save", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            name_Text.Text = string.Empty;
            email_Text.Text = string.Empty;
            openRecID = -1;
            RefreshList();
        }

    }
}
