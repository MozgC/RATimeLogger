namespace TimeLogger
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enterCurrentActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem,
            this.enterCurrentActivityToolStripMenuItem,
            this.openLogFileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(324, 158);
			// 
			// enabledToolStripMenuItem
			// 
			this.enabledToolStripMenuItem.Checked = true;
			this.enabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
			this.enabledToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
			this.enabledToolStripMenuItem.Text = "Enabled";
			this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
			// 
			// allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem
			// 
			this.allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem.Name = "allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem";
			this.allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
			this.allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem.Text = "Allow closing without specifying current action";
			this.allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem.Click += new System.EventHandler(this.allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem_Click);
			// 
			// enterCurrentActivityToolStripMenuItem
			// 
			this.enterCurrentActivityToolStripMenuItem.Name = "enterCurrentActivityToolStripMenuItem";
			this.enterCurrentActivityToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
			this.enterCurrentActivityToolStripMenuItem.Text = "Enter current activity...";
			this.enterCurrentActivityToolStripMenuItem.Click += new System.EventHandler(this.enterCurrentActivityToolStripMenuItem_Click);
			// 
			// openLogFileToolStripMenuItem
			// 
			this.openLogFileToolStripMenuItem.Name = "openLogFileToolStripMenuItem";
			this.openLogFileToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
			this.openLogFileToolStripMenuItem.Text = "Open log file";
			this.openLogFileToolStripMenuItem.Click += new System.EventHandler(this.openLogFileToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
			this.settingsToolStripMenuItem.Text = "Settings...";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Gosu Time Logger";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 600000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 259);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem enterCurrentActivityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allowClosingWithoutSpecifyingCurrentActionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openLogFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
	}
}