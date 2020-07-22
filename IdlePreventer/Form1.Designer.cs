using System.Windows.Forms;

namespace IdlePreventer
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.connectButton = new System.Windows.Forms.Button();
			this.apiKeyTextBox = new System.Windows.Forms.TextBox();
			this.apiKeyInfoLabel = new System.Windows.Forms.Label();
			this.connectionStatusInfoLabel = new System.Windows.Forms.Label();
			this.connectionStatusLabel = new System.Windows.Forms.Label();
			this.idlePreventionTypeInfoLabel = new System.Windows.Forms.Label();
			this.typeOfPreventionComboBox = new System.Windows.Forms.ComboBox();
			this.separatorLabel = new System.Windows.Forms.Label();
			this.applyIdlePreventionButton = new System.Windows.Forms.Button();
			this.reconnectUserControl1 = new IdlePreventer.reconnectUserControl();
			this.nicknameChangeUserControl1 = new IdlePreventer.nicknameChangeUserControl();
			this.SuspendLayout();
			// 
			// connectButton
			// 
			this.connectButton.Location = new System.Drawing.Point(257, 12);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(57, 20);
			this.connectButton.TabIndex = 0;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// apiKeyTextBox
			// 
			this.apiKeyTextBox.Location = new System.Drawing.Point(60, 12);
			this.apiKeyTextBox.Name = "apiKeyTextBox";
			this.apiKeyTextBox.Size = new System.Drawing.Size(191, 20);
			this.apiKeyTextBox.TabIndex = 1;
			this.apiKeyTextBox.GotFocus += new System.EventHandler(this.apiKeyTextBox_GotFocus);
			this.apiKeyTextBox.Leave += new System.EventHandler(this.apiKeyTextBox_Leave);
			this.apiKeyTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.apiKeyTextBox_MouseUp);
			// 
			// apiKeyInfoLabel
			// 
			this.apiKeyInfoLabel.AutoSize = true;
			this.apiKeyInfoLabel.Location = new System.Drawing.Point(13, 15);
			this.apiKeyInfoLabel.Name = "apiKeyInfoLabel";
			this.apiKeyInfoLabel.Size = new System.Drawing.Size(47, 13);
			this.apiKeyInfoLabel.TabIndex = 2;
			this.apiKeyInfoLabel.Text = "API key:";
			this.apiKeyInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// connectionStatusInfoLabel
			// 
			this.connectionStatusInfoLabel.AccessibleName = "";
			this.connectionStatusInfoLabel.AutoSize = true;
			this.connectionStatusInfoLabel.Location = new System.Drawing.Point(13, 45);
			this.connectionStatusInfoLabel.Name = "connectionStatusInfoLabel";
			this.connectionStatusInfoLabel.Size = new System.Drawing.Size(40, 13);
			this.connectionStatusInfoLabel.TabIndex = 3;
			this.connectionStatusInfoLabel.Text = "Status:";
			// 
			// connectionStatusLabel
			// 
			this.connectionStatusLabel.AutoSize = true;
			this.connectionStatusLabel.Location = new System.Drawing.Point(57, 45);
			this.connectionStatusLabel.MaximumSize = new System.Drawing.Size(250, 52);
			this.connectionStatusLabel.MinimumSize = new System.Drawing.Size(250, 52);
			this.connectionStatusLabel.Name = "connectionStatusLabel";
			this.connectionStatusLabel.Size = new System.Drawing.Size(250, 52);
			this.connectionStatusLabel.TabIndex = 4;
			this.connectionStatusLabel.Text = "not connected";
			// 
			// idlePreventionTypeInfoLabel
			// 
			this.idlePreventionTypeInfoLabel.AutoSize = true;
			this.idlePreventionTypeInfoLabel.Location = new System.Drawing.Point(11, 120);
			this.idlePreventionTypeInfoLabel.Name = "idlePreventionTypeInfoLabel";
			this.idlePreventionTypeInfoLabel.Size = new System.Drawing.Size(95, 13);
			this.idlePreventionTypeInfoLabel.TabIndex = 5;
			this.idlePreventionTypeInfoLabel.Text = "type of prevention:";
			// 
			// typeOfPreventionComboBox
			// 
			this.typeOfPreventionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeOfPreventionComboBox.FormattingEnabled = true;
			this.typeOfPreventionComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.typeOfPreventionComboBox.Items.AddRange(new object[] {
            "nickname change",
            "reconnect"});
			this.typeOfPreventionComboBox.Location = new System.Drawing.Point(111, 117);
			this.typeOfPreventionComboBox.Name = "typeOfPreventionComboBox";
			this.typeOfPreventionComboBox.Size = new System.Drawing.Size(121, 21);
			this.typeOfPreventionComboBox.TabIndex = 6;
			this.typeOfPreventionComboBox.SelectedIndexChanged += new System.EventHandler(this.typeOfPreventionComboBox_SelectedIndexChanged);
			// 
			// separatorLabel
			// 
			this.separatorLabel.AutoSize = true;
			this.separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.separatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.separatorLabel.Location = new System.Drawing.Point(14, 104);
			this.separatorLabel.MaximumSize = new System.Drawing.Size(100, 2);
			this.separatorLabel.MinimumSize = new System.Drawing.Size(300, 2);
			this.separatorLabel.Name = "separatorLabel";
			this.separatorLabel.Size = new System.Drawing.Size(300, 2);
			this.separatorLabel.TabIndex = 7;
			// 
			// applyIdlePreventionButton
			// 
			this.applyIdlePreventionButton.Location = new System.Drawing.Point(239, 117);
			this.applyIdlePreventionButton.Name = "applyIdlePreventionButton";
			this.applyIdlePreventionButton.Size = new System.Drawing.Size(75, 23);
			this.applyIdlePreventionButton.TabIndex = 10;
			this.applyIdlePreventionButton.Text = "Apply";
			this.applyIdlePreventionButton.UseVisualStyleBackColor = true;
			this.applyIdlePreventionButton.Click += new System.EventHandler(this.applyIdlePreventionButton_Click);
			// 
			// reconnectUserControl1
			// 
			this.reconnectUserControl1.Location = new System.Drawing.Point(27, 144);
			this.reconnectUserControl1.Name = "reconnectUserControl1";
			this.reconnectUserControl1.Size = new System.Drawing.Size(249, 35);
			this.reconnectUserControl1.TabIndex = 9;
			// 
			// nicknameChangeUserControl1
			// 
			this.nicknameChangeUserControl1.Location = new System.Drawing.Point(27, 144);
			this.nicknameChangeUserControl1.Name = "nicknameChangeUserControl1";
			this.nicknameChangeUserControl1.Size = new System.Drawing.Size(249, 35);
			this.nicknameChangeUserControl1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 187);
			this.Controls.Add(this.applyIdlePreventionButton);
			this.Controls.Add(this.reconnectUserControl1);
			this.Controls.Add(this.nicknameChangeUserControl1);
			this.Controls.Add(this.separatorLabel);
			this.Controls.Add(this.typeOfPreventionComboBox);
			this.Controls.Add(this.idlePreventionTypeInfoLabel);
			this.Controls.Add(this.connectionStatusLabel);
			this.Controls.Add(this.connectionStatusInfoLabel);
			this.Controls.Add(this.apiKeyInfoLabel);
			this.Controls.Add(this.apiKeyTextBox);
			this.Controls.Add(this.connectButton);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Idle Preventer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button connectButton;
		public TextBox apiKeyTextBox;
		public Label apiKeyInfoLabel;
		public Label connectionStatusInfoLabel;
		public Label connectionStatusLabel;
		public Label idlePreventionTypeInfoLabel;
		public ComboBox typeOfPreventionComboBox;
		private Label separatorLabel;
		private nicknameChangeUserControl nicknameChangeUserControl1;
		private reconnectUserControl reconnectUserControl1;
		public Button applyIdlePreventionButton;
	}
}

