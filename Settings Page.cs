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
using Loader;

namespace Loader
{
	public partial class UserControl4 : UserControl
	{
		public UserControl4()
		{
			InitializeComponent();

			
		}

		private void bunifuButton6_Click(object sender, EventArgs e)
		{
			string modsPath = ("Mods");
			string pluginsPath = ("Plugins");

			DialogResult dialogResult = MessageBox.Show("This action is irreversible, would you like to continue?", "Are you sure?", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Directory.Delete(modsPath, true);
				Directory.Delete(pluginsPath, true);
			}
			else if (dialogResult == DialogResult.No)
			{
				
			}
		}
	}
}
