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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpticianDB.Adaptor;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form that associates a condition with a patient record
    /// </summary>
    public partial class AddConditionOnPatient : Form
    {
        /// <summary>
        ///   Contains the patient that a condition is being added to
        /// </summary>
        private Patients PatientInfo;

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "AddConditionOnPatient" /> class. Loads the given patient record and refreshes the condition list.
        /// </summary>
        /// <param name = "PatientID">The patient ID of the patient being modified.</param>
        public AddConditionOnPatient(int PatientID)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();

            PatientInfo = dbb.PatientRecord(PatientID);

            RefreshConditionsList();
        }

        /// <summary>
        ///   Refreshes the list of conditions that can affect the patient. Adds all the conditions to a list and removes the ones affecting the current patient before adding to the listbox.
        /// </summary>
        private void RefreshConditionsList()
        {
            condition_List.Items.Clear();
            List<string> CndList = new List<string>();
            foreach (PatientConditions cnd in PatientInfo.PatientConditions) //TODO: rejig
            {
                CndList.Add(cnd.Conditions.Condition);
            }
            foreach (string Condition in dbb.ConditionsList)
            {
                bool found = false;
                foreach (string Cnd in CndList)
                {
                    if (Cnd == Condition)
                    {
                        found = true;
                    }
                }
                if (!found) //TODO: test
                {
                    condition_List.Items.Add(Condition);
                }
            }
        }

        /// <summary>
        ///   Handles the Click event of the cancel_Button control. Closes the form
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Cancel_ButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        ///   Handles the Click event of the addCondition_Button control. Calls a dialog to add a condition and if a condition is added, that condition is selected.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AddCondition_ButtonClick(object sender, EventArgs e)
        {
            using (AddCondition ac1 = new AddCondition())
            {
                ac1.ShowDialog();

                if (ac1.DialogResult == DialogResult.OK)
                    //TODO: DIALOGRESULT FOR ALL, NOT FAFFING ABOUT WITH LOCAL VARS FROM RETURNED RESULTS
                {
                    RefreshConditionsList();
                    string condition = dbb.GetConditionName(ac1.SelectedCondition);
                    condition_List.SelectedIndex = condition_List.Items.IndexOf(condition);
                }
            }
        }

        /// <summary>
        ///   Handles the Click event of the OK_Button control. Returns an error if no record is selected otherwise adds the selected condition to the patient and closes
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void OK_ButtonClick(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (condition_List.SelectedIndex == -1)
            {
                errorProvider1.SetError(condition_List, "No record has been selected");
                return;
            }
            dbb.AttachCondition(PatientInfo.PatientID, dbb.ConditionId(condition_List.SelectedItem.ToString()));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}