﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			InitializeComponent();
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuButton3_Click(object sender, EventArgs e)
		{
			codeModsTab1.Show();
		}

		private void UserControl1_Load(object sender, EventArgs e)
		{
			codeModsTab1.Hide();
		}
	}
}
