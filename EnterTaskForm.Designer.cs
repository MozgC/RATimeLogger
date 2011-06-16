namespace TimeLogger
{
	partial class EnterTaskForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterTaskForm));
			this.btnOK = new System.Windows.Forms.Button();
			this.lbActivities = new System.Windows.Forms.ListBox();
			this.txtCustomActivity = new System.Windows.Forms.TextBox();
			this.rbFromList = new System.Windows.Forms.RadioButton();
			this.rbCustom = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(177, 209);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lbActivities
			// 
			this.lbActivities.FormattingEnabled = true;
			this.lbActivities.Items.AddRange(new object[] {
            "Working",
            "ICQ",
            "RSDN",
            "Phone",
            "Surfing internet",
            "TV",
            "Eating",
            "Family"});
			this.lbActivities.Location = new System.Drawing.Point(6, 29);
			this.lbActivities.Name = "lbActivities";
			this.lbActivities.Size = new System.Drawing.Size(246, 121);
			this.lbActivities.TabIndex = 3;
			this.lbActivities.DoubleClick += new System.EventHandler(this.lbActivities_DoubleClick);
			// 
			// txtCustomActivity
			// 
			this.txtCustomActivity.Enabled = false;
			this.txtCustomActivity.Location = new System.Drawing.Point(6, 183);
			this.txtCustomActivity.Name = "txtCustomActivity";
			this.txtCustomActivity.Size = new System.Drawing.Size(246, 20);
			this.txtCustomActivity.TabIndex = 4;
			this.txtCustomActivity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomActivity_KeyDown);
			// 
			// rbFromList
			// 
			this.rbFromList.AutoSize = true;
			this.rbFromList.Checked = true;
			this.rbFromList.Location = new System.Drawing.Point(6, 6);
			this.rbFromList.Name = "rbFromList";
			this.rbFromList.Size = new System.Drawing.Size(246, 17);
			this.rbFromList.TabIndex = 5;
			this.rbFromList.TabStop = true;
			this.rbFromList.Text = "Please choose your current activity from the list";
			this.rbFromList.UseVisualStyleBackColor = true;
			// 
			// rbCustom
			// 
			this.rbCustom.AutoSize = true;
			this.rbCustom.Location = new System.Drawing.Point(6, 160);
			this.rbCustom.Name = "rbCustom";
			this.rbCustom.Size = new System.Drawing.Size(191, 17);
			this.rbCustom.TabIndex = 6;
			this.rbCustom.Text = "or enter your custom activity below:";
			this.rbCustom.UseVisualStyleBackColor = true;
			this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
			// 
			// EnterTaskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 237);
			this.Controls.Add(this.rbCustom);
			this.Controls.Add(this.rbFromList);
			this.Controls.Add(this.txtCustomActivity);
			this.Controls.Add(this.lbActivities);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EnterTaskForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enter current activity";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.EnterTaskForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ListBox lbActivities;
		private System.Windows.Forms.TextBox txtCustomActivity;
		private System.Windows.Forms.RadioButton rbFromList;
		private System.Windows.Forms.RadioButton rbCustom;
	}
}

