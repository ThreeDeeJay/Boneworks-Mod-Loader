using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using System.Net;
using System.IO;

namespace Loader
{
	public partial class UserControl3 : UserControl
	{
		public UserControl3()
		{
			InitializeComponent();		
		}

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			foreach (var process in Process.GetProcessesByName("BONEWORKS"))
			{
				process.Kill();
			}
		}

		//Ultra
		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string file1 = "BONEWORKS_Data\\Plugins\\openvr_mod.cfg";
			string file2 = "BONEWORKS_Data\\Plugins\\openvr_api.dll";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934406307782471761/openvr_mod.cfg", file1);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934409256810209380/openvr_api.dll", file2);
		}

		//Quality
		private void bunifuButton3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string file1 = "BONEWORKS_Data\\Plugins\\openvr_mod.cfg";
			string file2 = "BONEWORKS_Data\\Plugins\\openvr_api.dll";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934407718511448084/openvr_mod.cfg", file1);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934409256810209380/openvr_api.dll", file2);
		}

		//Balanced
		private void bunifuButton4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string file1 = "BONEWORKS_Data\\Plugins\\openvr_mod.cfg";
			string file2 = "BONEWORKS_Data\\Plugins\\openvr_api.dll";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934408440355356752/openvr_mod.cfg", file1);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934409256810209380/openvr_api.dll", file2);
		}

		//Performance
		private void bunifuButton5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string file1 = "BONEWORKS_Data\\Plugins\\openvr_mod.cfg";
			string file2 = "BONEWORKS_Data\\Plugins\\openvr_api.dll";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934408535213764648/openvr_mod.cfg", file1);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934409256810209380/openvr_api.dll", file2);
		}

		//Remove Mod
		private void bunifuButton6_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string file1 = "BONEWORKS_Data\\Plugins\\openvr_api.dll";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/934408869990518804/openvr_api.dll", file1);

			String myPath = "BONEWORKS_Data\\Plugins\\openvr_mod.cfg";
			File.Delete(myPath);
		}
	}
}
