/*
 * Created by SharpDevelop.
 * User: pry09099729
 * Date: 03/03/2011
 * Time: 10:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
			comboBox1.Items.Clear();
			var PatientConditionsList = PatientInfo.PatientConditions;
			List<string> CndList = new List<string>();
			foreach (var cnd in PatientConditionsList) {
				CndList.Add(cnd.Conditions.Condition);
			}
			foreach (string Condition in dbb.ConditionsList) {
				bool found = false;
				foreach (string Cnd in CndList) {
					if (Cnd == Condition) {
						found = true;
					}
				}
				if (!found) {
					comboBox1.Items.Add(Condition);
				}
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Dialogs.AddCondition ac1 = new AddCondition();
			ac1.ShowDialog();
			
			if (ac1.DialogResult == DialogResult.OK)
			{
				RefreshConditionsList();
				string condition = dbb.GetConditionName(ac1.SelectedCondition);
				var index = comboBox1.Items.IndexOf(condition);
				comboBox1.SelectedIndex = index;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if (comboBox1.SelectedIndex == -1)
			{
				errorProvider1.SetError(comboBox1,"No record has been selected");
			}
			dbb.AttachCondition(PatientInfo.PatientID.Value, dbb.ConditionID(comboBox1.SelectedItem.ToString()));
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
