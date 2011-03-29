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
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpticianDB.Forms.Dialogs
{
	/// <summary>
	/// Description of EmailRecall.
	/// </summary>
	public partial class EmailRecall : Form
	{
		int recallId;
		string name;
		string email;
		string subject = "";
		DBBackEnd dbb;
		public EmailRecall(int recallId)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

			dbb = new DBBackEnd();
			this.recallId = recallId;
			var patientRec = dbb.GetRecallByRclId(recallId).Patients;
			name = patientRec.Name;
			email = patientRec.Email;
			foreach(var emailrec in dbb.EmailList)
			{
				template_ComboBox.Items.Add(emailrec);
			}
		}
		
		void Template_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			if (template_ComboBox.SelectedIndex == -1)
				return;
			var erec = dbb.GetEmailRecord(template_ComboBox.SelectedItem.ToString());
			email_Text.Text = erec.Value.Replace("$NAME$",name);
			subject = erec.Name; //TODO: change to subject
		}
		private void StartEmailClient()
		{
			StringBuilder fileName = new StringBuilder(); //TODO: open .eml file
			fileName.Append("mailto:");
			fileName.Append(email);
			fileName.Append("?subject=");
			fileName.Append(subject);
			fileName.Append("&body=");
			fileName.Append(email_Text.Text);
			Process myProcess = new Process();
			myProcess.StartInfo.FileName = fileName.ToString();
			myProcess.StartInfo.UseShellExecute = true;
			myProcess.StartInfo.RedirectStandardOutput = false;
			myProcess.Start();
		}

		
		void Send_ButtonClick(object sender, EventArgs e)
		{
			StartEmailClient();
			this.DialogResult = DialogResult.OK;
			this.Close();
			//todo: delete recall
		}
	}
}
