using System;

using System.Windows.Forms;
using TimeLogger.Properties;

namespace TimeLogger
{
	public partial class ChooseTimeToDisableDialog : Form
	{
		public int DisablePeriod;

		public ChooseTimeToDisableDialog()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DisablePeriod = (int)udDisablePeriod.Value;
			Settings.Default.LastEnteredDisablePeriod = DisablePeriod;
			Settings.Default.Save();
		}

		private void ChooseTimeToDisableDialog_Load(object sender, EventArgs e)
		{
			udDisablePeriod.Value = Settings.Default.LastEnteredDisablePeriod;
			udDisablePeriod.Select(0, udDisablePeriod.Text.Length);
		}
	}
}
