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

        void ToolStripMenuItem1Click(object sender, EventArgs e)
        {
            NewPatient np1 = new NewPatient();
            np1.Show();
        }

        void ConditionsManagerToolStripMenuItemClick(object sender, EventArgs e)
        {
            Conditions cn1 = new Conditions();
            cn1.Show();
        }

        void ToolStripMenuItem2Click(object sender, EventArgs e)
        {
            PatientList ul1 = new PatientList();
            ul1.ShowDialog();
            PatientInfo pi1 = ul1.pi1;
            if(pi1 != null)
            {
            	pi1.Show();
            }
        }

        private void recallsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Options of1 = new Forms.Options();
            of1.ShowDialog();
        }
    }
}