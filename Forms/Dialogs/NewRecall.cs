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

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    /// Description of NewRecall.
    /// </summary>
    public partial class NewRecall : Form
    {
        DBBackEnd dbb;
        int patientId; //TODO: use -1 and ting
        bool amend = false;
        Patients Patientrec;
        public NewRecall(int patientId)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            dbb = Program.oProg.dbb;
            this.patientId = patientId;
            Patientrec = dbb.PatientRecord(patientId);

        }

        void OKClick(object sender, EventArgs e)
        {
            bool errorstriggered = false;
            errorProvider1.Clear();
            if (datePrefTime_DateTime.Value.InPast())
            {
                errorProvider1.SetError(datePrefTime_DateTime, "Date and preferred time cannot be in the past");
                errorstriggered = true;
            }
            if (string.IsNullOrEmpty(reason_Text.Text))
            {
                errorProvider1.SetError(reason_Text, "Reason cannot be empty");
                errorstriggered = true;
            }
            if (method_ComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(method_ComboBox, "No method of recall selected");
                errorstriggered = true;
            }
            if (!errorstriggered && !Validation.Patient.RecallMethod(method_ComboBox.SelectedItem.ToString(), Patientrec.Address, Patientrec.Email, Patientrec.TelNum))
            {
                errorProvider1.SetError(method_ComboBox, "Method of recall is invalid for the given patient");
                errorstriggered = true;
            }
            if (errorstriggered)
                return;
            if (amend)
            {
                dbb.AmendRecall(patientId, datePrefTime_DateTime.Value, reason_Text.Text, (RecallMethods)method_ComboBox.SelectedIndex);
            }
            else
            {
                dbb.SaveRecall(patientId, datePrefTime_DateTime.Value, reason_Text.Text, (RecallMethods)method_ComboBox.SelectedIndex);
            }
            //TODO: messagebox confirmation
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        void CancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void NewRecallLoad(object sender, EventArgs e)
        {
            int postrec = -1;
            int phonerec = -1;
            int emailrec = -1;

            if (dbb.CanPatientBePosted(Patientrec))
            {
                postrec = method_ComboBox.Items.Add("Post");
            }
            if (dbb.CanPatientBePhoned(Patientrec))
            {
                phonerec = method_ComboBox.Items.Add("Phone");
            }
            if (dbb.CanPatientBeEmailed(Patientrec))
            {
                emailrec = method_ComboBox.Items.Add("Email");
            }
            RecallMethods prm = (RecallMethods)Patientrec.PreferredRecallMethod;
            switch (prm)
            {
                case RecallMethods.Post:
                    method_ComboBox.SelectedIndex = postrec;
                    break;
                case RecallMethods.Phone:
                    method_ComboBox.SelectedIndex = phonerec;
                    break;
                case RecallMethods.Email:
                    method_ComboBox.SelectedIndex = emailrec;
                    break;
            }


            if (dbb.OutstandingRecall(patientId))
            {
                PatientRecalls pr1 = dbb.GetRecall(patientId);
                DialogResult dr = MessageBox.Show("An outstanding recall was found\nPress yes to load this or no to make a new recall", "Recall Found", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    amend = true;
                    datePrefTime_DateTime.Value = pr1.DateAndPrefTime.Value;
                    reason_Text.Text = pr1.Reason;
                    RecallMethods prm2 = (RecallMethods)pr1.Method;
                    if (prm2 == RecallMethods.Post)
                    {
                        method_ComboBox.SelectedIndex = postrec;
                    }
                    else if (prm2 == RecallMethods.Phone)
                    {
                        method_ComboBox.SelectedIndex = phonerec;
                    }
                    else
                    {
                        method_ComboBox.SelectedIndex = emailrec;
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }
    }
}
