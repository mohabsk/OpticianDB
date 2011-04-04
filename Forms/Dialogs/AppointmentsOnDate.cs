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
    ///   A form that shows all the appointments taking place on a specified date
    /// </summary>
    public partial class AppointmentsOnDate : Form
    {
        /// <summary>
        ///   Holds a list of all the appointments on the current day. The appointments are stored in a list as the calender is refreshed more times than the records are changed.
        /// </summary>
        private List<Appointment> appointments;

        /// <summary>
        ///   Holds the date and time that the appointments should be checked for
        /// </summary>
        private DateTime dateTime;

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "AppointmentsOnDate" /> class. Sets form variables, adds usernames to the list and performs a refresh of appointments.
        /// </summary>
        /// <param name = "dateTime">The date time.</param>
        public AppointmentsOnDate(DateTime dateTime)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();
            this.dateTime = dateTime;

            appointments_DayView.StartDate = dateTime.Date.AddHours(9);

            foreach (string user in dbb.UserNameList)
            {
                optician_ComboBox.Items.Add(user);
            }
            optician_ComboBox.SelectedItem = Program.OProg.UserName;

            RefreshAppointments();
        }

        /// <summary>
        ///   Refreshes the appointments for the current date and user by fetching the appointments, adding them to a global array of calendar appointments and refreshing the calendar control
        /// </summary>
        private void RefreshAppointments()
        {
            appointments = new List<Appointment>();
            foreach (
                PatientAppointments appointment in
                    dbb.GetAppointmentsByDateAndUser(optician_ComboBox.SelectedItem.ToString(), dateTime))
            {
                Appointment ca1 = new Appointment
                                      {
                                          StartDate = appointment.StartDateTime,
                                          EndDate = appointment.EndDateTime,
                                          Title = "#" + appointment.AppointmentID + "\n" + appointment.Patients.Name,
                                          Locked = true
                                      };
                appointments.Add(ca1);
            }
            appointments_DayView.Invalidate();
        }

        /// <summary>
        ///   Handles the ResolveAppointments event of the Appointment_DayView control. Assigns the global list of appointments
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "args">The <see cref = "Calendar.ResolveAppointmentsEventArgs" /> instance containing the event data.</param>
        private void Appointment_DayViewResolveAppointments(object sender, ResolveAppointmentsEventArgs args)
        {
            args.Appointments = appointments;
        }

        /// <summary>
        ///   Handles the SelectedIndexChanged event of the optician_ComboBox control. Refreshes the appointments list every time the combo box is changed
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void optician_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAppointments();
        }
    }
}