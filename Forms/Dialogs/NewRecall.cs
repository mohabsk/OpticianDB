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
using System.Drawing;
using System.Windows.Forms;
using OpticianDB.Adaptor;
using OpticianDB.Extensions;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    /// Description of NewRecall.
    /// </summary>
    public partial class NewRecall : Form
    {
        DBBackEnd dbb;
        int patientId;
        Patients Patientrec;
        bool ammend = false;
        public NewRecall(int patientId)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            dbb = new DBBackEnd();
            this.patientId = patientId;
            Patientrec = dbb.PatientRecord(patientId);

        }

        void OKClick(object sender, EventArgs e)
        {
            bool errorstriggered = false;
            errorProvider1.Clear();
            if (dateTimePicker1.Value.InPast())
            {
                errorProvider1.SetError(dateTimePicker1, "Date and preferred time cannot be in the past");
                errorstriggered = true;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Reason cannot be empty");
                errorstriggered = true;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "No method of recall selected");
                errorstriggered = true;
            }
            if (!errorstriggered && !Validation.Patient.RecallMethod(comboBox1.SelectedItem.ToString(), Patientrec.Address, Patientrec.Email, Patientrec.TelNum))
            {
                errorProvider1.SetError(comboBox1, "Method of recall is invalid for the given patient");
                errorstriggered = true;
            }
            if (errorstriggered)
                return;
            if (ammend)
            {
                dbb.AmendRecall(patientId, dateTimePicker1.Value, textBox1.Text, (Enums.RecallMethods)comboBox1.SelectedIndex);
            }
            else
            {
                dbb.SaveRecall(patientId, dateTimePicker1.Value, textBox1.Text, (Enums.RecallMethods)comboBox1.SelectedIndex);
            }
            //TODO: messagebox confirmation
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        void CancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void NewRecallLoad(object sender, EventArgs e)
        {
            int postrec = -1;
            int phonerec = -1;
            int emailrec = -1;

            if (dbb.CanPatientBePosted(Patientrec))
            {
                postrec = comboBox1.Items.Add("Post");
            }
            if (dbb.CanPatientBePhoned(Patientrec))
            {
                phonerec = comboBox1.Items.Add("Phone");
            }
            if (dbb.CanPatientBeEmailed(Patientrec))
            {
                emailrec = comboBox1.Items.Add("Email");
            }
            Enums.RecallMethods prm = (Enums.RecallMethods)Patientrec.PreferredRecallMethod;
            if (prm == Enums.RecallMethods.Post)
            {
                comboBox1.SelectedIndex = postrec;
            }
            else if (prm == Enums.RecallMethods.Phone)
            {
                comboBox1.SelectedIndex = phonerec;
            }
            else
            {
                comboBox1.SelectedIndex = emailrec;
            }


            if (dbb.OutstandingRecall(patientId))
            {
                PatientRecalls pr1 = dbb.GetRecall(patientId);
                DialogResult dr = MessageBox.Show("An outstanding recall was found\nPress yes to load this or no to make a new recall", "Recall Found", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    ammend = true;
                    dateTimePicker1.Value = pr1.DateAndPrefTime.Value;
                    textBox1.Text = pr1.Reason;
                    Enums.RecallMethods prm2 = (Enums.RecallMethods)pr1.Method;
                    if (prm2 == Enums.RecallMethods.Post)
                    {
                        comboBox1.SelectedIndex = postrec;
                    }
                    else if (prm2 == Enums.RecallMethods.Phone)
                    {
                        comboBox1.SelectedIndex = phonerec;
                    }
                    else
                    {
                        comboBox1.SelectedIndex = emailrec;
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }
    }
}
