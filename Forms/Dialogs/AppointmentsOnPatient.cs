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
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpticianDB.Adaptor;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form that shows all the appointments currently assigned to a patient
    /// </summary>
    public partial class AppointmentsOnPatient : Form
    {
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Holds the currently selected appointment ID.
        /// </summary>
        public int recId;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "AppointmentsOnPatient" /> class. Gets the appointments on the selected patient ID and adds them to a list.
        /// </summary>
        /// <param name = "patientId">The patient id to open appointments for.</param>
        public AppointmentsOnPatient(int patientId)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();

            foreach (PatientAppointments appointment in dbb.GetAppointmentsOnPatient(patientId))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("#");
                sb.Append(appointment.AppointmentID);
                sb.Append(":");
                sb.Append(appointment.StartDateTime.Date.ToShortDateString());
                appointments_List.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        ///   Handles the SelectedIndexChanged event of the Appointments_List control. Parses the selected item to get the record ID, Loads the information into the side table and enables the buttons.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Appointments_ListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (appointments_List.SelectedIndex == -1)
                return;

            string itemStr = appointments_List.SelectedItem.ToString();
            string numStr = itemStr.Remove(0, 1).Split(new string[] {":"}, StringSplitOptions.None)[0];
            recId = int.Parse(numStr);

            PatientAppointments pa1 = dbb.GetAppointmentById(recId);

            startDate_Text.Text = pa1.StartDateTime.ToString();
            endDate_Text.Text = pa1.EndDateTime.ToString();
            remarks_Text.Text = pa1.Remarks;
            optician_Text.Text = pa1.Users.Username;

            load_Button.Enabled = true;
            edit_Button.Enabled = true;
        }

        /// <summary>
        ///   Handles the Click event of the Load_Button control. Passes back a signal to the calling form indicating for it to load the Appointment screen and closes.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Load_ButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///   Handles the Click event of the Edit_Button control. Calls the <see cref = "OpticianDB.Forms.Dialogs.EditAppointment" /> form and if it is edited it flags to the calling form to not call the appointment screen and closes itself.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Edit_ButtonClick(object sender, EventArgs e)
        {
            using (EditAppointment ea1 = new EditAppointment(recId))
            {
                ea1.ShowDialog();
                if (ea1.DialogResult == DialogResult.OK)
                {
                    DialogResult = DialogResult.Ignore;
                    Close();
                }
            }
        }
    }
}