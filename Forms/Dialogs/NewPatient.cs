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
using OpticianDB.Extensions;
using OpticianDB.Validation;

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form used for creating a new patient record
    /// </summary>
    public partial class NewPatient : Form
    {
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "NewPatient" /> class. Also adds all the possible recall methods to the recall method box
        /// </summary>
        public NewPatient()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();
            foreach (string enumstr in Enum.GetNames(typeof (RecallMethods)))
            {
                recallMethod_ComboBox.Items.Add(enumstr);
            }
        }

        /// <summary>
        ///   Determines whether this instance can save by validating each item of the form with criteria, Returning errors if a criteria fails to be validated.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance can save; otherwise, <c>false</c>.
        /// </returns>
        private bool CanSave()
        {
            bool errors = false;
            errorProvider.Clear();
            if (!Patient.Name(name_Text.Text))
            {
                errors = true;
                errorProvider.SetError(name_Text,
                                       "Name could not be validated\nDid you include the last name?\nDid you capitalise each part of the name?");
            }
            if (!Patient.TelNum(telephone_Text.Text))
            {
                errors = true;
                errorProvider.SetError(telephone_Text,
                                       "Telephone number could not be validated\nDid you include the area code?\nDid you prefix any international numbers with +?");
            }
            if (dateOfBirth_DateTimePicker.Value.InFuture())
            {
                errors = true;
                errorProvider.SetError(dateOfBirth_DateTimePicker,
                                       "Date of birth could not be validated\nAre you trying to add a date in the future?");
            }
            if (!Patient.NhsNumber(nhsNumber_Text.Text))
            {
                errors = true;
                errorProvider.SetError(nhsNumber_Text, "NHS number could not be validated");
            }
            if (!Patient.Email(email_Text.Text))
            {
                errors = true;
                errorProvider.SetError(email_Text, "Email could not be validated");
            }
            if (recallMethod_ComboBox.SelectedIndex == -1)
            {
                errors = true;
                errorProvider.SetError(recallMethod_ComboBox, "No preferred recall method selected");
            }
            if (!errors &&
                !Patient.RecallMethod(recallMethod_ComboBox.Text, address_Text.Text, email_Text.Text,
                                      telephone_Text.Text))
            {
                errors = true;
                errorProvider.SetError(recallMethod_ComboBox,
                                       "Recall method is invalid\nYou could be trying to select a recall method where no value has been entered to recall");
            }
            return !errors;
        }

        /// <summary>
        ///   Adds the patient to the database. First all extra charaters are removed, the form is validated. The record is saved and if the save is successful then a new <see cref = "OpticianDB.Forms.PatientInfo" /> form is opened with the data. If the saving fails another record exists with the same data and the user is informed
        /// </summary>
        /// <param name = "sender">The sender.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AddPatient(object sender, EventArgs e)
        {
            telephone_Text.Text = telephone_Text.Text.Replace(" ", "");
            telephone_Text.Text = telephone_Text.Text.Replace("-", "");
            nhsNumber_Text.Text = nhsNumber_Text.Text.Replace(" ", "");
            nhsNumber_Text.Text = nhsNumber_Text.Text.Replace("-", "");
            if (!CanSave())
            {
                return;
            }
            int result = dbb.AddPatient(name_Text.Text, address_Text.Text, telephone_Text.Text,
                                        dateOfBirth_DateTimePicker.Value, nhsNumber_Text.Text, email_Text.Text,
                                        (RecallMethods)
                                        Enum.Parse(typeof (RecallMethods), recallMethod_ComboBox.SelectedItem.ToString()));
            if (result == -1)
            {
                MessageBox.Show("Record already exists", "Record Addition Failed", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                PatientInfo pi = new PatientInfo(result);
                pi.Show();
                pi.Focus();
                Close();
            }
        }


        /// <summary>
        ///   Adds the patient to the database by validating the fields, saving the record. Informing the user if the save failed or clearing the form for another record entry if the save was successful
        /// </summary>
        /// <param name = "sender">The sender.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AddAndContinue(object sender, EventArgs e)
        {
            if (!CanSave())
            {
                return;
            }
            int result = dbb.AddPatient(name_Text.Text, address_Text.Text, telephone_Text.Text,
                                        dateOfBirth_DateTimePicker.Value, nhsNumber_Text.Text, email_Text.Text,
                                        (RecallMethods)
                                        Enum.Parse(typeof (RecallMethods), recallMethod_ComboBox.SelectedItem.ToString()));
            if (result == -1)
            {
                MessageBox.Show("Record already exists", "Record Addition Failed", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                name_Text.Text = "";
                address_Text.Text = "";
                telephone_Text.Text = "";
                dateOfBirth_DateTimePicker.Value = new DateTime(1980, 1, 1);
                nhsNumber_Text.Text = "";
                email_Text.Text = "";
                recallMethod_ComboBox.SelectedIndex = -1;
                name_Text.Select();
                AcceptButton = addContinue_Button;
            }
        }
    }
}