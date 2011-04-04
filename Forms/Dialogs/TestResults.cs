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

using OpticianDB.Adaptor;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    /// A form for displaying the past test results of a patient
    /// </summary>
    public partial class TestResults : Form
    {
        /// <summary>
        /// Stores the patient ID of the patient record currently open
        /// </summary>
        private int patientId;
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        DBBackEnd dbb;
        /// <summary>
        /// Stores the record ID of the Patient Test Results record currently in use
        /// </summary>
        int recId;
        /// <summary>
        /// Initializes a new instance of the <see cref = "TestResults" /> class. Sets global variables and refreshes the list of appointments for the selected patient.
        /// </summary>
        /// <param name="patientId">The record ID of the selected patient</param>
        public TestResults(int patientId)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();
            this.patientId = patientId;
            RefreshList();
        }

        /// <summary>
        /// Refreshes the list of test results.
        /// </summary>
        void RefreshList()
        {
            dbb.RefreshAdaptor();
            results_List.Items.Clear();
            foreach (string testString in dbb.TestResults(patientId))
            {
                results_List.Items.Add(testString);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Results_List control. Gets the currently selected record ID and loads the record for the selected ID. Populates the form with the loaded record and enables the amend button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Results_ListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (results_List.SelectedIndex == -1)
                return;
            string itemStr = results_List.SelectedItem.ToString();
            string numStr = itemStr.Remove(0, 1).Split(new string[] { ":" }, StringSplitOptions.None)[0];
            recId = int.Parse(numStr);

            PatientTestResults testResult = dbb.GetTestResult(recId);

            testDate_Text.Text = testResult.Date.Value.ToLongDateString();
            rSph_Text.Text = testResult.RSpH;
            lSph_Text.Text = testResult.LSpH;
            rVa1_Text.Text = testResult.RvA1;
            rVa2_Text.Text = testResult.RvA2;
            lVa1_Text.Text = testResult.LVA1;
            lVa2_Text.Text = testResult.LVA2;
            rCyl_Text.Text = testResult.RcYL;
            rAxis_Text.Text = testResult.RAxis;
            lCyl_Text.Text = testResult.LcYL;
            lAxis_Text.Text = testResult.LaxIs;
            remarks_Text.Text = testResult.Remarks;

            users_Text.Text = testResult.Users.Username;

            amend_Button.Enabled = true;
        }

        /// <summary>
        /// Shows a new <see cref="TestResult"/> dialog and if the user amends or deletes the test result record then the list is refreshed, the form is cleared and the amend button is disabled
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Amend_ButtonClick(object sender, EventArgs e)
        {
            using (TestResult tr1 = new TestResult(recId))
            {
                tr1.ShowDialog();
                if (tr1.DialogResult == DialogResult.OK)
                {
                    RefreshList();
                    testDate_Text.Text = "";
                    rSph_Text.Text = "";
                    lSph_Text.Text = "";
                    rVa1_Text.Text = "";
                    rVa2_Text.Text = "";
                    lVa1_Text.Text = "";
                    lVa2_Text.Text = "";
                    rCyl_Text.Text = "";
                    rAxis_Text.Text = "";
                    lCyl_Text.Text = "";
                    lAxis_Text.Text = "";
                    remarks_Text.Text = "";
                    users_Text.Text = "";
                    amend_Button.Enabled = false;
                }
            }
        }
    }
}
