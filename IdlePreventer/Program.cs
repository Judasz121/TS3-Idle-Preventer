using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Drawing;
using IdlePreventer.Properties;

namespace IdlePreventer
{
	static class Program
	{
		public static Form1 MW;
		public static TS3ClientQuery ts3;

		public static void Setup(Form1 window)
		{
			MW = window;
			ts3 = new TS3ClientQuery("localhost", 25639, window);
		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}



		public static async Task nicknameChangeLoopAsync(TimeSpan loopInterval, CancellationToken canToken, string addString)
		{
			string response = string.Empty;
			Debug.WriteLine("addString.Length=" + addString.Length);
			Debug.WriteLine("ts3.ClientNickname.LastIndexOf(addString)=" + ts3.tsClientNickname.LastIndexOf(addString));
			Debug.WriteLine("ts3.tsClientNickname.Length -1 =" + (ts3.tsClientNickname.Length - 1).ToString());
			if (ts3.tsClientNickname.LastIndexOf(addString) == -1)
			{
				response = await ts3.SendMessageAsync("clientvariable clid=" + ts3.tsClientId + " client_nickname");
				if (response.Contains("Exception"))
				{
					await ts3.ConnectAndAuthorizeAsync(Settings.Default.APIkey);
					response = await ts3.SendMessageAsync("clientvariable clid=" + ts3.tsClientId + " client_nickname");
				}
				else if (response == "not\\sconnected")
				{
					MW.applyIdlePreventionButton.Text = "Apply";
					Form1.BlinkButton(MW.connectButton, 3, 500, Color.Yellow);
					return;
				}
				ts3.tsClientNickname = ts3.SerializeResponse(response)["client_nickname"];
				ts3.tsClientNickname = ts3.tsClientNickname + addString;
				response = await ts3.SendMessageAsync("clientupdate client_nickname=" + ts3.tsClientNickname);
			}
			else if (ts3.tsClientNickname.LastIndexOf(addString) == ts3.tsClientNickname.Length - addString.Length)
			{
				response = await ts3.SendMessageAsync("clientvariable clid=" + ts3.tsClientId + " client_nickname");
				if (response.Contains("Exception"))
				{
					await ts3.ConnectAndAuthorizeAsync(Settings.Default.APIkey);
					response = await ts3.SendMessageAsync("clientvariable clid=" + ts3.tsClientId + " client_nickname");
				}
				else if (response == "not\\sconnected")
				{
					MW.applyIdlePreventionButton.Text = "Apply";
					return;
				}
				ts3.tsClientNickname = ts3.SerializeResponse(response)["client_nickname"];
				ts3.tsClientNickname = ts3.tsClientNickname.Remove(ts3.tsClientNickname.LastIndexOf(addString), addString.Length);
				response = await ts3.SendMessageAsync("clientupdate client_nickname=" + ts3.tsClientNickname);
			}
				
			IDictionary<string,string> serResponse = ts3.SerializeResponse(response);
			if(serResponse["msg"] == "ok")
			{
				await Task.Delay(loopInterval, canToken);
				if (!canToken.IsCancellationRequested)
					nicknameChangeLoopAsync(loopInterval, canToken, addString);
				else
					return;
			}
		}

		public static async Task reconnectLoopAsync(TimeSpan loopInterval, CancellationToken canToken)
		{
			string response = await ts3.SendMessageAsync("serverconnectinfo");
			if (response.Contains("Exception"))
			{
				await ts3.ConnectAndAuthorizeAsync(Settings.Default.APIkey);
				response = await ts3.SendMessageAsync("serverconnectinfo");
			}
			IDictionary<string, string> serResponse = ts3.SerializeResponse(response);
			if(serResponse["msg"] == "ok")
			{
				ts3.getMyClientCan = new CancellationTokenSource();
				ts3.GetMyConnectionInfoAsync(ts3.getMyClientCan.Token);
			}
			else if(serResponse["msg"] == "not\\sconnected")
			{
				if(ts3.tsServerPassword != null && ts3.tsServerPassword != "")
					ts3.SendMessageAsync("connect address=" + ts3.tsServerIp + " password=" + ts3.tsServerPassword + " channel=" + ts3.tsChannelPath + " nickname=" + ts3.tsClientNickname);
				else
					ts3.SendMessageAsync("connect address=" + ts3.tsServerIp + " channel=" + ts3.tsChannelPath + " nickname=" + ts3.tsClientNickname);
			}

			await Task.Delay(loopInterval, canToken);
			if (!canToken.IsCancellationRequested)
				reconnectLoopAsync(loopInterval, canToken);
			else
				return;
		}

	}
}
