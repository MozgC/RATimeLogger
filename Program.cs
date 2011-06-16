using System;
using System.Windows.Forms;

namespace TimeLogger
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm f = new MainForm();
			f.ShowInTaskbar = false;
			f.WindowState = FormWindowState.Minimized;
			
			Application.Run(f);
		}

	}
}
