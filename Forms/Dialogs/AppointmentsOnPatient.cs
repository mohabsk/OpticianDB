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

namespace OpticianDB.Forms.Dialogs
{
	public partial class AppointmentsOnPatient : Form
	{
		DBBackEnd dbb;
		public int recId;
		public AppointmentsOnPatient(int patientId)
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			dbb = new DBBackEnd();
			foreach(PatientAppointments appointment in dbb.GetAppointmentsOnPatient(patientId))
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("#");
				sb.Append(appointment.AppointmentID);
				sb.Append(":");
				sb.Append(appointment.StartDateTime.Date.ToShortDateString());
				appointments_List.Items.Add(sb.ToString());
			}
		}
		
		void Appointments_ListSelectedIndexChanged(object sender, EventArgs e)
		{
			if (appointments_List.SelectedIndex == -1)
				return;
			string itemStr = appointments_List.SelectedItem.ToString();
			string numStr = itemStr.Remove(0,1).Split(new string[] {":"},StringSplitOptions.None)[0];
			recId = int.Parse(numStr);
			
			PatientAppointments pa1 = dbb.GetAppointmentById(recId);
			
			startDate_Text.Text = pa1.StartDateTime.ToString();
			endDate_Text.Text = pa1.EndDateTime.ToString();
			remarks_Text.Text = pa1.Remarks;
			optician_Text.Text = pa1.Users.Username;
			
			load_Button.Enabled = true;
			edit_Button.Enabled = true;
		}
		
		void Load_ButtonClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void Edit_ButtonClick(object sender, EventArgs e)
		{
			using(EditAppointment ea1 = new EditAppointment(recId))
			{
				ea1.ShowDialog();
				if (ea1.DialogResult == DialogResult.OK)
				{
					this.DialogResult = DialogResult.Ignore;
					this.Close();
				}
			}
		}
	}
}
