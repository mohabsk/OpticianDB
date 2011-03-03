using System;
using System.Windows.Forms;

namespace OpticianDB
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            using (OpticianProg OProg = new OpticianProg())
            {
                Application.Run(OProg);
            }
		}
		
	}
}
