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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpticianDB.Adaptor;

namespace OpticianDB.Forms
{
	public partial class PatientInfo : Form
	{
		DBBackEnd dbb;
		Patients rec;
        int grecid;

		public PatientInfo(int recid)
		{
			InitializeComponent();
			dbb = new DBBackEnd();
            grecid = recid;
            Reload_Record();
			label6.Text = rec.Name;
			textBox1.Text = rec.Address;
			textBox2.Text = rec.TelNum;
			dateTimePicker1.Value = rec.DateOfBirth.Value;
			textBox4.Text = rec.NhsnUmber;
			textBox5.Text = rec.Email;

			RefreshConditions();
		}

        private void Reload_Record()
        {
            dbb.Dispose();
            dbb = new DBBackEnd();
            rec = dbb.PatientRecord(grecid);
        }

		void RefreshConditions()
		{
			listBox1.Items.Clear();
			foreach (PatientConditions condition in rec.PatientConditions)
			{
				listBox1.Items.Add(condition.Conditions.Condition);
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Dialogs.AddConditionOnPatient acop1 = new Dialogs.AddConditionOnPatient(grecid);
			DialogResult dr = acop1.ShowDialog();
			
			if (dr == DialogResult.OK)
			{
                Reload_Record();
				RefreshConditions();
			}
		}
		
		void Amend_Click(object sender, EventArgs e)
		{
			//TODO: MEssagebox
            //TODO: Validation
			dbb.AmmendPatient(grecid, label6.Text, textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBox4.Text, textBox5.Text);
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}

        private void button3_Click(object sender, EventArgs e)
        {
            string selecteditem = listBox1.SelectedItem.ToString();
            if (MessageBox.Show("Do you want to remove the selected condition: " + selecteditem + "?",
                "Confirm action", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                dbb.RemoveConditionByName(selecteditem, grecid);
                Reload_Record();
                RefreshConditions();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button6_Click(object sender, EventArgs e)
        {
        	using(Dialogs.NewRecall nr1 = new Dialogs.NewRecall(grecid))
        	{
        		nr1.ShowDialog();
        	}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //TODO
        }
	}
}
