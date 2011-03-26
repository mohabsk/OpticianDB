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
using System.Collections.Generic;
using System.Windows.Forms;

using OpticianDB.Adaptor;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    /// Description of AddConditionOnPatient.
    /// </summary>
    public partial class AddConditionOnPatient : Form
    {
        DBBackEnd dbb;
        Patients PatientInfo;
        public AddConditionOnPatient(int PatientID)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            dbb = new DBBackEnd();

            PatientInfo = dbb.PatientRecord(PatientID);

            RefreshConditionsList();
        }

        void RefreshConditionsList()
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

        void Cancel_ButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void AddCondition_ButtonClick(object sender, EventArgs e)
        {
            Dialogs.AddCondition ac1 = new AddCondition();
            ac1.ShowDialog();

            if (ac1.DialogResult == DialogResult.OK) //TODO: DIALOGRESULT FOR ALL, NOT FAFFING ABOUT WITH LOCAL VARS FROM RETURNED RESULTS
            {
                RefreshConditionsList();
                string condition = dbb.GetConditionName(ac1.SelectedCondition);
                condition_List.SelectedIndex = condition_List.Items.IndexOf(condition);
            }
        }

        void OK_ButtonClick(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (condition_List.SelectedIndex == -1)
            {
                errorProvider1.SetError(condition_List, "No record has been selected");
                return;
            }
            dbb.AttachCondition(PatientInfo.PatientID, dbb.ConditionID(condition_List.SelectedItem.ToString()));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
