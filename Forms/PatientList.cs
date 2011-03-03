/*
 * Created by SharpDevelop.
 * User: pry09099729
 * Date: 03/03/2011
 * Time: 10:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
			
			foreach(PatientConditions condition in patientRecord.PatientConditions)
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
