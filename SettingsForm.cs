using System;
using System.Windows.Forms;
using TimeLogger.Properties;

namespace TimeLogger
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			udTimerInterval.Value = Settings.Default.TimerInterval;
			txtLogFilePath.Text = Settings.Default.LogFilePath;
		}

		private void btnShowFileSaveDialog_Click(object sender, EventArgs e)
		{
			using (var fileDialog = new SaveFileDialog())
			{
				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					txtLogFilePath.Text = fileDialog.FileName;
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Settings.Default.TimerInterval = (int)udTimerInterval.Value;
			Settings.Default.LogFilePath = txtLogFilePath.Text;
			Settings.Default.Save();
		}
	}
}
