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

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form for holding an appointment that is currently being processed
    /// </summary>
    public partial class AppointmentInProgress : Form
    {
        /// <summary>
        ///   The ID of the appointment record that is currently being processed.
        /// </summary>
        private int appointmentId;

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   The ID of the patient that is associated with the current appointment.
        /// </summary>
        private int patientId;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "AppointmentInProgress" /> class. Sets the appointment ID globally, sets the patient information to the values from the record and adds the conditions to the list.
        /// </summary>
        /// <param name = "appointmentId">The appointment id.</param>
        public AppointmentInProgress(int appointmentId)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();

            this.appointmentId = appointmentId;

            PatientAppointments pa1 = dbb.GetAppointmentById(appointmentId);
            name_Text.Text = pa1.Patients.Name;
            dateOfBirth_Text.Text = pa1.Patients.DateOfBirth.ToLongDateString();
            nhsNumber_Text.Text = pa1.Patients.NhsnUmber;
            patientId = pa1.PatientID;
            apmtRemarks_Text.Text = pa1.Remarks;

            foreach (PatientConditions patientCondition in pa1.Patients.PatientConditions)
            {
                conditions_List.Items.Add(patientCondition.Conditions.Condition);
            }
        }

        /// <summary>
        ///   Handles the Click event of the SaveAppointment_Button control. Validates the form and if validation succeeds, the values are added to the database and the form is closed.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void SaveAppointment_Button_Click(object sender, EventArgs e)
        {
            if (!CanSave())
            {
                return;
            }

            dbb.StoreTestResults(appointmentId, rSph_Text.Text, lSph_Text.Text, rVa1_Text.Text, rVa2_Text.Text,
                                 lVa1_Text.Text, lVa2_Text.Text, rCyl_Text.Text, rAxis_Text.Text, lCyl_Text.Text,
                                 lAxis_Text.Text, remarks_Text.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///   Determines whether this instance can save the record in use. Attempts to parse each field for its database type and does a range check on the axis (Can only be 0-180). Returning errors if validation fails
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance can save; otherwise, <c>false</c>.
        /// </returns>
        private bool CanSave()
        {
            bool canSave = true;
            errorProvider.Clear();
            double tempDouble;
            int tempInt;

            if (string.IsNullOrEmpty(rSph_Text.Text) || !double.TryParse(rSph_Text.Text, out tempDouble))
            {
                errorProvider.SetError(rSph_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lSph_Text.Text) || !double.TryParse(lSph_Text.Text, out tempDouble))
            {
                errorProvider.SetError(lSph_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(rVa1_Text.Text) || !int.TryParse(rVa1_Text.Text, out tempInt))
            {
                errorProvider.SetError(rVa1_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(rVa2_Text.Text) || !int.TryParse(rVa2_Text.Text, out tempInt))
            {
                errorProvider.SetError(rVa2_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lVa1_Text.Text) || !int.TryParse(lVa1_Text.Text, out tempInt))
            {
                errorProvider.SetError(lVa1_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lVa2_Text.Text) || !int.TryParse(lVa2_Text.Text, out tempInt))
            {
                errorProvider.SetError(lVa2_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(rCyl_Text.Text) || !double.TryParse(rCyl_Text.Text, out tempDouble))
            {
                errorProvider.SetError(rCyl_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(rAxis_Text.Text) || !int.TryParse(rAxis_Text.Text, out tempInt))
            {
                errorProvider.SetError(rAxis_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lCyl_Text.Text) || !double.TryParse(lCyl_Text.Text, out tempDouble))
            {
                errorProvider.SetError(lCyl_Text, "Value is incorrect");
                canSave = false;
            }

            if (string.IsNullOrEmpty(lAxis_Text.Text) || !int.TryParse(lAxis_Text.Text, out tempInt))
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

        /// <summary>
        ///   Handles the Click event of the AddCondition_Button control. Adds a new condition to the patient record using the <see cref = "OpticianDB.Forms.Dialogs.AddConditionOnPatient" /> form and if the condition is added then the record is reloaded to add the new condition.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AddCondition_Button_Click(object sender, EventArgs e)
        {
            using (AddConditionOnPatient ac1 = new AddConditionOnPatient(patientId))
            {
                ac1.ShowDialog();
                if (ac1.DialogResult == DialogResult.OK)
                {
                    dbb.RefreshAdaptor();
                    PatientAppointments pa1 = dbb.GetAppointmentById(appointmentId);
                    conditions_List.Items.Clear();
                    foreach (PatientConditions patientCondition in pa1.Patients.PatientConditions)
                    {
                        conditions_List.Items.Add(patientCondition.Conditions.Condition);
                    }
                }
            }
        }

        /// <summary>
        ///   Handles the Click event of the PastTests_Button control. Opens a new <see cref = "TestResults" /> form showing all the results of the patients previous tests
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void PastTests_Button_Click(object sender, EventArgs e)
        {
            using (TestResults pa1 = new TestResults(patientId))
            {
                pa1.ShowDialog();
            }
        }
    }
}