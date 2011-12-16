namespace TimeLogger
{
	partial class SettingsForm
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLogFilePath = new System.Windows.Forms.TextBox();
			this.btnShowFileSaveDialog = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(316, 52);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(235, 52);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Log file path:";
			// 
			// txtLogFilePath
			// 
			this.txtLogFilePath.Location = new System.Drawing.Point(9, 25);
			this.txtLogFilePath.Name = "txtLogFilePath";
			this.txtLogFilePath.Size = new System.Drawing.Size(359, 20);
			this.txtLogFilePath.TabIndex = 4;
			// 
			// btnShowFileSaveDialog
			// 
			this.btnShowFileSaveDialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnShowFileSaveDialog.Location = new System.Drawing.Point(367, 25);
			this.btnShowFileSaveDialog.Margin = new System.Windows.Forms.Padding(0);
			this.btnShowFileSaveDialog.Name = "btnShowFileSaveDialog";
			this.btnShowFileSaveDialog.Size = new System.Drawing.Size(24, 20);
			this.btnShowFileSaveDialog.TabIndex = 5;
			this.btnShowFileSaveDialog.Text = "...";
			this.btnShowFileSaveDialog.UseVisualStyleBackColor = false;
			this.btnShowFileSaveDialog.Click += new System.EventHandler(this.btnShowFileSaveDialog_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 82);
			this.Controls.Add(this.btnShowFileSaveDialog);
			this.Controls.Add(this.txtLogFilePath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLogFilePath;
		private System.Windows.Forms.Button btnShowFileSaveDialog;
	}
}