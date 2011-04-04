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
using OpticianDB.Forms.Dialogs;

namespace OpticianDB.Forms
{
    //TODO: put information for editing and that in
    /// <summary>
    /// A form for managing conditions that can be held by the patient
    /// </summary>
    public partial class Conditions : Form
    {
        /// <summary>
        /// Holds a value that indicates whether the controls in the form are enabled or not
        /// </summary>
        private bool _formState;

        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        /// The record ID of the current open condition
        /// </summary>
        private int openCondition;

        /// <summary>
        /// Initializes a new instance of the <see cref="Conditions"/> class and refreshes the list of conditions.
        /// </summary>
        public Conditions()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();

            RefreshList();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the form is enabled for editing. If the value is set the editing fields of the form are enabled or disabled as per value
        /// </summary>
        /// <value><c>true</c> if the form is enabled for editing; otherwise, <c>false</c>.</value>
        private bool FormState
        {
            get { return _formState; }
            set
            {
                _formState = value;
                viewPatients_Button.Enabled = value;
                condition_Text.Enabled = value;
                save_Button.Enabled = value;
                delete_Button.Enabled = value;
                if (!value)
                {
                    condition_Text.Text = "";
                }
            }
        }

        /// <summary>
        /// Refreshes the list of conditions from the database
        /// </summary>
        private void RefreshList()
        {
            conditions_List.Items.Clear();
            foreach (string Condition in dbb.ConditionsList)
            {
                conditions_List.Items.Add(Condition);
            }
        }

        /// <summary>
        /// Handles the Click event of the NewCnd_Button control. Calls a new <see cref="Dialogs.AddCondition"/> dialog to add a condition to the database. If a condition has been added the list of conditions is refreshed
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void newCnd_ButtonClick(object sender, EventArgs e)
        {
            using (AddCondition ac1 = new AddCondition())
            {
                DialogResult AddConditionResult = ac1.ShowDialog();
                if (AddConditionResult == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Conditions_List control. The record id of the selected condition is found, the item is loaded into the form and the editing buttons are enabled
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Conditions_ListSelectedIndexChanged(object sender, EventArgs e) //TODO: ASK IF SAVE IS NEEDED FIXME
        {
            if (conditions_List.SelectedIndex == -1)
                return;
            condition_Text.Text = conditions_List.SelectedItem.ToString();
            openCondition = dbb.ConditionId(conditions_List.SelectedItem.ToString());
            FormState = true;
        }

        /// <summary>
        /// Handles the Click event of the Save_Button control. Checks to see if a condition already exists with the given name and if it does the adding fails with an error, else ammends the condition, refreshes the list and disables editing
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Save_ButtonClick(object sender, EventArgs e)
        {
            if (dbb.ConditionExists(condition_Text.Text))
            {
                errorProvider.SetError(condition_Text, "A condition already exists with this name");
                return;
            }

            dbb.AmendCondition(openCondition, condition_Text.Text);
            RefreshList();
            FormState = false;
        }

        /// <summary>
        /// Handles the Click event of the Delete_Button control. Deletes the selected condition from the database, refreshes the conditions list and disables editing.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Delete_ButtonClick(object sender, EventArgs e)
        {
            dbb.DeleteCondition(openCondition);
            RefreshList();
            FormState = false;
        }

    }
}