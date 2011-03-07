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
		public PatientList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			dbb = new DBBackEnd();
			foreach (string patient in dbb.PatientListWithNHSNum)
			{
				listBox1.Items.Add(patient);
			}
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex == -1)
				return;
			
			string varstr = listBox1.SelectedItem.ToString();
			int nhsindex = varstr.IndexOf(" - ");
			string nhsnum = varstr.Substring(0,nhsindex);
			
			var patientid = dbb.PatientIDByNHSNumber(nhsnum);
			var patientRecord = dbb.PatientRecord(patientid);
			
			this.textBox1.Text = patientRecord.Name;
			this.textBox2.Text = patientRecord.NhsnUmber;
			this.textBox3.Text = patientRecord.Address;
			this.textBox4.Text = patientRecord.TelNum;
			this.textBox5.Text = patientRecord.Email;
			dateTimePicker1.Value = patientRecord.DateOfBirth.Value;
			
			//patientRecord.PatientConditions.Load();
			foreach(var condition in patientRecord.PatientConditions)
			{
				listBox1.Items.Add(condition.Conditions.Condition);
			}
			
			button2.Enabled = true;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//FIXME
			throw new NotImplementedException();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string varstr = listBox1.SelectedItem.ToString();
			int nhsindex = varstr.IndexOf(" - ");
			string nhsnum = varstr.Substring(0,nhsindex);
			
			var patientid = dbb.PatientIDByNHSNumber(nhsnum);
			
			PatientInfo pi1 = new PatientInfo(patientid);
			pi1.Show(); //FIXME
			this.Close();
			pi1.Activate(); //FIXME
			
		}
	}
}
