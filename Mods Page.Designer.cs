
namespace Loader
{
	partial class UserControl1
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Code Mods", System.Windows.Forms.HorizontalAlignment.Center);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Custom Weapons", System.Windows.Forms.HorizontalAlignment.Center);
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Deagle",
            "Custom Weapons"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Super Strength",
            "Code Mods"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
			this.GameNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ModTypeIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gamesListView = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// GameNameIndex
			// 
			this.GameNameIndex.Text = "Name";
			this.GameNameIndex.Width = 308;
			// 
			// ModTypeIndex
			// 
			this.ModTypeIndex.Text = "Type";
			this.ModTypeIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ModTypeIndex.Width = 140;
			// 
			// gamesListView
			// 
			this.gamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gamesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.gamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameNameIndex,
            this.ModTypeIndex});
			this.gamesListView.ForeColor = System.Drawing.Color.White;
			this.gamesListView.FullRowSelect = true;
			this.gamesListView.GridLines = true;
			listViewGroup1.Header = "Code Mods";
			listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			listViewGroup1.Name = "Code Mods";
			listViewGroup2.Header = "Custom Weapons";
			listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			listViewGroup2.Name = "CustomWeaponsGroup";
			this.gamesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
			this.gamesListView.HideSelection = false;
			listViewItem1.Group = listViewGroup2;
			listViewItem1.StateImageIndex = 0;
			listViewItem1.Tag = "2";
			listViewItem2.Group = listViewGroup1;
			listViewItem2.IndentCount = 4;
			this.gamesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.gamesListView.Location = new System.Drawing.Point(17, 42);
			this.gamesListView.Name = "gamesListView";
			this.gamesListView.Size = new System.Drawing.Size(762, 462);
			this.gamesListView.TabIndex = 7;
			this.gamesListView.UseCompatibleStateImageBehavior = false;
			this.gamesListView.View = System.Windows.Forms.View.Details;
			this.gamesListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.gamesListView);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(793, 507);
			this.Load += new System.EventHandler(this.UserControl1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.ColumnHeader GameNameIndex;
		public System.Windows.Forms.ColumnHeader ModTypeIndex;
		private System.Windows.Forms.ListView gamesListView;
	}
}
