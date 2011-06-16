using System;
using System.IO;
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
				string activity = rbFromList.Checked ? lbActivities.Text : txtCustomActivity.Text;
				if (string.IsNullOrEmpty(activity))
				{
					MessageBox.Show("You should specify your activity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				FileHelper.CreateLogFileIfNotExists();
				File.AppendAllText(Settings.Default.LogFilePath, string.Format("{0}\t{1}{2}", _formShown, activity, Environment.NewLine));
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

		private void txtCustomActivity_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				LogAndClose();
		}

		private void EnterTaskForm_Load(object sender, EventArgs e)
		{
			Text = string.Format("Enter your current ({0}) activity", _formShown.ToShortTimeString());
			
			if(!Settings.Default.AllowNotSpecifyAction)
				ControlBox = false;
		}

		private void rbCustom_CheckedChanged(object sender, EventArgs e)
		{
			txtCustomActivity.Enabled = rbCustom.Checked;
		}

		private void lbActivities_DoubleClick(object sender, EventArgs e)
		{
			int itemIndex = lbActivities.IndexFromPoint(lbActivities.PointToClient(Cursor.Position));
			if(itemIndex == ListBox.NoMatches) return;
			LogAndClose();
		}

	}
}
