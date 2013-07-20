/*
 * @author venyii
 */
namespace SimpleLogitechProfiler
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.operatingRange = new System.Windows.Forms.TextBox();
			this.operatingRangeLbl = new System.Windows.Forms.Label();
			this.forceFeebackEnableLbl = new System.Windows.Forms.Label();
			this.forceFeebackEnable = new System.Windows.Forms.CheckBox();
			this.save = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.profilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.combinedPedalsEnableLbl = new System.Windows.Forms.Label();
			this.combinedPedalsEnable = new System.Windows.Forms.CheckBox();
			this.damperGainPercentageLbl = new System.Windows.Forms.Label();
			this.springGainPercentageLbl = new System.Windows.Forms.Label();
			this.springGainPercentage = new System.Windows.Forms.TextBox();
			this.overallGainPercentageLbl = new System.Windows.Forms.Label();
			this.overallGainPercentage = new System.Windows.Forms.TextBox();
			this.defaultSpringGainPercentageLbl = new System.Windows.Forms.Label();
			this.defaultSpringGainPercentage = new System.Windows.Forms.TextBox();
			this.persistentSpringEnableLbl = new System.Windows.Forms.Label();
			this.persistentSpringEnable = new System.Windows.Forms.CheckBox();
			this.gameSettingsEnableLbl = new System.Windows.Forms.Label();
			this.gameSettingsEnable = new System.Windows.Forms.CheckBox();
			this.damperGainPercentage = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(112, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(178, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Profile";
			// 
			// operatingRange
			// 
			this.operatingRange.Enabled = false;
			this.operatingRange.Location = new System.Drawing.Point(190, 59);
			this.operatingRange.Name = "operatingRange";
			this.operatingRange.Size = new System.Drawing.Size(53, 20);
			this.operatingRange.TabIndex = 2;
			// 
			// operatingRangeLbl
			// 
			this.operatingRangeLbl.Location = new System.Drawing.Point(12, 62);
			this.operatingRangeLbl.Name = "operatingRangeLbl";
			this.operatingRangeLbl.Size = new System.Drawing.Size(158, 17);
			this.operatingRangeLbl.TabIndex = 3;
			this.operatingRangeLbl.Text = "OperatingRange";
			// 
			// forceFeebackEnableLbl
			// 
			this.forceFeebackEnableLbl.Location = new System.Drawing.Point(12, 197);
			this.forceFeebackEnableLbl.Name = "forceFeebackEnableLbl";
			this.forceFeebackEnableLbl.Size = new System.Drawing.Size(158, 17);
			this.forceFeebackEnableLbl.TabIndex = 4;
			this.forceFeebackEnableLbl.Text = "ForceFeebackEnable";
			// 
			// forceFeebackEnable
			// 
			this.forceFeebackEnable.Enabled = false;
			this.forceFeebackEnable.Location = new System.Drawing.Point(192, 192);
			this.forceFeebackEnable.Name = "forceFeebackEnable";
			this.forceFeebackEnable.Size = new System.Drawing.Size(28, 24);
			this.forceFeebackEnable.TabIndex = 5;
			this.forceFeebackEnable.UseVisualStyleBackColor = true;
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(12, 286);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(315, 23);
			this.save.TabIndex = 6;
			this.save.Text = "Load Profile";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.SaveClick);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipText = "SimpleLogitechProfiler";
			this.notifyIcon1.BalloonTipTitle = "SimpleLogitechProfiler";
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "SimpleLogitechProfiler";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.profilesToolStripMenuItem,
									this.showToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
			// 
			// profilesToolStripMenuItem
			// 
			this.profilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.testToolStripMenuItem});
			this.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem";
			this.profilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.profilesToolStripMenuItem.Text = "Profiles";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.testToolStripMenuItem.Text = "Test";
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.showToolStripMenuItem.Text = "Show";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// combinedPedalsEnableLbl
			// 
			this.combinedPedalsEnableLbl.Location = new System.Drawing.Point(12, 218);
			this.combinedPedalsEnableLbl.Name = "combinedPedalsEnableLbl";
			this.combinedPedalsEnableLbl.Size = new System.Drawing.Size(158, 20);
			this.combinedPedalsEnableLbl.TabIndex = 7;
			this.combinedPedalsEnableLbl.Text = "CombinedPedalsEnable";
			// 
			// combinedPedalsEnable
			// 
			this.combinedPedalsEnable.Enabled = false;
			this.combinedPedalsEnable.Location = new System.Drawing.Point(192, 213);
			this.combinedPedalsEnable.Name = "combinedPedalsEnable";
			this.combinedPedalsEnable.Size = new System.Drawing.Size(45, 24);
			this.combinedPedalsEnable.TabIndex = 8;
			this.combinedPedalsEnable.UseVisualStyleBackColor = true;
			// 
			// damperGainPercentageLbl
			// 
			this.damperGainPercentageLbl.Location = new System.Drawing.Point(12, 168);
			this.damperGainPercentageLbl.Name = "damperGainPercentageLbl";
			this.damperGainPercentageLbl.Size = new System.Drawing.Size(134, 23);
			this.damperGainPercentageLbl.TabIndex = 9;
			this.damperGainPercentageLbl.Text = "DamperGainPercentage";
			// 
			// springGainPercentageLbl
			// 
			this.springGainPercentageLbl.Location = new System.Drawing.Point(12, 90);
			this.springGainPercentageLbl.Name = "springGainPercentageLbl";
			this.springGainPercentageLbl.Size = new System.Drawing.Size(158, 23);
			this.springGainPercentageLbl.TabIndex = 11;
			this.springGainPercentageLbl.Text = "SpringGainPercentage";
			// 
			// springGainPercentage
			// 
			this.springGainPercentage.Enabled = false;
			this.springGainPercentage.Location = new System.Drawing.Point(190, 85);
			this.springGainPercentage.Name = "springGainPercentage";
			this.springGainPercentage.Size = new System.Drawing.Size(53, 20);
			this.springGainPercentage.TabIndex = 12;
			// 
			// overallGainPercentageLbl
			// 
			this.overallGainPercentageLbl.Location = new System.Drawing.Point(12, 116);
			this.overallGainPercentageLbl.Name = "overallGainPercentageLbl";
			this.overallGainPercentageLbl.Size = new System.Drawing.Size(158, 23);
			this.overallGainPercentageLbl.TabIndex = 13;
			this.overallGainPercentageLbl.Text = "OverallGainPercentage";
			// 
			// overallGainPercentage
			// 
			this.overallGainPercentage.Enabled = false;
			this.overallGainPercentage.Location = new System.Drawing.Point(190, 113);
			this.overallGainPercentage.Name = "overallGainPercentage";
			this.overallGainPercentage.Size = new System.Drawing.Size(53, 20);
			this.overallGainPercentage.TabIndex = 14;
			// 
			// defaultSpringGainPercentageLbl
			// 
			this.defaultSpringGainPercentageLbl.Location = new System.Drawing.Point(12, 142);
			this.defaultSpringGainPercentageLbl.Name = "defaultSpringGainPercentageLbl";
			this.defaultSpringGainPercentageLbl.Size = new System.Drawing.Size(158, 23);
			this.defaultSpringGainPercentageLbl.TabIndex = 15;
			this.defaultSpringGainPercentageLbl.Text = "DefaultSpringGainPercentage";
			// 
			// defaultSpringGainPercentage
			// 
			this.defaultSpringGainPercentage.Enabled = false;
			this.defaultSpringGainPercentage.Location = new System.Drawing.Point(190, 139);
			this.defaultSpringGainPercentage.Name = "defaultSpringGainPercentage";
			this.defaultSpringGainPercentage.Size = new System.Drawing.Size(53, 20);
			this.defaultSpringGainPercentage.TabIndex = 16;
			// 
			// persistentSpringEnableLbl
			// 
			this.persistentSpringEnableLbl.Location = new System.Drawing.Point(12, 239);
			this.persistentSpringEnableLbl.Name = "persistentSpringEnableLbl";
			this.persistentSpringEnableLbl.Size = new System.Drawing.Size(151, 23);
			this.persistentSpringEnableLbl.TabIndex = 17;
			this.persistentSpringEnableLbl.Text = "PersistentSpringEnable";
			// 
			// persistentSpringEnable
			// 
			this.persistentSpringEnable.Enabled = false;
			this.persistentSpringEnable.Location = new System.Drawing.Point(192, 234);
			this.persistentSpringEnable.Name = "persistentSpringEnable";
			this.persistentSpringEnable.Size = new System.Drawing.Size(35, 24);
			this.persistentSpringEnable.TabIndex = 18;
			this.persistentSpringEnable.UseVisualStyleBackColor = true;
			// 
			// gameSettingsEnableLbl
			// 
			this.gameSettingsEnableLbl.Location = new System.Drawing.Point(12, 260);
			this.gameSettingsEnableLbl.Name = "gameSettingsEnableLbl";
			this.gameSettingsEnableLbl.Size = new System.Drawing.Size(133, 23);
			this.gameSettingsEnableLbl.TabIndex = 19;
			this.gameSettingsEnableLbl.Text = "GameSettingsEnable";
			// 
			// gameSettingsEnable
			// 
			this.gameSettingsEnable.Enabled = false;
			this.gameSettingsEnable.Location = new System.Drawing.Point(192, 255);
			this.gameSettingsEnable.Name = "gameSettingsEnable";
			this.gameSettingsEnable.Size = new System.Drawing.Size(46, 24);
			this.gameSettingsEnable.TabIndex = 20;
			this.gameSettingsEnable.UseVisualStyleBackColor = true;
			// 
			// damperGainPercentage
			// 
			this.damperGainPercentage.Enabled = false;
			this.damperGainPercentage.Location = new System.Drawing.Point(190, 165);
			this.damperGainPercentage.Name = "damperGainPercentage";
			this.damperGainPercentage.Size = new System.Drawing.Size(53, 20);
			this.damperGainPercentage.TabIndex = 21;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 321);
			this.Controls.Add(this.damperGainPercentage);
			this.Controls.Add(this.gameSettingsEnable);
			this.Controls.Add(this.gameSettingsEnableLbl);
			this.Controls.Add(this.persistentSpringEnable);
			this.Controls.Add(this.persistentSpringEnableLbl);
			this.Controls.Add(this.defaultSpringGainPercentageLbl);
			this.Controls.Add(this.defaultSpringGainPercentage);
			this.Controls.Add(this.overallGainPercentage);
			this.Controls.Add(this.springGainPercentage);
			this.Controls.Add(this.overallGainPercentageLbl);
			this.Controls.Add(this.springGainPercentageLbl);
			this.Controls.Add(this.damperGainPercentageLbl);
			this.Controls.Add(this.combinedPedalsEnable);
			this.Controls.Add(this.combinedPedalsEnableLbl);
			this.Controls.Add(this.save);
			this.Controls.Add(this.forceFeebackEnable);
			this.Controls.Add(this.forceFeebackEnableLbl);
			this.Controls.Add(this.operatingRangeLbl);
			this.Controls.Add(this.operatingRange);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SimpleLogitechProfiler";
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox damperGainPercentage;
		private System.Windows.Forms.CheckBox gameSettingsEnable;
		private System.Windows.Forms.Label gameSettingsEnableLbl;
		private System.Windows.Forms.CheckBox persistentSpringEnable;
		private System.Windows.Forms.Label persistentSpringEnableLbl;
		private System.Windows.Forms.TextBox defaultSpringGainPercentage;
		private System.Windows.Forms.Label defaultSpringGainPercentageLbl;
		private System.Windows.Forms.TextBox overallGainPercentage;
		private System.Windows.Forms.Label overallGainPercentageLbl;
		private System.Windows.Forms.TextBox springGainPercentage;
		private System.Windows.Forms.Label springGainPercentageLbl;
		private System.Windows.Forms.Label damperGainPercentageLbl;
		private System.Windows.Forms.CheckBox combinedPedalsEnable;
		private System.Windows.Forms.Label combinedPedalsEnableLbl;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem profilesToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.CheckBox forceFeebackEnable;
		private System.Windows.Forms.Label forceFeebackEnableLbl;
		private System.Windows.Forms.Label operatingRangeLbl;
		private System.Windows.Forms.TextBox operatingRange;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
