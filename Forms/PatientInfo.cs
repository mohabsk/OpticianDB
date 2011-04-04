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
using OpticianDB.Forms.Dialogs;
using OpticianDB.Validation;

namespace OpticianDB.Forms
{
	/// <summary>
	/// A form displaying all the information on a current patient. The form also contains common tasks to change information of the user record.
	/// </summary>
    public partial class PatientInfo : Form
    {
        //TODO: show recall
        //TODO: Remove Recall Function
        //TODO: CAN BE IN USE WITH MORE THAN ONE PATIENT ERRRRRRRR
        //TODO: PRINT

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Contains the currently used Record ID
        /// </summary>
        private int inUseRecId;

        /// <summary>
        ///   Contains the patients record associated with the current patient.
        /// </summary>
        private Patients rec;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "PatientInfo" /> class. Sets global variables, reloads the backend and sets values of the form to their respective values from the record
        /// </summary>
        /// <param name = "recid">The recid.</param>
        public PatientInfo(int recid)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            inUseRecId = recid;

            Reload_Record();
            name_Text.Text = rec.Name;
            address_Text.Text = rec.Address;
            telNum_Text.Text = rec.TelNum;
            dob_DateTime.Value = rec.DateOfBirth;
            nhsNumber_Text.Text = rec.NhsnUmber;
            email_Text.Text = rec.Email;

            switch ((RecallMethods)rec.PreferredRecallMethod)
            {
                case RecallMethods.Post:
                    preferredRecall_Combo.SelectedItem = "Post";
                    break;
                case RecallMethods.Phone:
                    preferredRecall_Combo.SelectedItem = "Phone";
                    break;
                case RecallMethods.Email:
                    preferredRecall_Combo.SelectedItem = "Email";
                    break;
            }
            //TODO: LOAD PREFERRED RECORD
            //TODO: Only show selectable preferred
            //TODO: DONT SELECT IF PREFERRED NOT SELECTED
            RefreshConditions();
        }

        /// <summary>
        ///   Reloads the record in use by refreshing the adaptor (or initializing one) and sets the record globally.
        /// </summary>
        private void Reload_Record()
        {
            if (dbb == null)
            {
                dbb = new DBBackEnd();
            }
            else
            {
                dbb.RefreshAdaptor();
            }
            rec = dbb.PatientRecord(inUseRecId);
        }

        /// <summary>
        ///   Refreshes the conditions currently in the form by clearing the condition list and adding them again from the global record.
        /// </summary>
        private void RefreshConditions()
        {
            cnd_List.Items.Clear();
            foreach (PatientConditions condition in rec.PatientConditions)
            {
                cnd_List.Items.Add(condition.Conditions.Condition);
            }
        }

