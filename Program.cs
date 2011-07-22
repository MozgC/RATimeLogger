using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;
using TimeLogger.Properties;

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

			if (string.IsNullOrEmpty(Settings.Default.LogFilePath))
			{
				Settings.Default.LogFilePath = Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
					@"RA\TimeLogger\timelog.txt");
				
				Settings.Default.Save();
			}

			if (Settings.Default.LastEnteredActivities == null)
			{
				Settings.Default.LastEnteredActivities = new StringCollection();
			}

			var f = new MainForm();
			f.ShowInTaskbar = false;
			f.WindowState = FormWindowState.Minimized;

			Application.Run(f);
		}

	}
}
