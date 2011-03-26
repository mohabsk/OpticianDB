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

namespace OpticianDB
{
	using System;
	using System.Windows.Forms;
	using System.IO;
	using System.Reflection;

	public class OpticianProg : ApplicationContext //TODO: global dbb
	{
		private string _userName;

		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		Forms.MainGui mgui;
		/// <summary>
		/// Initializes a new instance of the <see cref="OpticianProg"/> class.
		/// </summary>
		public OpticianProg() //FIXME
		{
			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AppDomain_CurrentDomain_AssemblyResolve);
			if (Authenticate())
			{
				mgui = new Forms.MainGui();
				this.MainForm = mgui;
				mgui.Show();
			}
			else
			{
				Environment.Exit(0);
			}
		}

		Assembly AppDomain_CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			String resourceName = "OpticianDB.Libraries." +
				new AssemblyName(args.Name).Name + ".dll";
			using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)) {
				Byte[] assemblyData = new Byte[stream.Length];
				stream.Read(assemblyData, 0, assemblyData.Length);
				return Assembly.Load(assemblyData);
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
				UserName = LoggedInUsername;
				return true;
			}
			return false;
			
			
		}
	}
}
