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
using System.Windows.Forms;
using System.Drawing;
using OpticianDB.Forms.Dialogs;

namespace OpticianDB.Forms
{
    /// <summary>
    /// The main form of the project, provides access to every other form
    /// </summary>
    public partial class MainGui : Form //TODO: NOTIFICATIONS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainGui"/> class.
        /// </summary>
        public MainGui()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        /// <summary>
        /// Handles the Click event of the UserEditorToolStripMenuItem control. Launches a new <see cref="UserEditor"/> form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void UserEditorToolStripMenuItemClick(object sender, EventArgs e)
        {
            Forms.UserEditor ue1 = new Forms.UserEditor();
            ue1.Show();
        }

        /// <summary>
        /// Handles the Click event of the NewPatientToolStripMenuItem control. Launches a new <see cref="Dialogs.NewPatient"/> dialog.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void NewPatientToolStripMenuItemClick(object sender, EventArgs e)
        {
            Dialogs.NewPatient np1 = new Dialogs.NewPatient();
            np1.Show(); //TODO: ShowDialog
        }

        /// <summary>
        /// Handles the Click event of the ConditionsManagerToolStripMenuItem control. Launches a new <see cref="Conditions"/> form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void ConditionsManagerToolStripMenuItemClick(object sender, EventArgs e)
        {
            Conditions cn1 = new Conditions();
            cn1.Show();
        }

        /// <summary>
        /// Handles the Click event of the PatientListToolStripMenuItem control. Launches a new <see cref="PatientList"/> dialog, if the patient list form selects for a patient to be loaded then that patient is loaded into a new <see cref="PatientInfo"/> form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void PatientListToolStripMenuItemClick(object sender, EventArgs e)
        {
            PatientList ul1 = new PatientList();
            ul1.ShowDialog();
            PatientInfo pi1 = ul1.SelectedPatient;
            if (pi1 != null)
            {
                pi1.Show();
            }
        }

        /// <summary>
        /// Handles the Click event of the RecallsToolStripMenuItem control. Launches a new <see cref="Recalls"/> form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void RecallsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Recalls rc1 = new Recalls();
            rc1.Show();
        }

        /// <summary>
        /// Handles the Click event of the AppointmentsToolStripMenuItem control. Launches a new <see cref="Appointments"/> form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AppointmentsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Appointments ac1 = new Appointments();
            ac1.Show();
        }

        /// <summary>
        /// Handles the Click event of the StoredEmailsToolStripMenuItem control. Launches a new <see cref="Emails"/> form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void StoredEmailsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Emails em1 = new Emails();
            em1.Show();
        }

        /// <summary>
        /// Handles the Click event of the AboutToolStripMenuItem control. Launches a new <see cref="AboutBox"/>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab1 = new AboutBox();
            ab1.Show();
        }
    }
}