using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Threading;



namespace Loader
{
	public partial class Form1 : Form
	{


		public Form1()
		{


			InitializeComponent();
			MessageBox.Show("MAKE SURE YOU PUT THIS EXE AND 'Siticone.UI.dll' ARE IN YOUR BONEWORKS FOLDER");
			MessageBox.Show("Please wait a few moments while the base Mods/Plugins are installed, the window will pop up automatically once it has finished.");
			WebClient webClient = new WebClient();

			//Create Directories
			Directory.CreateDirectory("Mods\\");
			Directory.CreateDirectory("Plugins\\");

			//Define Dependencies
			string file1 = "Plugins\\BackwardsCompatibilityPlugin.dll";
			string file2 = "Mods\\ModThatIsNotMod.dll";
			string file3 = "Mods\\ModThatIsNotMod.xml";

			//Install dependencies to directories
			Thread.Sleep(2500);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/933697800120696862/933697831548641300/BackwardsCompatibilityPlugin.dll", file1);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/933697800120696862/933701156612505670/ModThatIsNotMod.dll", file2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/933697800120696862/933701156927049758/ModThatIsNotMod.xml", file3);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
