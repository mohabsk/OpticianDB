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

namespace OpticianDB.Forms
{
	//TODO: put information for editing and that in
	public partial class Conditions : Form
	{
		DBBackEnd dbb;
		int openCondition;
		public Conditions()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			dbb = new DBBackEnd();

			RefreshList();
		}

		void RefreshList()
		{
			conditions_List.ClearSelected();
			conditions_List.Items.Clear();
			foreach (string Condition in dbb.ConditionsList)
			{
				conditions_List.Items.Add(Condition);
			}
		}


		void newCnd_ButtonClick(object sender, EventArgs e)
		{
			using (Dialogs.AddCondition ac1 = new Dialogs.AddCondition())
			{
				DialogResult AddConditionResult = ac1.ShowDialog();
				if (AddConditionResult == DialogResult.OK)
				{
					RefreshList();
				}
			}
		}

		void Conditions_ListSelectedIndexChanged(object sender, EventArgs e) //TODO: ASK IF SAVE IS NEEDED FIXME
		{
			if (conditions_List.SelectedIndex == -1)
				return;
			condition_Text.Text = conditions_List.SelectedItem.ToString();
			openCondition = dbb.ConditionId(conditions_List.SelectedItem.ToString());
			FormState = true;
		}
		
		void Save_ButtonClick(object sender, EventArgs e)
		{
			if (dbb.ConditionExists(condition_Text.Text))
			{
				errorProvider.SetError(condition_Text,"A condition already exists with this name");
				return;
			}
			
			dbb.AmendCondition(openCondition, condition_Text.Text);
			RefreshList();
			FormState = false;
		}
		
		
		void Delete_ButtonClick(object sender, EventArgs e)
		{
			dbb.DeleteCondition(openCondition);
			RefreshList();
			FormState = false;
		}
		
		void ViewPatients_ButtonClick(object sender, EventArgs e)
		{
			
		}
		bool _formState;
		bool FormState
		{
			get{ return _formState; }
			set
			{
				_formState = value;
				viewPatients_Button.Enabled = value;
				condition_Text.Enabled = value;
				save_Button.Enabled = value;
				delete_Button.Enabled = value;
				if(!value)
				{
				condition_Text.Text = "";
				}
			}
		}
	}
}
