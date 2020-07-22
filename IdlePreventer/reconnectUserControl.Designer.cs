namespace IdlePreventer
{
	partial class reconnectUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkIfKickedTimeComboBox = new System.Windows.Forms.ComboBox();
			this.checkIfKickedTimeInfoLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkIfKickedTimeComboBox
			// 
			this.checkIfKickedTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.checkIfKickedTimeComboBox.FormattingEnabled = true;
			this.checkIfKickedTimeComboBox.Items.AddRange(new object[] {
            "1 second",
            "5 seconds",
            "10 seconds",
            "15 seconds",
            "30 seconds",
            "1 minute",
            "2 minutes",
            "5 minutes",
            "10 minutes",
            "15 minutes",
            "30 minutes",
            "1 hour"});
			this.checkIfKickedTimeComboBox.Location = new System.Drawing.Point(121, 7);
			this.checkIfKickedTimeComboBox.Name = "checkIfKickedTimeComboBox";
			this.checkIfKickedTimeComboBox.Size = new System.Drawing.Size(121, 21);
			this.checkIfKickedTimeComboBox.TabIndex = 3;
			// 
			// checkIfKickedTimeInfoLabel
			// 
			this.checkIfKickedTimeInfoLabel.AutoSize = true;
			this.checkIfKickedTimeInfoLabel.Location = new System.Drawing.Point(3, 10);
			this.checkIfKickedTimeInfoLabel.Name = "checkIfKickedTimeInfoLabel";
			this.checkIfKickedTimeInfoLabel.Size = new System.Drawing.Size(112, 13);
			this.checkIfKickedTimeInfoLabel.TabIndex = 2;
			this.checkIfKickedTimeInfoLabel.Text = "check if kicked every:";
			// 
			// reconnectUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkIfKickedTimeComboBox);
			this.Controls.Add(this.checkIfKickedTimeInfoLabel);
			this.Name = "reconnectUserControl";
			this.Size = new System.Drawing.Size(249, 35);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ComboBox checkIfKickedTimeComboBox;
		public System.Windows.Forms.Label checkIfKickedTimeInfoLabel;
	}
}
