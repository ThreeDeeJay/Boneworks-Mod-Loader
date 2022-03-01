using System;
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



			gamesListView.Sorting = SortOrder.Ascending;

			if (string.IsNullOrEmpty(GameNameIndex.Text)||string.IsNullOrEmpty(ModTypeIndex.Text))
			{
				ListViewItem item = new ListViewItem(GameNameIndex.Text);
				item.SubItems.Add(GameNameIndex.Text);
				gamesListView.Items.Add(item);
			}

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuButton3_Click(object sender, EventArgs e)
		{
		}

		private void UserControl1_Load(object sender, EventArgs e)
		{
		}

		private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
