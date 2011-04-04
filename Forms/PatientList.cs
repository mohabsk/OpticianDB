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
    /// A form for showing the user all the patients in the database and providing the user functionality to open a record.
    /// </summary>
    public partial class PatientList : Form
    {
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        DBBackEnd dbb;
        /// <summary>
        /// Gets or sets the Selected Patient Record.
        /// </summary>
        public PatientInfo SelectedPatient
        { get; set; }
        /// <summary>
        /// Initializes a new instance of the PatientList class. Populates the list of patients with the patients from the database
        /// </summary>
        public PatientList()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();
            foreach (string patient in dbb.PatientListWithNhsNumber)
            {
                patient_List.Items.Add(patient);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Patient_List control. Finds the currently selected NHS number, loads the record, fills out the fields with the information from the record and enables the load button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Patient_ListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (patient_List.SelectedIndex == -1)
                return;

            conditions_List.Items.Clear();
            string varstr = patient_List.SelectedItem.ToString();
            string nhsnum = varstr.Substring(0, varstr.IndexOf(" - "));

            int patientid = dbb.PatientIdByNhsNumber(nhsnum);
            Patients patientRecord = dbb.PatientRecord(patientid);

            this.name_Text.Text = patientRecord.Name;
            this.nhsNumber_Text.Text = patientRecord.NhsnUmber;
            this.address_Text.Text = patientRecord.Address;
            this.telNum_Text.Text = patientRecord.TelNum;
            this.email_Text.Text = patientRecord.Email;
            this.dateOfBirth_Text.Text = patientRecord.DateOfBirth.ToLongDateString();
            this.recallMethod_Text.Text = ((RecallMethods)patientRecord.PreferredRecallMethod).ToString();

            //patientRecord.PatientConditions
            //dbb.PatientConditionList(patientRecord.PatientID.Value)
            foreach (PatientConditions condition in patientRecord.PatientConditions)
            {
                conditions_List.Items.Add(condition.Conditions.Condition);
            }

            load_Button.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the Load_Button control. Finds the currently selected record ID. Gets the record from the record ID. Puts the record in a global variable and closes for another form to use the global variable
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Load_ButtonClick(object sender, EventArgs e)
        {
            string varstr = patient_List.SelectedItem.ToString();
            string nhsnum = varstr.Substring(0, varstr.IndexOf(" - "));

            int patientid = dbb.PatientIdByNhsNumber(nhsnum);

            SelectedPatient = new PatientInfo(patientid);
            this.Close();

        }

    }
}
