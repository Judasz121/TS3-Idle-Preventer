namespace IdlePreventer
{
	partial class nicknameChangeUserControl
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
			this.changeNicknameTimeInfoLabel = new System.Windows.Forms.Label();
			this.changeNicknameTimeComboBox = new System.Windows.Forms.ComboBox();
			this.nicknameChangeCharactersLabel = new System.Windows.Forms.Label();
			this.nicknameChangeCharactersTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// changeNicknameTimeInfoLabel
			// 
			this.changeNicknameTimeInfoLabel.AutoSize = true;
			this.changeNicknameTimeInfoLabel.Location = new System.Drawing.Point(3, 10);
			this.changeNicknameTimeInfoLabel.Name = "changeNicknameTimeInfoLabel";
			this.changeNicknameTimeInfoLabel.Size = new System.Drawing.Size(104, 13);
			this.changeNicknameTimeInfoLabel.TabIndex = 0;
			this.changeNicknameTimeInfoLabel.Text = "change name every:";
			// 
			// changeNicknameTimeComboBox
			// 
			this.changeNicknameTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.changeNicknameTimeComboBox.FormattingEnabled = true;
			this.changeNicknameTimeComboBox.Items.AddRange(new object[] {
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
			this.changeNicknameTimeComboBox.Location = new System.Drawing.Point(121, 7);
			this.changeNicknameTimeComboBox.Name = "changeNicknameTimeComboBox";
			this.changeNicknameTimeComboBox.Size = new System.Drawing.Size(121, 21);
			this.changeNicknameTimeComboBox.TabIndex = 1;
			// 
			// nicknameChangeCharactersLabel
			// 
			this.nicknameChangeCharactersLabel.AutoSize = true;
			this.nicknameChangeCharactersLabel.Location = new System.Drawing.Point(3, 41);
			this.nicknameChangeCharactersLabel.Name = "nicknameChangeCharactersLabel";
			this.nicknameChangeCharactersLabel.Size = new System.Drawing.Size(93, 13);
			this.nicknameChangeCharactersLabel.TabIndex = 2;
			this.nicknameChangeCharactersLabel.Text = "characters to add:";
			// 
			// nicknameChangeCharactersTextBox
			// 
			this.nicknameChangeCharactersTextBox.Location = new System.Drawing.Point(121, 38);
			this.nicknameChangeCharactersTextBox.Name = "nicknameChangeCharactersTextBox";
			this.nicknameChangeCharactersTextBox.Size = new System.Drawing.Size(121, 20);
			this.nicknameChangeCharactersTextBox.TabIndex = 3;
			this.nicknameChangeCharactersTextBox.Text = ".";
			// 
			// nicknameChangeUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nicknameChangeCharactersTextBox);
			this.Controls.Add(this.nicknameChangeCharactersLabel);
			this.Controls.Add(this.changeNicknameTimeComboBox);
			this.Controls.Add(this.changeNicknameTimeInfoLabel);
			this.Name = "nicknameChangeUserControl";
			this.Size = new System.Drawing.Size(249, 70);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label changeNicknameTimeInfoLabel;
		public System.Windows.Forms.ComboBox changeNicknameTimeComboBox;
		public System.Windows.Forms.Label nicknameChangeCharactersLabel;
		public System.Windows.Forms.TextBox nicknameChangeCharactersTextBox;
	}
}
