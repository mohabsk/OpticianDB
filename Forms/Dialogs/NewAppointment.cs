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
using System.Windows.Forms;
using Calendar;
using OpticianDB.Adaptor;
using OpticianDB.Extensions;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form for adding a new appointment record to a patient
    /// </summary>
    public partial class NewAppointment : Form
    {
        /// <summary>
        ///   A list of appointments rendered on the calendar. Stored in a global variable so there is not a performance impact when the calendar refreshes
        /// </summary>
        private List<Appointment> apmts;

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   The currently in use patient record ID.
        /// </summary>
        private int recid;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "NewAppointment" /> class. Sets global variables, Sets the form for today and reloads the calendar.
        /// </summary>
        /// <param name = "patientId">The patient id.</param>
        public NewAppointment(int patientId)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Program.OProg.FormIcon;
            dbb = new DBBackEnd();
            recid = patientId;

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
        ///   Initializes a new instance of the <see cref = "NewAppointment" /> class. Sets global variables, Sets the form for the selected date and reloads the calendar.
        /// </summary>
        /// <param name = "patientId">The patient id.</param>
        /// <param name = "selectedDate">The selected date.</param>
        public NewAppointment(int patientId, DateTime selectedDate)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            dbb = new DBBackEnd();
            recid = patientId;
            foreach (string user in dbb.UserNameList)
            {
                optician_ComboBox.Items.Add(user);
            }
            optician_ComboBox.SelectedItem = Program.OProg.UserName;
            appointmentDate_DateTime.Value = selectedDate;
            RefreshAppointments();
            appointments_DayView.Invalidate();
        }

        /// <summary>
        ///   Handles the SelectedIndexChanged event of the Optician_ComboBox control. Refreshes the appointments in the calendar
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Optician_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAppointments();
        }

        /// <summary>
        ///   Handles the ValueChanged event of the AppointmentDate_DateTime control. Refreshes the appointments in the calendar
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AppointmentDate_DateTimeValueChanged(object sender, EventArgs e)
        {
            RefreshAppointments();
        }

        /// <summary>
        ///   Refreshes the appointments in the calendar. Sets the start date for the appointments to the selected value in the combo box. Adds each appointment for the selected date and user to the list of appointments and refreshes the calendar control.
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
                ca1.Title = appointments.Patients.Name;
                ca1.Locked = true;
                apmts.Add(ca1);
                //appointments.StartDateTime;
            }
            appointments_DayView.Invalidate();
            //appointments_DayView.Selection = null; //TODO: works?
        }

        /// <summary>
        ///   Refreshes the calendar control with the global list of appointments
        /// </summary>
        /// <param name = "sender">The sender.</param>
        /// <param name = "args">The <see cref = "Calendar.ResolveAppointmentsEventArgs" /> instance containing the event data.</param>
        private void RefreshCal(object sender, ResolveAppointmentsEventArgs args)
        {
            args.Appointments = apmts;
        }

        /// <summary>
        ///   Handles the Click event of the Confirm_Button control. Validates each of the items to make sure they are not in the past and that a time range is actually selected before saving and closing. If any errors are found the user is informed and saving fails
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Confirm_ButtonClick(object sender, EventArgs e)
        {
            //TODO: confirm if appointment intersects //TODO: edit apmt menu //TODO: is it actually selected
            errorProvider.Clear();
            if (appointmentDate_DateTime.Value.DateInPast())
            {
                errorProvider.SetError(appointmentDate_DateTime, "The selected date is in the past");
                return;
            }
            if (appointments_DayView.SelectionStart.InPast())
            {
                errorProvider.SetError(appointments_DayView, "The selected time is in the past");
                return;
            }
            if (appointments_DayView.SelectionStart == appointments_DayView.SelectionEnd)
            {
                errorProvider.SetError(appointments_DayView, "A time range must be specified for the appointment");
                return;
            }
            dbb.SaveAppointment(appointments_DayView.SelectionStart, appointments_DayView.SelectionEnd,
                                optician_ComboBox.SelectedItem.ToString(), recid, remarks_Text.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}