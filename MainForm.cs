using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using TimeLogger.Properties;

namespace TimeLogger
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
		{
			enabledToolStripMenuItem.Checked = !enabledToolStripMenuItem.Checked;
		}

		private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
				mi.Invoke(notifyIcon1, null);
			}
		}

		private void askActivityTimer_Tick(object sender, EventArgs e)
		{
			if (!enabledToolStripMenuItem.Checked)
			{
				notifyIcon1.ShowBalloonTip(1000, "Warning!", "Time logger is currently disabled...", ToolTipIcon.Warning);
				return;
			}

			ShowEnterTaskForm();
		}

		private static void ShowEnterTaskForm()
		{
			var f = new EnterTaskForm();
			f.Show();
			f.TopMost = true;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem.Checked = Settings.Default.AllowNotSpecifyAction;
			ReadTimerIntervalFromSettings();
			Hide();
		}

		private void ReadTimerIntervalFromSettings()
		{
			askActivityTimer.Interval = (int)TimeSpan.FromMinutes(Settings.Default.TimerInterval).TotalMilliseconds;
		}

		private void enterCurrentActivityToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowEnterTaskForm();
		}

		private void allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem.Checked =
				!allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem.Checked;

			Settings.Default.AllowNotSpecifyAction = allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem.Checked;
			Settings.Default.Save();
		}

		private void openLogFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileHelper.CreateLogFileIfNotExists();

			var process = new Process();
			process.StartInfo.FileName = Settings.Default.LogFilePath;
			process.StartInfo.Verb = "Open";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
			process.Start();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new SettingsForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					ReadTimerIntervalFromSettings();
				}
			}
		}
	}
}
