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
		/// <summary>
		/// Initializes a new instance of the <see cref="OpticianProg"/> class.
		/// </summary>
		public OpticianProg()
		{
			if (Authenticate())
			{
				using (Forms.MainGui mgui = new Forms.MainGui())
				{
					mgui.ShowDialog();
				}
			}
			Environment.Exit(0);
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
