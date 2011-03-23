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
using System.Text;
using System.Windows.Forms;

namespace OpticianDB.Forms
{

	public partial class Emails : Form
	{
		DBBackEnd dbb;
		int openRecID = -1;
		public Emails()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dbb = new DBBackEnd();
			RefreshList();

		}
		
		void RefreshList()
		{
			email_List.Items.Clear();
			foreach(string email in dbb.EmailList)
			{
				email_List.Items.Add(email);
			}
		}
		
		void Email_ListSelectedIndexChanged(object sender, EventArgs e)
		{
			if (email_List.SelectedIndex == -1)
				return;
			var erec = dbb.GetEmailRecord(email_List.SelectedItem.ToString());
			openRecID = erec.EmailID;
			name_Text.Text = erec.Name;
			email_Text.Text = erec.Value;
		}
		
		void Help_ButtonClick(object sender, EventArgs e)
		{
			StringBuilder sb1 = new StringBuilder();
			sb1.AppendLine("Constants for writing emails:");
			sb1.AppendLine();
			sb1.AppendLine("$NAME$ for the patients name");
			MessageBox.Show(sb1.ToString(),"Email Editor Help", MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void NewEmail_ButtonClick(object sender, EventArgs e) //TODO: Messsagebox
		{
			email_List.ClearSelected();
			openRecID = -1;
			email_Text.Text = string.Empty;
			name_Text.Text = string.Empty;
			
		}
		
		void Delete_ButtonClick(object sender, EventArgs e)
		{
			if(openRecID == -1)
			{
				MessageBox.Show("No database record open","Cannot Delete",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			dbb.DeleteEmailRecord(openRecID);
			openRecID = -1;
			email_Text.Text = string.Empty;
			name_Text.Text = string.Empty;
			email_List.ClearSelected();
			RefreshList();
			
		}
		
		void Save_ButtonClick(object sender, EventArgs e) //TODO: email.text is not empty
		{
			if(openRecID == -1)
			{
				bool saved = dbb.SaveEmailRecord(name_Text.Text, email_Text.Text);
				if (!saved)
				{
					MessageBox.Show("Record already exists with the specified name, Did not save","Cannot Save",MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				name_Text.Text = string.Empty;
				email_Text.Text = string.Empty;
			} else
			{
				bool saved = dbb.AmendEmailRecord(openRecID,name_Text.Text, email_Text.Text);
				if (!saved)
				{
					MessageBox.Show("Record already exists with the specified name, Did not save","Cannot Save",MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				name_Text.Text = string.Empty;
				email_Text.Text = string.Empty;
			}
			RefreshList();
		}
	}
}
