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
using System.Drawing;
using System.Windows.Forms;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    /// Description of AppointmentInProgress.
    /// </summary>
    public partial class AppointmentInProgress : Form
    {
        private int appointmentId;
        private int patientId;
        private DBBackEnd dbb;
        public AppointmentInProgress(int appointmentId)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.appointmentId = appointmentId;
            dbb = new DBBackEnd();
            var pa1 = dbb.GetAppointmentById(appointmentId);
            name_Text.Text = pa1.Patients.Name;
            dateOfBirth_Text.Text = pa1.Patients.DateOfBirth.Value.ToLongDateString();
            nhsNumber_Text.Text = pa1.Patients.NhsnUmber;
            patientId = pa1.PatientID;
            remarks_Text.Text = pa1.Remarks;
            foreach (var patientCondition in pa1.Patients.PatientConditions)
            {
                conditions_List.Items.Add(patientCondition.Conditions.Condition);
            }
        }

        private void SaveAppointment_Button_Click(object sender, EventArgs e)
        {
            if (!CanSave())
            {
                return;
            }

            dbb.StoreTestResults(appointmentId, rSph_Text.Text, lSph_Text.Text, rVa1_Text.Text, rVa2_Text.Text, lVa1_Text.Text, lVa2_Text.Text, rCyl_Text.Text, rAxis_Text.Text, lCyl_Text.Text, lAxis_Text.Text, remarks_Text.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool CanSave()
        {
            bool canSave = true;
            errorProvider.Clear();
            double what;
            int wha;

            if (string.IsNullOrEmpty(rSph_Text.Text) || !double.TryParse(rSph_Text.Text, out what))
            {
                errorProvider.SetError(rSph_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lSph_Text.Text) || !double.TryParse(lSph_Text.Text, out what))
            {
                errorProvider.SetError(lSph_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(rVa1_Text.Text) || !int.TryParse(rVa1_Text.Text, out wha))
            {
                errorProvider.SetError(rVa1_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(rVa2_Text.Text) || !int.TryParse(rVa2_Text.Text, out wha))
            {
                errorProvider.SetError(rVa2_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lVa1_Text.Text) || !int.TryParse(lVa1_Text.Text, out wha))
            {
                errorProvider.SetError(lVa1_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lVa2_Text.Text) || !int.TryParse(lVa2_Text.Text, out wha))
            {
                errorProvider.SetError(lVa2_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(rCyl_Text.Text) || !double.TryParse(rCyl_Text.Text, out what))
            {
                errorProvider.SetError(rCyl_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(rAxis_Text.Text) || !int.TryParse(rAxis_Text.Text, out wha))
            {
                errorProvider.SetError(rAxis_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lCyl_Text.Text) || !double.TryParse(lCyl_Text.Text, out what))
            {
                errorProvider.SetError(lCyl_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lAxis_Text.Text) || !int.TryParse(lAxis_Text.Text, out wha))
            {
                errorProvider.SetError(lAxis_Text, "Value is incorrect");
                canSave = false;
            }

            if (!canSave)
            {
                return false;
            }

            if (int.Parse(rAxis_Text.Text) < 0 || int.Parse(rAxis_Text.Text) > 180)
            {
                errorProvider.SetError(rAxis_Text, "Axis can only be between 0 and 180");
                canSave = false;
            }

            if (int.Parse(lAxis_Text.Text) < 0 || int.Parse(lAxis_Text.Text) > 180)
            {
                errorProvider.SetError(lAxis_Text, "Axis can only be between 0 and 180");
                canSave = false;
            }

            return canSave;
        }

        private void AddCondition_Button_Click(object sender, EventArgs e)
        {
            using (AddConditionOnPatient ac1 = new AddConditionOnPatient(patientId))
            {
                ac1.ShowDialog();
                if (ac1.DialogResult == DialogResult.OK)
                {
                    dbb.RefreshAdaptor(); //FIXME
                    var pa1 = dbb.GetAppointmentById(appointmentId);
                    conditions_List.Items.Clear();
                    foreach (var patientCondition in pa1.Patients.PatientConditions)
                    {
                        conditions_List.Items.Add(patientCondition.Conditions.Condition);
                    }
                }
            }
        }

        private void PastTests_Button_Click(object sender, EventArgs e)
        {
            using (PastAppointments pa1 = new PastAppointments(patientId))
            {
                pa1.ShowDialog();
            }
        }


    }
}
