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
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OpticianDB
{
    public class OpticianProg : ApplicationContext //TODO: global dbb
    {
        public string UserName { get; set; }


        public Icon FormIcon { get; set; }

        /// <summary>
        ///   The main form of the program
        /// </summary>
        private Forms.MainGui mgui;

        public DBBackEnd dbb;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "OpticianProg" /> class.
        ///   Authenticates the user, sets assembly resolvoing and the form icon
        ///   If the user can be authenticated then the main form is shown
        /// </summary>
        public OpticianProg() //FIXME
        {
            AppDomain.CurrentDomain.AssemblyResolve += AppDomain_CurrentDomain_AssemblyResolve;
            FormIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            dbb = new DBBackEnd();
            if (Authenticate())
            {
                mgui = new Forms.MainGui();
                MainForm = mgui;
                mgui.Show();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        ///   Handles the AssemblyResolve event of the AppDomain_CurrentDomain control.
        ///   Resolves missing assembly references by attempting to find them under embedded resources
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "args">The <see cref = "System.ResolveEventArgs" /> instance containing the event data.</param>
        /// <returns></returns>
        private Assembly AppDomain_CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            String resourceName = "OpticianDB.Libraries." +
                                  new AssemblyName(args.Name).Name + ".dll";
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                Byte[] assemblyData = new Byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }

        /// <summary>
        ///   Calls a <see cref = "Forms.LogOnForm" /> to authenticate the user
        /// </summary>
        /// <returns><c>true</c> indicating the user has been authenticated; Otherwise, <c>false</c></returns>
        public bool Authenticate()
        {
            DialogResult loginResult;
            string loggedInUsername;
            using (Forms.LogOnForm loginForm = new Forms.LogOnForm())
            {
                loginResult = loginForm.ShowDialog();
                loggedInUsername = loginForm.UsernameTextBox.Text;
            }

            if (loginResult == DialogResult.OK)
            {
                UserName = loggedInUsername;
                return true;
            }
            return false;
        }
    }
}