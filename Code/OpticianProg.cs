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
    using System.Drawing;
    using System.Reflection;
    using System.Security.Permissions;
    using System.Windows.Forms;

    public class OpticianProg : ApplicationContext //TODO: global dbb
    {
        private string _userName;

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private Icon _formIcon;

        /// <summary>
        /// Gets or sets the <see cref="System.Drawing.Icon"/> of the forms in the program
        /// </summary>
        /// <value>The <see cref="System.Drawing.Icon"/></value>
        public Icon FormIcon
        {
            get { return _formIcon; }
            set { _formIcon = value; }
        }

        /// <summary>
        /// The main form of the program
        /// </summary>
        Forms.MainGui mgui;

        public DBBackEnd dbb;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpticianProg"/> class.
        /// Authenticates the user, sets assembly resolvoing and the form icon
        /// If the user can be authenticated then the main form is shown
        /// </summary>
        public OpticianProg() //FIXME
        {
            AssemblyResolveEventAdd();
            FormIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();
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

        /// <summary>
        /// Sets an assembly resolve event handler for resolving missing assembly references. 
        /// Seperate method to deal with LinkDemand permissions
        /// </summary>
        [SecurityPermission(SecurityAction.LinkDemand, Unrestricted = true)]
        private void AssemblyResolveEventAdd()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AppDomain_CurrentDomain_AssemblyResolve);
        }

        /// <summary>
        /// Handles the AssemblyResolve event of the AppDomain_CurrentDomain control.
        /// Resolves missing assembly references by attempting to find them under embedded resources
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.ResolveEventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        Assembly AppDomain_CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            String resourceName = "OpticianDB.Libraries." +
                new AssemblyName(args.Name).Name + ".dll";
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                Byte[] assemblyData = new Byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }

        /// <summary>
        /// Calls a <see cref="Forms.LogOnForm"/> to authenticate the user
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the user has been authenticated</returns>
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
