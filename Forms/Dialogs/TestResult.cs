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
    /// A form used for reviewing and amending a test record
    /// </summary>
	public partial class TestResult : Form //TODO: date not in future
	{
        /// <summary>
        ///   The database backend class for the form, contains stored data manipulation procedures
        /// </summary>
		DBBackEnd dbb;
        /// <summary>
        /// The currently opened Patient Test record ID
        /// </summary>
		int recId;
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResult"/> class. Stores the record ID globally, gets the associated test record, puts the values into the form and fills the user lists with all possible usernames
        /// </summary>
        /// <param name="recId">The record id of the Patient Test Result record to be modified</param>
		public TestResult(int recId)
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			dbb = new DBBackEnd();
			this.recId = recId;
			
			PatientTestResults testResult = dbb.GetTestResult(recId);
			
			rSph_Text.Text = testResult.RSpH;
			lSph_Text.Text = testResult.LSpH;
			rVa1_Text.Text = testResult.RvA1;
			rVa2_Text.Text = testResult.RvA2;
			lVa1_Text.Text = testResult.LVA1;
			lVa2_Text.Text = testResult.LVA2;
			rCyl_Text.Text = testResult.RcYL;
			rAxis_Text.Text = testResult.RAxis;
			lCyl_Text.Text = testResult.LcYL;
			lAxis_Text.Text = testResult.LaxIs;
			remarks_Text.Text = testResult.Remarks;
			test_DateTime.Value = testResult.Date.Value;
			foreach(string user in dbb.UserNameList)
			{
				users_ComboBox.Items.Add(user);
			}
			users_ComboBox.SelectedItem = testResult.Users.Username;
		}
		
        /// <summary>
        /// Handles the Click event of the Save_Button control. Verifies that the selected record can be saved, gets the associated user id and saves the record, finally the form closes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		void Save_ButtonClick(object sender, EventArgs e)
		{
			if(!CanSave())
				return;
			int userId = dbb.GetUserInfo(users_ComboBox.SelectedItem.ToString()).UserID;
			dbb.AmendTestResults(userId,recId,test_DateTime.Value,rSph_Text.Text,lSph_Text.Text, rVa1_Text.Text, rVa2_Text.Text, lVa1_Text.Text, lVa2_Text.Text, rCyl_Text.Text, rAxis_Text.Text, lCyl_Text.Text, lAxis_Text.Text,remarks_Text.Text);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
        /// <summary>
        /// Handles the Click event of the Delete_Button control. Deletes the currently open record and closes the form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		void Delete_ButtonClick(object sender, EventArgs e)
		{
			dbb.DeleteTestResult(recId);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
        /// <summary>
        /// Verifies each field of the form, returning an error if the field does not match a datatype, or a range type check. If an error is found the save is halted and the user is informed
        /// </summary>
        /// <returns><c>true</c> if the form can be saved; Otherwise, <c>false</c></returns>
		private bool CanSave()
		{
			bool canSave = true;
			errorProvider.Clear();
			double tempDouble;
			int tempInt;

			if (string.IsNullOrEmpty(rSph_Text.Text) || !double.TryParse(rSph_Text.Text, out tempDouble))
			{
				errorProvider.SetError(rSph_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(lSph_Text.Text) || !double.TryParse(lSph_Text.Text, out tempDouble))
			{
				errorProvider.SetError(lSph_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(rVa1_Text.Text) || !int.TryParse(rVa1_Text.Text, out tempInt))
			{
				errorProvider.SetError(rVa1_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(rVa2_Text.Text) || !int.TryParse(rVa2_Text.Text, out tempInt))
			{
				errorProvider.SetError(rVa2_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(lVa1_Text.Text) || !int.TryParse(lVa1_Text.Text, out tempInt))
			{
				errorProvider.SetError(lVa1_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(lVa2_Text.Text) || !int.TryParse(lVa2_Text.Text, out tempInt))
			{
				errorProvider.SetError(lVa2_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(rCyl_Text.Text) || !double.TryParse(rCyl_Text.Text, out tempDouble))
			{
				errorProvider.SetError(rCyl_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(rAxis_Text.Text) || !int.TryParse(rAxis_Text.Text, out tempInt))
			{
				errorProvider.SetError(rAxis_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(lCyl_Text.Text) || !double.TryParse(lCyl_Text.Text, out tempDouble))
			{
				errorProvider.SetError(lCyl_Text, "Value is incorrect");
				canSave = false;
			}

			if (string.IsNullOrEmpty(lAxis_Text.Text) || !int.TryParse(lAxis_Text.Text, out tempInt))
			{
				errorProvider.SetError(lAxis_Text, "Value is incorrect");
				canSave = false;
			}
			if (test_DateTime.Value.DateInFuture())
			{
				errorProvider.SetError(test_DateTime, "Date cannot be in the future");
				canSave = false;
			}

			if (!canSave)
			{
				return false;
			}

			if (int.Parse(rAxis_Text.Text) < 0 || int.Parse(rAxis_Text.Text) > 180)
			{
				errorProvider.SetError(rAxis_Text, "Axis can only be between 0 and 180");
				canSave = false;
			}

			if (int.Parse(lAxis_Text.Text) < 0 || int.Parse(lAxis_Text.Text) > 180)
			{
				errorProvider.SetError(lAxis_Text, "Axis can only be between 0 and 180");
				canSave = false;
			}

			return canSave;
		}
	}
}
