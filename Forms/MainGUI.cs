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

namespace OpticianDB.Forms
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
        }

        void UserEditorToolStripMenuItemClick(object sender, EventArgs e)
        {
            Forms.UserEditor ue1 = new Forms.UserEditor();
            ue1.Show();
        }

        void NewPatientToolStripMenuItemClick(object sender, EventArgs e)
        {
            Dialogs.NewPatient np1 = new Dialogs.NewPatient();
            np1.Show(); //TODO: ShowDialog
        }

        void ConditionsManagerToolStripMenuItemClick(object sender, EventArgs e)
        {
            Conditions cn1 = new Conditions();
            cn1.Show();
        }

        void PatientListToolStripMenuItemClick(object sender, EventArgs e)
        {
            PatientList ul1 = new PatientList();
            ul1.ShowDialog();
            PatientInfo pi1 = ul1.pi1;
            if (pi1 != null)
            {
                pi1.Show();
            }
        }

        private void RecallsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Recalls rc1 = new Recalls();
            rc1.Show();
        }

        private void AppointmentsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Appointments ac1 = new Appointments();
            ac1.Show();
        }

        private void OptionsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Options of1 = new Forms.Options();
            of1.ShowDialog();
        }

        void StoredEmailsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Emails em1 = new Emails();
            em1.Show();
        }
    }
}