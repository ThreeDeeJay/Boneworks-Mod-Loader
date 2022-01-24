using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.IO;

//Im aware its messy asf

namespace Loader
{
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();






			Directory.CreateDirectory("BONEWORKS_Data\\Plugins");

			WebClient webClient = new WebClient();

			label1.Text = "Welcome, " + Environment.UserName;

			MessageBox.Show("MAKE SURE YOU PUT THIS EXE AND ALL DLL FILES ARE IN YOUR BONEWORKS FOLDER");

			string curFile = @"Plugins\\BackwardsCompatibilityPlugin.dll";
			if (File.Exists(curFile))
			{

			}
			else if (!File.Exists(curFile))
			{
				DialogResult dialogResult = MessageBox.Show("Required Mods are not installed, certain mods may not function as intended. Would you like to install the required mods?", "Required Mods are not installed.", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					MessageBox.Show("Please wait a few moments while the dependencies are installed, the window will pop up automatically once it has finished.");

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
				else if (dialogResult == DialogResult.No)
				{

				}	
			}
			string firstrun = "firstrun";
			if (File.Exists(firstrun))
			{

			}
			else if (!File.Exists(firstrun))
			{
				//Create firstrun (so the support promt only shows on first startup)
				string file5 = "firstrun";
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/917888058228105278/935116041657413662/firstrun", file5);

				DialogResult dialogResult = MessageBox.Show("You'll get instant updates to our application(s), update information and support if needed!", "Would you like to join the Development Discord server?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					
				}
				else if (dialogResult == DialogResult.No)
				{

				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			userControl11.Hide();
			userControl21.Show();
			userControl31.Hide();
			userControl41.Hide();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			userControl11.Hide();
			userControl21.Show();
			userControl31.Hide();
			userControl41.Hide();
		}

		private void bunifuButton3_Click_1(object sender, EventArgs e)
		{
			userControl11.Show();
			userControl21.Hide();
			userControl31.Hide();
			userControl41.Hide();
		}

		private void bunifuButton4_Click(object sender, EventArgs e)
		{
			userControl11.Hide();
			userControl21.Hide();
			userControl31.Show();
			userControl41.Hide();
		}

		private void bunifuButton5_Click(object sender, EventArgs e)
		{
			userControl11.Hide();
			userControl21.Hide();
			userControl31.Hide();
			userControl41.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
		{

		}

		private void bunifuButton6_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/pJEbBdsEk6");
		}

		private void bunifuSeparator3_Click(object sender, EventArgs e)
		{

		}

		private void bunifuSeparator2_Click(object sender, EventArgs e)
		{

		}
	}
}
		