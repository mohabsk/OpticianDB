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
using System.Drawing;
using System.Windows.Forms;
using Calendar;
using OpticianDB.Adaptor;
using OpticianDB.Extensions;

namespace OpticianDB.Forms.Dialogs
{
	/// <summary>
	/// Description of NewAppointment.
	/// </summary>
	public partial class NewAppointment : Form
	{
		DBBackEnd dbb;
		List<Calendar.Appointment> apmts;
		int recid;
		public NewAppointment(int patientId)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			dbb = Program.oProg.dbb;
			recid = patientId;
			foreach(string user in dbb.UserNameList)
			{
				optician_ComboBox.Items.Add(user);
			}
			optician_ComboBox.SelectedItem = Program.oProg.UserName;
			appointmentDate_DateTime.Value = DateTime.Today;
			RefreshAppointments();
			appointments_DayView.Invalidate();
		}
		
		public NewAppointment(int patientId, DateTime selectedDate)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			dbb = Program.oProg.dbb;
			recid = patientId;
			foreach(string user in dbb.UserNameList)
			{
				optician_ComboBox.Items.Add(user);
			}
			optician_ComboBox.SelectedItem = Program.oProg.UserName;
			appointmentDate_DateTime.Value = selectedDate;
			RefreshAppointments();
			appointments_DayView.Invalidate();
		}
		
		void Optician_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshAppointments();
		}
		
		void AppointmentDate_DateTimeValueChanged(object sender, EventArgs e)
		{
			RefreshAppointments();
		}
		
		void RefreshAppointments()
		{
			appointments_DayView.StartDate = appointmentDate_DateTime.Value;
			apmts = new List<Calendar.Appointment>();
			foreach(PatientAppointments appointments in dbb.GetAppointmentsByDateAndUser(optician_ComboBox.SelectedItem.ToString(),appointmentDate_DateTime.Value))
			{
				Calendar.Appointment ca1 = new Calendar.Appointment();
				ca1.StartDate = appointments.StartDateTime;
				ca1.EndDate = appointments.EndDateTime;
				ca1.Title = appointments.Patients.Name;
				ca1.Locked = true;
				apmts.Add(ca1);
				//appointments.StartDateTime;
			}
			appointments_DayView.Invalidate();
			//appointments_DayView.Selection = null; //TODO: works?
		}
		
		void RefreshCal(object sender, ResolveAppointmentsEventArgs args)
		{
			args.Appointments = apmts;
		}
		
		void Confirm_ButtonClick(object sender, EventArgs e)
		{ //TODO: validate not in past //TODO: confirm if appointment intersects //TODO: edit apmt menu //TODO: is it actually selected
			errorProvider.Clear();
			if(appointmentDate_DateTime.Value.DateInPast())
			{
				errorProvider.SetError(appointmentDate_DateTime,"The selected date is in the past");
				return;
			}
			if(appointments_DayView.SelectionStart == appointments_DayView.SelectionEnd) //TODO: or past
			{
				errorProvider.SetError(appointments_DayView,"A time range must be specified for the appointment");
				return;
			}
			dbb.SaveAppointment(appointments_DayView.SelectionStart, appointments_DayView.SelectionEnd,optician_ComboBox.SelectedItem.ToString(),recid,remarks_Text.Text);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
	}
}
