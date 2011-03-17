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
using System.Text;
using System.Linq;
using OpticianDB.Adaptor;

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
            listBox1.Items.Clear();
            IQueryable<PatientRecalls> items;
            if (!startDate_Checkbox.Checked && !endDate_CheckBox.Checked)
            {
                items = dbb.RecallList;
            }

            else if (!startDate_Checkbox.Checked && endDate_CheckBox.Checked)
            {
                items = dbb.GetRecalls(null, endDate_DateTime.Value);
            }

            else if (!startDate_Checkbox.Checked && endDate_CheckBox.Checked)
            {
                items = dbb.GetRecalls(startDate_DateTime.Value, null);
            }

            else
            {
                items = dbb.GetRecalls(startDate_DateTime.Value, endDate_DateTime.Value);
            }

            foreach (var item in items)
            {
                StringBuilder sb1 = new StringBuilder();
                sb1.Append(item.RecallID.ToString());
                sb1.Append("-");
                sb1.Append(item.DateAndPrefTime.Value.ToShortTimeString());
                sb1.Append(" ");
                sb1.Append(item.DateAndPrefTime.Value.Day.ToString());
                sb1.Append("/");
                sb1.Append(item.DateAndPrefTime.Value.Month.ToString());
                listBox1.Items.Add(sb1.ToString());
            }
        }

        void CheckBox1CheckedChanged(object sender, EventArgs e)
        {

            LoadRecalls();
            if (startDate_Checkbox.Checked)
            {
                startDate_DateTime.Value = DateTime.Today;
                startDate_DateTime.Enabled = true;
            }
            else
            {
                startDate_DateTime.Enabled = false; //TODO: MindateMaxDate
                startDate_DateTime.Value = DateTime.Today;

            }
            //LoadRecalls();
        }

        void CheckBox2CheckedChanged(object sender, EventArgs e)
        {
            LoadRecalls(); //TODO: MindateMaxdate
            if (endDate_CheckBox.Checked)
            {
                endDate_DateTime.Enabled = true;
            }
            else
            {
                endDate_DateTime.Enabled = false;

            }
            //LoadRecalls();
        }

        void DateTimePickerValueChanged(object sender, EventArgs e)
        {
            //TODO: MindateMaxdate
            LoadRecalls();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;

            string selecteditemstr = listBox1.SelectedItem.ToString();
            int indexof = selecteditemstr.IndexOf("-");
            int selectedindex = int.Parse(selecteditemstr.Substring(0, indexof));

            this.loadedrecall = selectedindex;

            PatientRecalls rcl = dbb.GetRecallByRclId(selectedindex);

            textBox1.Text = rcl.Patients.Name;
            textBox2.Text = ((Enums.RecallMethods)rcl.Method).ToString();
            textBox3.Text = rcl.Reason;
            textBox4.Text = rcl.DateAndPrefTime.Value.ToString();

            button1.Enabled = true;

        }
    }
}
