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
using System.Drawing;
using System.Windows.Forms;
using OpticianDB.Adaptor;
using OpticianDB.Extensions;
using OpticianDB.Validation;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form that allows a recall to be added to or modified on a patient
    /// </summary>
    public partial class NewRecall : Form
    {
        private Patients Patientrec;

        /// <summary>
        ///   Marked as true if the record currently in use is being amended or false if the record is being replaced/No record is open
        /// </summary>
        private bool amend = false;

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   The currently opened record ID if the patient already has an assigned recall
        /// </summary>
        private int patientId;

        public NewRecall(int patientId)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            dbb = new DBBackEnd();
            this.patientId = patientId;
            Patientrec = dbb.PatientRecord(patientId);
        }

        /// <summary>
        ///   Validates the record and if the record validates, the record is amended or saved. Finally the form is closed
        /// </summary>
        /// <param name = "sender">The sender.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void OKClick(object sender, EventArgs e)
        {
            if (CanSave())
                return;
            if (amend)
            {
                dbb.AmendRecall(patientId, datePrefTime_DateTime.Value, reason_Text.Text,
                                (RecallMethods) method_ComboBox.SelectedIndex);
            }
            else
            {
                dbb.SaveRecall(patientId, datePrefTime_DateTime.Value, reason_Text.Text,
                               (RecallMethods) method_ComboBox.SelectedIndex);
            }
            //TODO: messagebox confirmation
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///   Determines whether this instance can save by validating each field of the form, If any fields do not validate an error is displayed for the user and the record does not save.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance can save; otherwise, <c>false</c>.
        /// </returns>
        private bool CanSave()
        {
            bool errorstriggered = false;
            errorProvider.Clear();
            if (datePrefTime_DateTime.Value.InPast())
            {
                errorProvider.SetError(datePrefTime_DateTime, "Date and preferred time cannot be in the past");
                errorstriggered = true;
            }
            if (string.IsNullOrEmpty(reason_Text.Text))
            {
                errorProvider.SetError(reason_Text, "Reason cannot be empty");
                errorstriggered = true;
            }
            if (method_ComboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(method_ComboBox, "No method of recall selected");
                errorstriggered = true;
            }
            if (!errorstriggered &&
                !Patient.RecallMethod(method_ComboBox.SelectedItem.ToString(), Patientrec.Address, Patientrec.Email,
                                      Patientrec.TelNum))
            {
                errorProvider.SetError(method_ComboBox, "Method of recall is invalid for the given patient");
                errorstriggered = true;
            }
            return !errorstriggered;
        }

        private void CancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        ///   Handles the Load event of the NewRecall form. Adds recall methods to the form based on whether the patient can accept the recall methods. Also selects their preferred recall method
        /// </summary>
        /// <param name = "sender">The sender.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void NewRecallLoad(object sender, EventArgs e)
        {
            if (dbb.CanPatientBePosted(Patientrec))
            {
                method_ComboBox.Items.Add("Post");
            }
            if (dbb.CanPatientBePhoned(Patientrec))
            {
                method_ComboBox.Items.Add("Phone");
            }
            if (dbb.CanPatientBeEmailed(Patientrec))
            {
                method_ComboBox.Items.Add("Email");
            }
            RecallMethods prm = (RecallMethods) Patientrec.PreferredRecallMethod;
            switch (prm)
            {
                case RecallMethods.Post:
                    method_ComboBox.SelectedItem = "Post";
                    break;
                case RecallMethods.Phone:
                    method_ComboBox.SelectedItem = "Phone";
                    break;
                case RecallMethods.Email:
                    method_ComboBox.SelectedItem = "Email";
                    break;
            }


            if (dbb.OutstandingRecall(patientId))
            {
                HandleOutstandingRecord();
            }
        }

        /// <summary>
        ///   If an outstanding recall has been found the user is prompted for confirmation. If they select to amend the values of the record will be loaded into the form. If they select no then the record will be deleted and replaced when they save. If they cancel the form will close
        /// </summary>
        private void HandleOutstandingRecord()
        {
            PatientRecalls pr1 = dbb.GetRecall(patientId);
            DialogResult dr =
                MessageBox.Show("An outstanding recall was found\nPress yes to load this or no to make a new recall",
                                "Recall Found", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                amend = true;
                datePrefTime_DateTime.Value = pr1.DateAndPrefTime.Value;
                reason_Text.Text = pr1.Reason;
                RecallMethods prm2 = (RecallMethods) pr1.Method;
                if (prm2 == RecallMethods.Post)
                {
                    method_ComboBox.SelectedItem = "Post";
                }
                else if (prm2 == RecallMethods.Phone)
                {
                    method_ComboBox.SelectedItem = "Phone";
                }
                else
                {
                    method_ComboBox.SelectedItem = "Email"; //TODO: whatif recall method has been removed
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}