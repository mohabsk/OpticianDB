// 
//  Copyright (c) 2011 Geoffrey Prytherch
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy of  this
//  software and associated documentation files (the "Software"), to deal in the Software
//  without restriction, including without limitation the rights to use, copy, modify, merge,
//  publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
//  to whom the Software is furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in all copies or
//  substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//  INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
//  PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
//  FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
//  OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//  DEALINGS IN THE SOFTWARE.
//  
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpticianDB.Adaptor;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form for recalling the user via email
    /// </summary>
    public partial class EmailRecall : Form
    {
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Contains the email of the patient currently in use
        /// </summary>
        private string email;

        /// <summary>
        ///   Contains the name of the patient currently in use
        /// </summary>
        private string name;

        /// <summary>
        ///   Contains the currently open recall record ID.
        /// </summary>
        private int recallId;

        /// <summary>
        ///   Contains the subject of the currently selected email template
        /// </summary>
        private string subject = "";

        /// <summary>
        ///   Initializes a new instance of the <see cref = "EmailRecall" /> class. Sets the global variables with patient information and refreshes the list of emails.
        /// </summary>
        /// <param name = "recallId">The recall id.</param>
        public EmailRecall(int recallId)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            dbb = new DBBackEnd();
            this.recallId = recallId;
            Patients patientRec = dbb.GetRecallByRclId(recallId).Patients;
            name = patientRec.Name;
            email = patientRec.Email;
            foreach (string emailrec in dbb.EmailList)
            {
                template_ComboBox.Items.Add(emailrec);
            }
        }

        /// <summary>
        ///   Handles the SelectedIndexChanged event of the Template_ComboBox control. Gets the selected email record and changes the field value to the template (Replacing the $NAME$ constant with the users name) and sets the subject
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Template_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (template_ComboBox.SelectedIndex == -1)
                return;

            Adaptor.Emails erec = dbb.GetEmailRecord(template_ComboBox.SelectedItem.ToString());
            email_Text.Text = erec.Value.Replace("$NAME$", name);
            subject = erec.Name; //TODO: change to subject
        }

        /// <summary>
        ///   Starts the default email client on the system with the current message.
        /// </summary>
        private void StartEmailClient()
        {
            StringBuilder fileName = new StringBuilder(); //TODO: open .eml file
            fileName.Append("mailto:");
            fileName.Append(email);
            fileName.Append("?subject=");
            fileName.Append(subject);
            fileName.Append("&body=");
            fileName.Append(email_Text.Text);
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = fileName.ToString();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.RedirectStandardOutput = false;
            myProcess.Start();
        }


        /// <summary>
        ///   Handles the Click event of the Send_Button control. Starts the email client on the system and closes.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Send_ButtonClick(object sender, EventArgs e)
        {
            StartEmailClient();
            DialogResult = DialogResult.OK;
            Close();
            //todo: delete recall
        }
    }
}