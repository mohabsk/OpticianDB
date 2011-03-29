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
using OpticianDB.Adaptor;
using OpticianDB.Extensions;

namespace OpticianDB.Forms.Dialogs
{
	public partial class EditAppointment : Form
	{
		DBBackEnd dbb;
		int appointmentId;
		public EditAppointment(int appointmentId)
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			dbb = new DBBackEnd();
			foreach(string user in dbb.UserNameList)
			{
				optician_ComboBox.Items.Add(user);
			}
			this.appointmentId = appointmentId;
			PatientAppointments ap1 = dbb.GetAppointmentById(appointmentId);
			start_DateTime.Value = ap1.StartDateTime;
			end_DateTime.Value = ap1.EndDateTime;
			remarks_Text.Text = ap1.Remarks;
			optician_ComboBox.SelectedItem = ap1.Users.Username;
		}
		
		void Delete_ButtonClick(object sender, EventArgs e)
		{
			dbb.DeleteAppointment(appointmentId);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void Save_ButtonClick(object sender, EventArgs e)
		{
			if(!CanSave())
				return;
			
			int userId = dbb.GetUserInfo(optician_ComboBox.SelectedItem.ToString()).UserID;
			dbb.AmendAppointment(appointmentId,start_DateTime.Value, end_DateTime.Value, remarks_Text.Text, userId);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		bool CanSave()
		{
			bool errors = false;
			if (start_DateTime.Value.InPast())
			{
				errorProvider.SetError(start_DateTime, "Start date cannot be in the past");
				errors = true;
			}
			if (end_DateTime.Value.Ticks < start_DateTime.Value.Ticks)
			{
				errorProvider.SetError(end_DateTime, "End date cannot be before the start date");
				errors = true;
			}
			
			return !errors;
		}
	}
}