        /// <summary>
        ///   Handles the Click event of the AddCnd_Button control.  Calls a new <see cref = "OpticianDB.Forms.Dialogs.AddConditionOnPatient" /> dialog to add a new condition to the patient. If one is added the condition list is reloaded
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AddCnd_ButtonClick(object sender, EventArgs e)
        {
            AddConditionOnPatient acop1 = new AddConditionOnPatient(inUseRecId);
            DialogResult dr = acop1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Reload_Record();
                RefreshConditions();
            }
        }

        /// <summary>
        ///   Handles the Click event of the Amend control. Replaces any extra characters in the telephone number and nhs number forms. Validates the controls, If the validation passes the form is saved, if there is an error in saving then display the error to the user.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Amend_Click(object sender, EventArgs e)
        {
            telNum_Text.Text = telNum_Text.Text.Replace(" ", "");
            nhsNumber_Text.Text = nhsNumber_Text.Text.Replace(" ", "");
            //TODO: MEssagebox

            if (!CanSave())
                return;


            if (
                !dbb.AmendPatient(inUseRecId, name_Text.Text, address_Text.Text, telNum_Text.Text, dob_DateTime.Value,
                                  nhsNumber_Text.Text, email_Text.Text,
                                  (RecallMethods) preferredRecall_Combo.SelectedIndex))
                errorProvider.SetError(nhsNumber_Text, "NHS Number already exists");
        }

        /// <summary>
        ///   Determines whether this instance can save by validating all values in the form, displaying errors to the user if errors are found.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance can save; otherwise, <c>false</c>.
        /// </returns>
        private bool CanSave()
        {
            errorProvider.Clear();
            bool errorstriggered = false;
            if (!Patient.Name(name_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(name_Text,
                                       "Name could not be validated\nDid you include the last name?\nDid you capitalise each part of the name?");
            }
            if (!Patient.TelNum(telNum_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(telNum_Text,
                                       "Telephone number could not be validated\nDid you include the area code?\nDid you prefix any international numbers with +?");
            }
            if (dob_DateTime.Value.InFuture())
            {
                errorstriggered = true;
                errorProvider.SetError(dob_DateTime,
                                       "Date of birth could not be validated\nAre you trying to add a date in the future?");
            }
            if (!Patient.NhsNumber(nhsNumber_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(nhsNumber_Text, "NHS number could not be validated");
            }
            if (!Patient.Email(email_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(email_Text, "Email could not be validated");
            }
            if (preferredRecall_Combo.SelectedIndex == -1)
            {
                errorstriggered = true;
                errorProvider.SetError(preferredRecall_Combo, "No preferred recall method selected");
            }
            if (!errorstriggered &&
                !Patient.RecallMethod(preferredRecall_Combo.Text, address_Text.Text, email_Text.Text, telNum_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(preferredRecall_Combo,
                                       "Recall method is invalid\nYou could be trying to select a recall method where no value has been entered to recall");
            }
            return !errorstriggered;
        }


        /// <summary>
        ///   Handles the Click event of the RemoveCnd_Button control. Confirms with the user that they wish to remove the selected condition and if they do, the condition is removed from the database and the list is reloaded
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void RemoveCnd_ButtonClick(object sender, EventArgs e)
        {
            if (cnd_List.SelectedIndex == -1)
                return;
            string selecteditem = cnd_List.SelectedItem.ToString();
            if (MessageBox.Show("Do you want to remove the selected condition: " + selecteditem + "?",
                                "Confirm action", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                dbb.RemoveConditionByName(selecteditem, inUseRecId);
                Reload_Record();
                RefreshConditions();
            }
        }

        /// <summary>
        ///   Handles the Click event of the NewApmt_Button control. Simply calls a new instance of the <see cref = "OpticianDB.Forms.Dialogs.NewAppointment" /> form with the current patient ID to add a new appointment to the patient
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void NewApmt_ButtonClick(object sender, EventArgs e)
        {
            using (NewAppointment na1 = new NewAppointment(inUseRecId))
            {
                na1.ShowDialog();
            }
        }

        /// <summary>
        ///   Handles the Click event of the ApmtHistory_Button control. Simply calls a new instance of the <see cref = "OpticianDB.Forms.Dialogs.TestResults" /> form to show the patients previous test results.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void ApmtHistory_ButtonClick(object sender, EventArgs e)
        {
            using (TestResults tr1 = new TestResults(inUseRecId))
            {
                tr1.ShowDialog();
            }
        }

        /// <summary>
        ///   Handles the Click event of the SchedRecall_Button control. Simply calls a new instance of the <see cref = "OpticianDB.Forms.Dialogs.NewRecall" /> form to add/ammend a recall to the patient.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void SchedRecall_ButtonClick(object sender, EventArgs e)
        {
            using (NewRecall nr1 = new NewRecall(inUseRecId))
            {
                nr1.ShowDialog();
            }
        }

        /// <summary>
        ///   Handles the Click event of the ApmtDue_Button control. Calls a new instance of the <see cref = "OpticianDB.Forms.Dialogs.AppointmentsOnPatient" /> form and if the patient opens an appointment record then a new <see cref = "OpticianDB.Forms.Dialogs.AppointmentInProgress" /> form is added using the selected record.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void ApmtDue_ButtonClick(object sender, EventArgs e)
        {
            using (AppointmentsOnPatient ap1 = new AppointmentsOnPatient(inUseRecId))
            {
                ap1.ShowDialog();
                if (ap1.DialogResult == DialogResult.OK)
                {
                    using (AppointmentInProgress ap2 = new AppointmentInProgress(ap1.recId))
                    {
                        ap2.ShowDialog();
                    }
                }
            }
        }

        /// <summary>
        ///   Handles the Click event of the RemovePatient_Button control. Deletes all references of the patient and closes the form.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void RemovePatient_ButtonClick(object sender, EventArgs e)
        {
            //TODO Dialog
            dbb.DeletePatient(inUseRecId);
            Close();
        }
    }
}