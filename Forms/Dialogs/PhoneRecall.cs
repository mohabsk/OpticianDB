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

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form for performing a recall to the patient via Phone
    /// </summary>
    public partial class PhoneRecall : Form
    {
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Holds the currently in use recall record
        /// </summary>
        private PatientRecalls rclrec;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "PhoneRecall" /> class. Gets the recall record and populates form fields with its values
        /// </summary>
        /// <param name = "RecallID">The recall ID.</param>
        public PhoneRecall(int RecallID)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();

            rclrec = dbb.GetRecallByRclId(RecallID);
            name_Label.Text = rclrec.Patients.Name;
            telNum_Label.Text = rclrec.Patients.TelNum;
            reason_Label.Text = rclrec.Reason;
            cal_Calendar.SelectionStart = DateTime.Today.Date;
        }

        /// <summary>
        ///   Handles the Click event of the Confirm_Button control. Starts a new <see cref = "OpticianDB.Forms.Dialogs.NewAppointment" /> form from the selected date. If an appointment is added, the recall is removed and the form closes
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Confirm_ButtonClick(object sender, EventArgs e)
        {
            using (NewAppointment na1 = new NewAppointment(rclrec.PatientID, cal_Calendar.SelectionStart))
            {
                na1.ShowDialog();
                if (na1.DialogResult == DialogResult.OK)
                {
                    dbb.DeleteRecall(rclrec.PatientID);
                    DialogResult = DialogResult.OK;
                    Close(); //remove recall
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the checkApmts_Button control. Starts a new <see cref = "OpticianDB.Forms.Dialogs.AppointmentsOnDate" /> form to show the user the appointments on the selected date
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void checkApmts_Button_Click(object sender, EventArgs e)
        {
            using (AppointmentsOnDate ad1 = new AppointmentsOnDate(cal_Calendar.SelectionStart))
            {
                ad1.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of the removeRecall_Button control. Removes the recall from the database and closes the form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void removeRecall_Button_Click(object sender, EventArgs e)
        {
            dbb.DeleteRecall(rclrec.PatientID);
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the noAnswer_Button control. Shifts the recall forward to tomorrow and closes the form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void noAnswer_Button_Click(object sender, EventArgs e)
        {
            dbb.ShiftRecall(rclrec.PatientID);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}