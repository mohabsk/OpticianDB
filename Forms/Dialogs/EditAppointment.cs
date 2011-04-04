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
using System.Windows.Forms;
using OpticianDB.Adaptor;
using OpticianDB.Extensions;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    /// A form for editing an appointment record
    /// </summary>
    public partial class EditAppointment : Form
    {
        /// <summary>
        ///   Holds the current in use Appointment ID
        /// </summary>
        private int appointmentId;

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "EditAppointment" /> class. Adds a list of usernames to the opticians screen and fills out the information boxes with fields from the patients record.
        /// </summary>
        /// <param name = "appointmentId">The appointment id.</param>
        public EditAppointment(int appointmentId)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();

            foreach (string user in dbb.UserNameList)
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

        /// <summary>
        ///   Handles the Click event of the Delete_Button control. Deletes the current appointment and closes the form.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Delete_ButtonClick(object sender, EventArgs e)
        {
            dbb.DeleteAppointment(appointmentId);
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///   Handles the Click event of the Save_Button control. Validates the form and if it is validated, the appointment is amended in the database and the dialog is closed.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Save_ButtonClick(object sender, EventArgs e)
        {
            if (!CanSave())
                return;

            int userId = dbb.GetUserInfo(optician_ComboBox.SelectedItem.ToString()).UserID;
            dbb.AmendAppointment(appointmentId, start_DateTime.Value, end_DateTime.Value, remarks_Text.Text, userId);
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///   Determines whether this instance can save by validating the fields in the form, if the fields cannot be validated then a message is displayed to the user informing them that they cannot save.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance can save; otherwise, <c>false</c>.
        /// </returns>
        private bool CanSave()
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