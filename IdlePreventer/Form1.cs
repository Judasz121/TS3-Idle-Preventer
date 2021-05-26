using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdlePreventer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Program.Setup(this);
			nicknameChangeUserControl1.Visible = false;
			reconnectUserControl1.Visible = false;
			try {
				if (Properties.Settings.Default["APIkey"].ToString() != string.Empty)
					apiKeyTextBox.Text = Properties.Settings.Default["APIkey"].ToString();
			}
			catch (ConfigurationException ex)
			{
				//MessageBox.Show("Error: " + ex.Message, "Config file is missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//Close();

				ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
				{
					ExeConfigFilename = "IdlePreventer.exe.config"
				};
				Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.PerUserRoamingAndLocal);
				config.AppSettings.Settings.Add("APIkey", string.Empty);
				config.Save();
			}
		}

		private void connectButton_Click(object sender, System.EventArgs e)
		{
			Program.ts3.ConnectAndAuthorizeAsync(apiKeyTextBox.Text);
		}

		private CancellationTokenSource tokenSource = new CancellationTokenSource();
		private void applyIdlePreventionButton_Click(object sender, EventArgs e)
		{
			
			if (applyIdlePreventionButton.Text == "Apply")
			{
				if (Program.ts3.tsServerConnected == false || Program.ts3.tsPluginConnected == false)
				{
					BlinkElement(connectButton, 3, 500, Color.Yellow);
					return;
				}

				string[] timeString;
				TimeSpan time = new TimeSpan();
				if (typeOfPreventionComboBox.Text == "reconnect" && reconnectUserControl1.checkIfKickedTimeComboBox.Text != string.Empty)
				{
					timeString = reconnectUserControl1.checkIfKickedTimeComboBox.Text.Split(' ');

					if (timeString[1] == "seconds" || timeString[1] == "second")
						time = new TimeSpan(0, 0, int.Parse(timeString[0]));
					else if (timeString[1] == "minutes" || timeString[1] == "minute")
						time = new TimeSpan(0, int.Parse(timeString[0]), 0);
					else if (timeString[1] == "hours" || timeString[1] == "hour")
						time = new TimeSpan(0, int.Parse(timeString[0]), 0);

					applyIdlePreventionButton.Text = "Stop";
					tokenSource = new CancellationTokenSource();
					Program.reconnectLoopAsync(time, tokenSource.Token);
				}
				else if (typeOfPreventionComboBox.Text == "nickname change" && nicknameChangeUserControl1.changeNicknameTimeComboBox.Text != string.Empty)
				{
					if(nicknameChangeUserControl1.nicknameChangeCharactersTextBox.Text == string.Empty)
					{
						BlinkElement(nicknameChangeUserControl1.nicknameChangeCharactersTextBox, 3, 500, Color.Yellow);
						return;
					}
					timeString = nicknameChangeUserControl1.changeNicknameTimeComboBox.Text.Split(' ');

					if (timeString[1] == "seconds" || timeString[1] == "second")
						time = new TimeSpan(0, 0, int.Parse(timeString[0]));
					else if (timeString[1] == "minutes" || timeString[1] == "minute")
						time = new TimeSpan(0, int.Parse(timeString[0]), 0);
					else if (timeString[1] == "hours" || timeString[1] == "hour")
						time = new TimeSpan(0, int.Parse(timeString[0]), 0);

					applyIdlePreventionButton.Text = "Stop";
					tokenSource = new CancellationTokenSource();
					Program.nicknameChangeLoopAsync(time, tokenSource.Token, nicknameChangeUserControl1.nicknameChangeCharactersTextBox.Text);
				}
			}
			else if (applyIdlePreventionButton.Text == "Stop")
			{
				tokenSource.Cancel();
				applyIdlePreventionButton.Text = "Apply";
			}
		}




		private void typeOfPreventionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (typeOfPreventionComboBox.Text == "reconnect")
			{
				nicknameChangeUserControl1.Visible = false;
				reconnectUserControl1.Visible = true;
				Form1.ActiveForm.Height = 226;
			}
			else if (typeOfPreventionComboBox.Text == "nickname change")
			{
				reconnectUserControl1.Visible = false;
				nicknameChangeUserControl1.Visible = true;
				Form1.ActiveForm.Height = 256;
			}
		}


		#region API key textbox select on focus
		private bool alreadyFocused = false;
		private void apiKeyTextBox_MouseUp(object sender, EventArgs e)
		{
			if(alreadyFocused == false && apiKeyTextBox.SelectionLength == 0)
			{
				alreadyFocused = true;
				apiKeyTextBox.SelectAll();
			}
		}
		private void apiKeyTextBox_Leave(object sender, EventArgs e)
		{
			apiKeyTextBox.DeselectAll();
			alreadyFocused = false;
		}
		private void apiKeyTextBox_GotFocus(object sender, EventArgs e)
		{
			if(MouseButtons == MouseButtons.None)
			{
				apiKeyTextBox.SelectAll();
				alreadyFocused = true;
			}
		}
		#endregion

		#region UI_animations

		private static bool blinkCalled = false;
		public static async Task BlinkElement(Control target, int blinksAmount, int blinkLength, Color blinkColor)
		{
			if (blinkCalled == false)
			{
				blinkCalled = true;
				Color defaultColor = target.BackColor;
				for (int i = 0; blinksAmount > i; i++)
				{
					target.BackColor = blinkColor;
					await Task.Delay(blinkLength / 2);
					target.BackColor = defaultColor;
					await Task.Delay(blinkLength / 2);
				}
				blinkCalled = false;
			}
		}

		public void DeactivateTypeOfPreventionInputs()
		{
			typeOfPreventionComboBox.Enabled = false;
			nicknameChangeUserControl1.changeNicknameTimeComboBox.Enabled = false;
			nicknameChangeUserControl1.nicknameChangeCharactersTextBox.Enabled = false;
			reconnectUserControl1.checkIfKickedTimeComboBox.Enabled = false;
		}
		public void ActivateTypeOfPreventionInputs()
		{
			typeOfPreventionComboBox.Enabled = true;
			nicknameChangeUserControl1.changeNicknameTimeComboBox.Enabled = true;
			nicknameChangeUserControl1.nicknameChangeCharactersTextBox.Enabled = true;
			reconnectUserControl1.checkIfKickedTimeComboBox.Enabled = true;
		}
		#endregion
	}
}
