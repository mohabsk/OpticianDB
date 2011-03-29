// 
//  Copyright (c) 2011 Geoffrey Prytherch
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy of  this
//  software and associated documentation files (the "Software"), to deal in the Software
//  without restriction, including without limitation the rights to use, copy, modify, merge,
//  publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
//  to whom the Software is furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in all copies or
//  substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//  INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
//  PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
//  FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
//  OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//  DEALINGS IN THE SOFTWARE.
//  
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Calendar;
using OpticianDB.Adaptor;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   Description of AppointmentsOnDate.
    /// </summary>
    public partial class AppointmentsOnDate : Form
    {
        private List<Appointment> _appointments;
        private DBBackEnd dbb;
        private DateTime dateTime;

        public AppointmentsOnDate(DateTime dateTime)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.dateTime = dateTime;
            dbb = new DBBackEnd();
            foreach (string user in dbb.UserNameList)
            {
                optician_ComboBox.Items.Add(user);
            }
            optician_ComboBox.SelectedItem = Program.OProg.UserName;
            RefreshAppointments();
        }

        private void RefreshAppointments()
        {
            _appointments = new List<Appointment>();
            foreach (
                PatientAppointments appointments in
                    dbb.GetAppointmentsByDateAndUser(optician_ComboBox.SelectedItem.ToString(), dateTime))
            {
                Appointment ca1 = new Appointment
                                      {
                                          StartDate = appointments.StartDateTime,
                                          EndDate = appointments.EndDateTime,
                                          Title = "#" + appointments.AppointmentID + "\n" + appointments.Patients.Name,
                                          Locked = true
                                      };
                _appointments.Add(ca1);
            }
            appointments_DayView.Invalidate();
        }

        private void Appointment_DayViewResolveAppointments(object sender, ResolveAppointmentsEventArgs args)
        {
            args.Appointments = _appointments;
        }

        private void optician_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAppointments();
        }
    }
}