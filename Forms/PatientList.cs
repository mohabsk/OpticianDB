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

namespace OpticianDB.Forms
{

    public partial class PatientList : Form
    {
        DBBackEnd dbb;
        public PatientInfo pi1;
        public PatientList()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            dbb = new DBBackEnd();
            foreach (string patient in dbb.PatientListWithNhsNumber)
            {
                Patient_List.Items.Add(patient);
            }
        }

        void Patient_ListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Patient_List.SelectedIndex == -1)
                return;

            conditions_List.Items.Clear();
            string varstr = Patient_List.SelectedItem.ToString();
            int nhsindex = varstr.IndexOf(" - ");
            string nhsnum = varstr.Substring(0, nhsindex);

            var patientid = dbb.PatientIdByNhsNumber(nhsnum);
            var patientRecord = dbb.PatientRecord(patientid);

            this.textBox1.Text = patientRecord.Name;
            this.textBox2.Text = patientRecord.NhsnUmber;
            this.textBox3.Text = patientRecord.Address;
            this.textBox4.Text = patientRecord.TelNum;
            this.textBox5.Text = patientRecord.Email;
            this.textBox7.Text = patientRecord.DateOfBirth.Value.ToString();
            this.textBox6.Text = ((Enums.RecallMethods)patientRecord.PreferredRecallMethod).ToString();

            //patientRecord.PatientConditions
            //dbb.PatientConditionList(patientRecord.PatientID.Value)
            foreach (var condition in patientRecord.PatientConditions)
            {
                conditions_List.Items.Add(condition.Conditions.Condition);
            }

            Load_Button.Enabled = true;
        }

        void Search_ButtonClick(object sender, EventArgs e)
        {
            //FIXME
            throw new NotImplementedException();
        }

        void Load_ButtonClick(object sender, EventArgs e)
        {
            string varstr = Patient_List.SelectedItem.ToString();
            int nhsindex = varstr.IndexOf(" - ");
            string nhsnum = varstr.Substring(0, nhsindex);

            var patientid = dbb.PatientIdByNhsNumber(nhsnum);

            pi1 = new PatientInfo(patientid);
            this.Close();

        }

    }
}
