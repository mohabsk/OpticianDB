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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpticianDB
{
	//TODO: sql eye test dates and times
	//TODO: http://www.datadictionary.nhs.uk/version2/data_dictionary/data_field_notes/n/nhs_number_de.asp?shownav=0
	//TODO: use this.MainForm;
	public class OpticianProg : ApplicationContext
	{
		Forms.MainGui mgui;
		/// <summary>
		/// Initializes a new instance of the <see cref="OpticianProg"/> class.
		/// </summary>
		public OpticianProg() //FIXME
		{
			if (Authenticate())
			{
				mgui = new Forms.MainGui();
				this.MainForm = mgui;
				mgui.Show();
			} else
			{
				Environment.Exit(0);
			}
		}
		
		public bool Authenticate()
		{
			DialogResult LoginResult;
			string LoggedInUsername;
			using (Forms.LogOnForm LoginForm = new Forms.LogOnForm())
			{
				LoginResult = LoginForm.ShowDialog();
				LoggedInUsername = LoginForm.UsernameTextBox.Text;
			}

			if (LoginResult == DialogResult.OK)
			{
				StaticStorage.UserName = LoggedInUsername;
				return true;
			}
			return false;
		}
	}
}
