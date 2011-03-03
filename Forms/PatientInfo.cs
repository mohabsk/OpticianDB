using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpticianDB.Forms
{
	public partial class PatientInfo : Form
	{
		DBBackEnd dbb;
		Patients rec;
		public PatientInfo(int recid)
		{
			InitializeComponent();
			dbb = new DBBackEnd();
			rec = dbb.PatientRecord(recid);
			label6.Text = rec.Name;
			textBox1.Text = rec.Address;
			textBox2.Text = rec.TelNum;
			dateTimePicker1.Value = rec.DateOfBirth.Value;
			textBox4.Text = rec.NhsnUmber;
			textBox5.Text = rec.Email;

			RefreshConditions();
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
			Dialogs.AddConditionOnPatient acop1 = new Dialogs.AddConditionOnPatient(rec.PatientID.Value);
			DialogResult dr = acop1.ShowDialog();
			
			if (dr == DialogResult.OK)
			{
				RefreshConditions();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
