using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TimeLogger.Properties;

namespace TimeLogger
{
	public partial class EnterTaskForm : Form
	{
		private readonly DateTime _formShown = DateTime.Now;

		public EnterTaskForm()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			LogAndClose();
		}

		private void LogAndClose()
		{
			try
			{
				string activity;
				if (rbFromList.Checked)
				{
					activity = lbActivities.Text;
				}
				else
				{
					activity = cbCustomActivity.Text;
					SetLastActivity(activity);
				}

				if (string.IsNullOrEmpty(activity))
				{
					MessageBox.Show("You should specify your activity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				FileHelper.CreateLogFileIfNotExists();
				File.AppendAllText(
					Settings.Default.LogFilePath,
					string.Format("{0}\t{1}{2}", _formShown, activity, Environment.NewLine),
					new UTF8Encoding(true));
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format(
					"Exception occurred during logging to the file.{0}{0}Exception message:{0}{1}",
					Environment.NewLine,
					ex.Message));
			}

			Close();
		}

		private static void SetLastActivity(string activity)
		{
			const int lastActivitiesToKeep = 5;

			int indexInRecent = Settings.Default.LastEnteredActivities.IndexOf(activity);
			bool recent = indexInRecent >= 0;

			if(!recent && Settings.Default.LastEnteredActivities.Count < lastActivitiesToKeep)
				Settings.Default.LastEnteredActivities.Add("");

			int shiftFrom = recent
				? indexInRecent
				: Math.Min(lastActivitiesToKeep - 1, Settings.Default.LastEnteredActivities.Count - 1);
			
			for (int i = shiftFrom; i > 0; i--)
			{
				Settings.Default.LastEnteredActivities[i] = Settings.Default.LastEnteredActivities[i - 1];
			}

			Settings.Default.LastEnteredActivities[0] = activity;
			
			Settings.Default.Save();
		}

		private void cbCustomActivity_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				LogAndClose();
		}

		private void EnterTaskForm_Load(object sender, EventArgs e)
		{
			Text = string.Format("Enter your current ({0}) activity", _formShown.ToShortTimeString());

			if (!Settings.Default.AllowNotSpecifyAction)
				ControlBox = false;

			foreach (string activity in Settings.Default.LastEnteredActivities)
				cbCustomActivity.Items.Add(activity);
		}

		private void rbCustom_CheckedChanged(object sender, EventArgs e)
		{
			cbCustomActivity.Enabled = rbCustom.Checked;
		}

		private void lbActivities_DoubleClick(object sender, EventArgs e)
		{
			int itemIndex = lbActivities.IndexFromPoint(lbActivities.PointToClient(Cursor.Position));
			if (itemIndex == ListBox.NoMatches) return;
			LogAndClose();
		}

	}
}
