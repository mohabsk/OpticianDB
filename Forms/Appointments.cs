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

namespace OpticianDB.Forms
{

    public partial class Appointments : Form
    {
        DBBackEnd dbb;
        List<Calendar.Appointment> apmts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Appointments"/> class.
        /// </summary>
        public Appointments()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = Program.oProg.dbb;
            foreach (string user in dbb.UserNameList)
            {
                optician_ComboBox.Items.Add(user);
            }
            optician_ComboBox.SelectedItem = Program.oProg.UserName;
            appointmentDate_DateTime.Value = DateTime.Today;
            RefreshAppointments();
            appointments_DayView.Invalidate();

        }

        private void RefreshAppointments()
        {
            appointments_DayView.StartDate = appointmentDate_DateTime.Value;
            apmts = new List<Calendar.Appointment>();
            foreach (PatientAppointments appointments in dbb.GetAppointmentsByDateAndUser(optician_ComboBox.SelectedItem.ToString(), appointmentDate_DateTime.Value))
            {
                Calendar.Appointment ca1 = new Calendar.Appointment();
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
        void Optician_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAppointments();
        }

        void AppointmentDate_DateTimeValueChanged(object sender, EventArgs e)
        {
            RefreshAppointments();
        }
        void RefreshCal(object sender, ResolveAppointmentsEventArgs args)
        {
            args.Appointments = apmts;
        }

        private void LoadAppointment_Button_Click(object sender, EventArgs e)
        {
            if (appointments_DayView.SelectedAppointment == null)
            {
                MessageBox.Show("No appointment was selected to be loaded", "Could not load appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dialogs.AppointmentInProgress ap1 = new Dialogs.AppointmentInProgress(GetSelectedAppointmentId());
            ap1.Show();
            this.Close();
        }

        private int GetSelectedAppointmentId()
        {
            string selectedAppointment = appointments_DayView.SelectedAppointment.Title;
            string selectedAppointmentIdString = selectedAppointment.Remove(0, 1).Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            return int.Parse(selectedAppointmentIdString);
        }

        private void EditAppointment_Button_Click(object sender, EventArgs e)
        {
            if (appointments_DayView.SelectedAppointment == null)
            {
                MessageBox.Show("No appointment was selected to be loaded", "Could not load appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dialogs.EditAppointment ea1 = new Dialogs.EditAppointment(GetSelectedAppointmentId());
            ea1.ShowDialog();
            appointments_DayView.Invalidate();
        }
    }
}

