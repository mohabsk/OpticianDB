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

namespace OpticianDB.Forms
{
	public partial class NewPatient : Form
	{
		DBBackEnd dbb;
		public NewPatient()
		{
			InitializeComponent();
			dbb = new DBBackEnd();
		}
		bool cansave()
		{
			bool errors = false;
			errorProvider1.Clear();
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				errorProvider1.SetError(textBox1,"Value cannot be empty");
				errors = true;
			}
			if(string.IsNullOrEmpty(textBox2.Text))
			{
				errorProvider1.SetError(textBox2,"Value cannot be empty");
				errors = true;
			}
			if (string.IsNullOrEmpty(textBox5.Text))
			{
				errorProvider1.SetError(textBox5,"Value cannot be empty");
				errors = true;
			}
			if(errors)
				return false;
			return true;
		}
		void AddPatient(object sender, EventArgs e)
		{
			if (!cansave())
			{
				return;
			}
			int result = dbb.AddPatient(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, textBox5.Text, textBox6.Text);
			if (result == -1)
			{
				MessageBox.Show("Record already exists","Record Addition Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
			} else
			{
				PatientInfo pi = new PatientInfo(result);
				pi.Show();
				pi.Focus(); //FIXME
				this.Close();
			}
		}
		
		
		void AddAndContinue(object sender, EventArgs e)
		{
			
		}
	}
}
