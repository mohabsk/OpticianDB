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
using OpticianDB.Extensions;
using System.Drawing;

namespace OpticianDB.Forms //TODO: print
{
    public partial class PatientInfo : Form
    {
        //TODO: show recall
        //TODO: Remove Recall Function
        DBBackEnd dbb;
        Patients rec;
        int grecid;

        public PatientInfo(int recid)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            grecid = recid;
            Reload_Record();
            name_Text.Text = rec.Name;
            address_Text.Text = rec.Address;
            telNum_Text.Text = rec.TelNum;
            dob_DateTime.Value = rec.DateOfBirth.Value;
            nhsNumber_Text.Text = rec.NhsnUmber;
            email_Text.Text = rec.Email;
            RecallMethods prm = (RecallMethods)rec.PreferredRecallMethod;
            switch (prm)
            {
                case RecallMethods.Post:
                    preferredRecall_Combo.SelectedIndex = 0;
                    break;
                case RecallMethods.Phone:
                    preferredRecall_Combo.SelectedIndex = 1;
                    break;
                case RecallMethods.Email:
                    preferredRecall_Combo.SelectedIndex = 2;
                    break;
            }
            //TODO: LOAD PREFERRED RECORD
            //TODO: Only show selectable preferred
            //TODO: DONT SELECT IF PREFERRED NOT SELECTED
            RefreshConditions();
        }

        private void Reload_Record()
        {
            if (dbb != null)
            {
                dbb.Dispose();
            }
            dbb = Program.oProg.dbb;
            rec = dbb.PatientRecord(grecid);
        }

        void RefreshConditions()
        {
            cnd_List.Items.Clear();
            foreach (PatientConditions condition in rec.PatientConditions)
            {
                cnd_List.Items.Add(condition.Conditions.Condition);
            }
        }

        void AddCnd_ButtonClick(object sender, EventArgs e)
        {
            Dialogs.AddConditionOnPatient acop1 = new Dialogs.AddConditionOnPatient(grecid);
            DialogResult dr = acop1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Reload_Record();
                RefreshConditions();
            }
        }

        void Amend_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool errorstriggered = false;
            telNum_Text.Text = telNum_Text.Text.Replace(" ", "");
            nhsNumber_Text.Text = nhsNumber_Text.Text.Replace(" ", "");
            //TODO: MEssagebox
            //TODO: Validation
            if (!Validation.Patient.Name(name_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(name_Text, "Name could not be validated\nDid you include the last name?\nDid you capitalise each part of the name?");
            }
            if (!Validation.Patient.TelNum(telNum_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(telNum_Text, "Telephone number could not be validated\nDid you include the area code?\nDid you prefix any international numbers with +?");
            }
            if (dob_DateTime.Value.InFuture())
            {
                errorstriggered = true;
                errorProvider.SetError(dob_DateTime, "Date of birth could not be validated\nAre you trying to add a date in the future?");
            }
            if (!Validation.Patient.NhsNumber(nhsNumber_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(nhsNumber_Text, "NHS number could not be validated");
            }
            if (!Validation.Patient.Email(email_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(email_Text, "Email could not be validated");
            }
            if (preferredRecall_Combo.SelectedIndex == -1)
            {
                errorstriggered = true;
                errorProvider.SetError(preferredRecall_Combo, "No preferred recall method selected");
            }
            if (!errorstriggered && !Validation.Patient.RecallMethod(preferredRecall_Combo.Text, address_Text.Text, email_Text.Text, telNum_Text.Text))
            {
                errorstriggered = true;
                errorProvider.SetError(preferredRecall_Combo, "Recall method is invalid\nYou could be trying to select a recall method where no value has been entered to recall");
            }
            if (errorstriggered)
            {
                return;
            }

            if (!dbb.AmendPatient(grecid, name_Text.Text, address_Text.Text, telNum_Text.Text, dob_DateTime.Value, nhsNumber_Text.Text, email_Text.Text, (RecallMethods)preferredRecall_Combo.SelectedIndex))
            {
                errorProvider.SetError(nhsNumber_Text, "NHS Number already exists");
            }
        }


        private void RemoveCnd_ButtonClick(object sender, EventArgs e)
        {
            string selecteditem = cnd_List.SelectedItem.ToString();
            if (MessageBox.Show("Do you want to remove the selected condition: " + selecteditem + "?",
                                "Confirm action", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                dbb.RemoveConditionByName(selecteditem, grecid);
                Reload_Record();
                RefreshConditions();
            }
        }

        private void NewApmt_ButtonClick(object sender, EventArgs e)
        {
        	using(Dialogs.NewAppointment na1 = new Dialogs.NewAppointment(grecid))
        	{
        		na1.ShowDialog();
        	}
        }

        private void ApmtHistory_ButtonClick(object sender, EventArgs e)
        {
            using (Dialogs.TestResults tr1 = new Dialogs.TestResults(grecid))
            {
                tr1.ShowDialog();
            }
        }

        private void SchedRecall_ButtonClick(object sender, EventArgs e)
        {
            using (Dialogs.NewRecall nr1 = new Dialogs.NewRecall(grecid))
            {
                nr1.ShowDialog();
            }
        }

        private void ApmtDue_ButtonClick(object sender, EventArgs e)
        {
        	using(Dialogs.AppointmentsOnPatient ap1 = new Dialogs.AppointmentsOnPatient(grecid))
        	{
                ap1.ShowDialog();
        	}
        }

        private void RemovePatient_ButtonClick(object sender, EventArgs e)
        { //TODO Dialog
            dbb.DeletePatient(this.grecid);
            this.Close();
        }

    }
}
