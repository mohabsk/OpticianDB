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

namespace OpticianDB.Forms.Dialogs
{
    /// <summary>
    ///   A form used for adding a new condition to the database
    /// </summary>
    public partial class AddCondition : Form
    {
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
        private DBBackEnd dbb;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "AddCondition" /> class.
        /// </summary>
        public AddCondition()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();
        }

        /// <summary>
        ///   Gets or sets the condition ID that has just been added to the database
        /// </summary>
        /// <value>The selected condition ID.</value>
        public int SelectedCondition { get; set; }

        /// <summary>
        ///   Handles the Click event of the add_Button control. Checks to see if the field matches validation and the condition exists. otherwise adds the condition, makes a reference in the global variable and closes
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Add_ButtonClick(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(condition_Text.Text))
            {
                errorProvider1.SetError(condition_Text, "Field cannot be empty");
                return;
            }
            int result = dbb.AddCondition(condition_Text.Text);
            if (result == -1)
            {
                errorProvider1.SetError(condition_Text, "Condition already exists");
                return;
            }
            SelectedCondition = result;
            DialogResult = DialogResult.OK;
            Close();
        }


        /// <summary>
        ///   Handles the Click event of the Cancel_Button control. Closes the form
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void Cancel_ButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}