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
    /// <summary>
    /// Description of Recalls.
    /// </summary>
    public partial class Recalls : Form
    {
        DBBackEnd dbb;
        public Recalls()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            dbb = new DBBackEnd();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
            LoadRecalls();


        }

        void RecallsLoad(object sender, EventArgs e)
        {

        }

        void Button1Click(object sender, EventArgs e)
        {

        }

        void LoadRecalls()
        {
            listBox1.Items.Clear();
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                var items = dbb.RecallList;
                foreach (var item in items)
                {
                    listBox1.Items.Add(item); //FIXME: not tostr
                }
            }
            else if (checkBox1.Checked && !checkBox2.Checked)
            {
                var rcls = dbb.GetRecalls(null, dateTimePicker2.Value);
                foreach (var item in rcls)
                {
                    listBox1.Items.Add(item); //FIXME: not tostr
                }
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                var rcls = dbb.GetRecalls(dateTimePicker1.Value, null);
                foreach (var item in rcls)
                {
                    listBox1.Items.Add(item); //FIXME: not tostr
                }
            }
            else
            {
                var rcls = dbb.GetRecalls(dateTimePicker1.Value, dateTimePicker2.Value);
                foreach (var item in rcls)
                {
                    listBox1.Items.Add(item); //FIXME: not tostr
                }
            }
        }

        void CheckBox1CheckedChanged(object sender, EventArgs e)
        {

            LoadRecalls();
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                try
                {
                    dateTimePicker1.Value = DateTime.Today;
                }
                catch (ArgumentOutOfRangeException)
                { //FIXME:
                    dateTimePicker1.MaxDate = DateTime.Today;
                    dateTimePicker2.MinDate = DateTime.Today;
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                }

            }
            //LoadRecalls();
        }

        void CheckBox2CheckedChanged(object sender, EventArgs e)
        {
            LoadRecalls();
            if (checkBox2.Checked)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                try
                {
                    dateTimePicker2.Value = DateTime.Today;
                }
                catch (ArgumentOutOfRangeException)
                { //FIXME:
                    dateTimePicker1.MaxDate = DateTime.Today;
                    dateTimePicker2.MinDate = DateTime.Today;
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                }
            }
            //LoadRecalls();
        }

        void DateTimePickerValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = dateTimePicker2.Value;
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            LoadRecalls();
        }
    }
}
