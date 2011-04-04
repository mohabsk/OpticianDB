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
using OpticianDB.Forms.Dialogs;

namespace OpticianDB.Forms
{
    /// <summary>
    ///   A form for working with appointments on a specified day
    /// </summary>
    public partial class Appointments : Form
    {
        /// <summary>
        ///   A list of appointment in use on the calendar view. Used in a global variable so the database is not queried every time the calendar is refreshed
        /// </summary>
        private List<Appointment> apmts;

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "Appointments" /> class. Adds usernames to the combo box, sets the user to the current user, sets the date to today and refreshes the calendar.
        /// </summary>
        public Appointments()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();

            foreach (string user in dbb.UserNameList)
            {
                optician_ComboBox.Items.Add(user);
            }
            optician_ComboBox.SelectedItem = Program.OProg.UserName;
            appointmentDate_DateTime.Value = DateTime.Today;

            RefreshAppointments();
            appointments_DayView.Invalidate();
        }

        /// <summary>
        ///   Refreshes the list of appointments for the selected date and user from the database by getting the list from the database and adding them to the global list, before triggering the calendar to refresh
        /// </summary>
        private void RefreshAppointments()
        {
            appointments_DayView.StartDate = appointmentDate_DateTime.Value;
            apmts = new List<Appointment>();
            foreach (
                PatientAppointments appointments in
                    dbb.GetAppointmentsByDateAndUser(optician_ComboBox.SelectedItem.ToString(),
                                                     appointmentDate_DateTime.Value))
            {
                Appointment ca1 = new Appointment();
                ca1.StartDate = appointments.StartDateTime;
                ca1.EndDate = appointments.EndDateTime;
                ca1.Title = "#" + appointments.AppointmentID + "\n" + appointments.Patients.Name;
                ca1.Locked = true;
                apmts.Add(ca1);
                //appointments.StartDateTime;
            }
            appointments_DayView.Invalidate();
            //appointments_DayView.Selection = null; //TODO: works?
        }

        /// <summary>
        ///   Handles the SelectedIndexChanged event of the Optician_ComboBox control. Refreshes the appointments calendar
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Optician_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAppointments();
        }

        /// <summary>
        ///   Handles the ValueChanged event of the AppointmentDate_DateTime control. Refreshes the appointments calendar
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AppointmentDate_DateTimeValueChanged(object sender, EventArgs e)
        {
            RefreshAppointments();
        }

        /// <summary>
        ///   Refreshes the calendar with the list of appointments from the global variable
        /// </summary>
        /// <param name = "sender">The sender.</param>
        /// <param name = "args">The <see cref = "Calendar.ResolveAppointmentsEventArgs" /> instance containing the event data.</param>
        private void RefreshCal(object sender, ResolveAppointmentsEventArgs args)
        {
            args.Appointments = apmts;
        }

        /// <summary>
        ///   Handles the Click event of the LoadAppointment_Button control. Loads the selected appointment into a <see cref = "OpticianDB.Forms.Dialogs.AppointmentInProgress" /> form and closes
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void LoadAppointment_Button_Click(object sender, EventArgs e)
        {
            if (appointments_DayView.SelectedAppointment == null)
            {
                MessageBox.Show("No appointment was selected to be loaded", "Could not load appointment",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AppointmentInProgress ap1 = new AppointmentInProgress(GetSelectedAppointmentId());
            ap1.Show();
            Close();
        }

        /// <summary>
        ///   Fetches the selected appointment ID from the selection in the calendar
        /// </summary>
        /// <returns>The selected appointment ID</returns>
        private int GetSelectedAppointmentId()
        {
            string selectedAppointment = appointments_DayView.SelectedAppointment.Title;
            string selectedAppointmentIdString =
                selectedAppointment.Remove(0, 1).Split(new string[] {"\n"}, StringSplitOptions.None)[0];
            return int.Parse(selectedAppointmentIdString);
        }

        /// <summary>
        ///   Handles the Click event of the EditAppointment_Button control. Fails if no appointment is selected but if one is it is loaded into a <see cref = "OpticianDB.Forms.Dialogs.EditAppointment" /> form and then the list is refreshed after the form closes
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void EditAppointment_Button_Click(object sender, EventArgs e)
        {
            if (appointments_DayView.SelectedAppointment == null)
            {
                MessageBox.Show("No appointment was selected to be loaded", "Could not load appointment",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (EditAppointment ea1 = new EditAppointment(GetSelectedAppointmentId()))
            {
                ea1.ShowDialog();
            }
            dbb.RefreshAdaptor();
            RefreshAppointments();
        }
    }
}