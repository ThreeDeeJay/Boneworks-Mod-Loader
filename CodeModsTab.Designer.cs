
namespace Loader
{
	partial class CodeModsTab
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
			Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeModsTab));
			this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
			this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.bunifuShadowPanel1.SuspendLayout();
			this.bunifuPages1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuShadowPanel1
			// 
			this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.bunifuShadowPanel1.BorderRadius = 1;
			this.bunifuShadowPanel1.BorderThickness = 1;
			this.bunifuShadowPanel1.Controls.Add(this.bunifuPages1);
			this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
			this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
			this.bunifuShadowPanel1.Location = new System.Drawing.Point(3, 3);
			this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
			this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
			this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
			this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
			this.bunifuShadowPanel1.ShadowDept = 2;
			this.bunifuShadowPanel1.ShadowDepth = 5;
			this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
			this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
			this.bunifuShadowPanel1.Size = new System.Drawing.Size(708, 435);
			this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
			this.bunifuShadowPanel1.TabIndex = 0;
			// 
			// bunifuPages1
			// 
			this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.bunifuPages1.AllowTransitions = true;
			this.bunifuPages1.Controls.Add(this.tabPage1);
			this.bunifuPages1.Controls.Add(this.tabPage2);
			this.bunifuPages1.Location = new System.Drawing.Point(3, 3);
			this.bunifuPages1.Multiline = true;
			this.bunifuPages1.Name = "bunifuPages1";
			this.bunifuPages1.Page = this.tabPage1;
			this.bunifuPages1.PageIndex = 0;
			this.bunifuPages1.PageName = "tabPage1";
			this.bunifuPages1.PageTitle = "tabPage1";
			this.bunifuPages1.SelectedIndex = 0;
			this.bunifuPages1.Size = new System.Drawing.Size(702, 435);
			this.bunifuPages1.TabIndex = 0;
			animation1.AnimateOnlyDifferences = false;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			this.bunifuPages1.Transition = animation1;
			this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(694, 409);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(192, 74);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// CodeModsTab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bunifuShadowPanel1);
			this.Name = "CodeModsTab";
			this.Size = new System.Drawing.Size(711, 441);
			this.bunifuShadowPanel1.ResumeLayout(false);
			this.bunifuPages1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
		private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
	}
}
