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
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpticianDB.Adaptor;
using OpticianDB.Forms.Dialogs;

namespace OpticianDB.Forms
{

    public partial class Recalls : Form
    {
        DBBackEnd dbb;
        int loadedrecall;
        public Recalls()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            dbb = new DBBackEnd();
            startDate_DateTime.Value = DateTime.Today;
            endDate_DateTime.Value = DateTime.Today;
            LoadRecalls();


        }

        void LoadRecalls()
        {
            recalls_List.Items.Clear();
            IQueryable<PatientRecalls> items;
            if (!startDate_CheckBox.Checked && !endDate_CheckBox.Checked)
            {
                items = dbb.RecallList;
            }

            else if (!startDate_CheckBox.Checked && endDate_CheckBox.Checked)
            {
                items = dbb.GetRecalls(null, endDate_DateTime.Value);
            }

            else if (startDate_CheckBox.Checked && !endDate_CheckBox.Checked)
            {
                items = dbb.GetRecalls(startDate_DateTime.Value, null);
            }

            else
            {
                items = dbb.GetRecalls(startDate_DateTime.Value, endDate_DateTime.Value);
            }

            foreach (PatientRecalls item in items)
            {
                StringBuilder sb1 = new StringBuilder();
                sb1.Append(item.RecallID.ToString());
                sb1.Append("-");
                sb1.Append(item.DateAndPrefTime.Value.ToShortTimeString());
                sb1.Append(" ");
                sb1.Append(item.DateAndPrefTime.Value.Day.ToString());
                sb1.Append("/");
                sb1.Append(item.DateAndPrefTime.Value.Month.ToString());
                recalls_List.Items.Add(sb1.ToString());
            }
        }

        void StartDate_CheckBoxCheckedChanged(object sender, EventArgs e)
        {

            LoadRecalls();
            startDate_DateTime.Value = DateTime.Today; //TODO: MindateMaxDate
            startDate_DateTime.Enabled = startDate_CheckBox.Checked;

            //LoadRecalls();
        }

        void EndDate_CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            LoadRecalls(); //TODO: MindateMaxdate
            endDate_DateTime.Value = DateTime.Today;
            endDate_DateTime.Enabled = endDate_CheckBox.Checked;

            //LoadRecalls();
        }

        void DateTimePickerValueChanged(object sender, EventArgs e)
        {
            //TODO: MindateMaxdate
            LoadRecalls();
        }

        private void Recalls_ListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (recalls_List.SelectedIndex == -1)
                return;

            string selecteditemstr = recalls_List.SelectedItem.ToString();
            this.loadedrecall = int.Parse(selecteditemstr.Substring(0, selecteditemstr.IndexOf("-")));

            PatientRecalls rcl = dbb.GetRecallByRclId(loadedrecall);

            name_Text.Text = rcl.Patients.Name;
            method_Text.Text = ((Enums.RecallMethods)rcl.Method).ToString();
            reason_Text.Text = rcl.Reason;
            datePrefTime_Text.Text = rcl.DateAndPrefTime.Value.ToString();

            load_Button.Enabled = true;

        }

        void ClearRecalls()
        {
            name_Text.Text = "";
            method_Text.Text = "";
            reason_Text.Text = "";
            datePrefTime_Text.Text = "";

            load_Button.Enabled = false;

            LoadRecalls();
        }

        void Load_ButtonClick(object sender, EventArgs e)
        {
            PatientRecalls rcl = dbb.GetRecallByRclId(loadedrecall);
            switch ((Enums.RecallMethods)rcl.Method)
            {
                case Enums.RecallMethods.Post:
                    using (PostRecall pr1 = new PostRecall(loadedrecall))
                    {
                        pr1.ShowDialog();
                    }
                    ClearRecalls();
                    break;
                case Enums.RecallMethods.Phone:
                    using (PhoneRecall pr1 = new PhoneRecall(loadedrecall))
                    {
                        pr1.ShowDialog();
                    }
                    ClearRecalls();
                    break;
                case Enums.RecallMethods.Email:
                    using (EmailRecall er1 = new EmailRecall(loadedrecall))
                    {
                        er1.ShowDialog();
                    }
                    ClearRecalls();
                    break;
            }
            //RefreshRecalls here
        }
    }
}
