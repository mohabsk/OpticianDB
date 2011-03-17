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

namespace OpticianDB.Forms
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
            grecid = recid;
            Reload_Record();
            name_Text.Text = rec.Name;
            address_Text.Text = rec.Address;
            telNum_Text.Text = rec.TelNum;
            dob_DateTime.Value = rec.DateOfBirth.Value;
            nhsNumber_Text.Text = rec.NhsnUmber;
            email_Text.Text = rec.Email;
            Enums.RecallMethods prm = (Enums.RecallMethods)rec.PreferredRecallMethod;
            if (prm == Enums.RecallMethods.Post)
            {
                preferredRecall_Combo.SelectedIndex = 0;
            }
            else if (prm == Enums.RecallMethods.Phone)
            {
                preferredRecall_Combo.SelectedIndex = 1;
            }
            else
            {
                preferredRecall_Combo.SelectedIndex = 2;
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
            dbb = new DBBackEnd();
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

        void Button2Click(object sender, EventArgs e)
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
            errorProvider1.Clear();
            bool errorstriggered = false;
            telNum_Text.Text = telNum_Text.Text.Replace(" ", "");
            nhsNumber_Text.Text = nhsNumber_Text.Text.Replace(" ", "");
            //TODO: MEssagebox
            //TODO: Validation
            if (!Validation.Patient.Name(name_Text.Text))
            {
                errorstriggered = true;
                errorProvider1.SetError(name_Text, "Name could not be validated\nDid you include the last name?\nDid you capitalise each part of the name?");
            }
            if (!Validation.Patient.TelNum(telNum_Text.Text))
            {
                errorstriggered = true;
                errorProvider1.SetError(telNum_Text, "Telephone number could not be validated\nDid you include the area code?\nDid you prefix any international numbers with +?");
            }
            if (dob_DateTime.Value.InFuture())
            {
                errorstriggered = true;
                errorProvider1.SetError(dob_DateTime, "Date of birth could not be validated\nAre you trying to add a date in the future?");
            }
            if (!Validation.Patient.NHSNumber(nhsNumber_Text.Text))
            {
                errorstriggered = true;
                errorProvider1.SetError(nhsNumber_Text, "NHS number could not be validated");
            }
            if (!Validation.Patient.Email(email_Text.Text))
            {
                errorstriggered = true;
                errorProvider1.SetError(email_Text, "Email could not be validated");
            }
            if (preferredRecall_Combo.SelectedIndex == -1)
            {
                errorstriggered = true;
                errorProvider1.SetError(preferredRecall_Combo, "No preferred recall method selected");
            }
            if (!errorstriggered && !Validation.Patient.RecallMethod(preferredRecall_Combo.Text, address_Text.Text, email_Text.Text, telNum_Text.Text))
            {
                errorstriggered = true;
                errorProvider1.SetError(preferredRecall_Combo, "Recall method is invalid\nYou could be trying to select a recall method where no value has been entered to recall");
            }
            if (errorstriggered)
            {
                return;
            }

            if (!dbb.AmmendPatient(grecid, name_Text.Text, address_Text.Text, telNum_Text.Text, dob_DateTime.Value, nhsNumber_Text.Text, email_Text.Text, (Enums.RecallMethods)preferredRecall_Combo.SelectedIndex))
            {
                errorProvider1.SetError(nhsNumber_Text, "NHS Number already exists");
            }
        }

        void TextBox3TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Dialogs.NewRecall nr1 = new Dialogs.NewRecall(grecid))
            {
                nr1.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button8_Click(object sender, EventArgs e)
        { //TODO Dialog
            dbb.DeletePatient(this.grecid);
            this.Close();
        }

    }
}
