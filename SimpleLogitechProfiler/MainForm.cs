/*
 * @author venyii
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleLogitechProfiler
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private Profiles profiles;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.profiles = new Profiles();
			
			if (this.profiles.existsProfileXml()) {
				this.profiles.loadProfilesFromFile();
				this.fillProfiles();
			} else {
				MessageBox.Show(
					"Could not find profile xml file at " + this.profiles.profileXml + "!",
					"Load Profile",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}
		
		private void fillProfiles()
		{
			// Fill Combobox
			var dataSource = this.profiles.buildDataSource();
			this.comboBox1.DataSource = dataSource;
			this.comboBox1.DisplayMember = "name";
			this.comboBox1.ValueMember = "id";
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			
			// Fill Tray with profiles
			this.profilesToolStripMenuItem.DropDownItems.Clear();
			
			foreach (Profile profile in this.profiles.getProfiles()) {
				ToolStripMenuItem profileItem;
				profileItem = new ToolStripMenuItem();
				profileItem.Text = profile.name;
				profileItem.Tag = profile.id;
				profileItem.Click += new EventHandler(processProfileItem);
				this.profilesToolStripMenuItem.DropDownItems.Add(profileItem);
			}
		}
		
		private void processProfileItem(object sender, EventArgs e)
		{
			string selectedProfile = ((ToolStripMenuItem)sender).Tag.ToString();
			this.enableProfile(this.profiles.getById(selectedProfile));
		}
		
		private Profile getSelectedProfile()
		{
			return (Profile) this.comboBox1.SelectedItem;
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e) {
			Profile prof = this.getSelectedProfile();
			
			this.operatingRange.Text = prof.operatingRange.ToString();
			this.springGainPercentage.Text = prof.springGainPercentage.ToString();
			this.overallGainPercentage.Text = prof.overallGainPercentage.ToString();
			this.defaultSpringGainPercentage.Text = prof.defaultSpringGainPercentage.ToString();
			this.damperGainPercentage.Text = prof.damperGainPercentage.ToString();

			this.forceFeebackEnable.Checked = prof.forceFeedbackEnable;
			this.combinedPedalsEnable.Checked = prof.combinedPedalsEnable;
			this.persistentSpringEnable.Checked = prof.persistentSpringEnable;
			this.gameSettingsEnable.Checked = prof.gameSettingsEnable;
		}
		
		void SaveClick(object sender, EventArgs e)
		{
			Profile profile = this.getSelectedProfile();
			
			if (profile == null) {
				return;
			}
			
			this.enableProfile(profile);
		}
		
		private void enableProfile(Profile profile)
		{
			RegistryMap registry = new RegistryMap();
			
			if (registry.setActiveProfile(profile)) {
				MessageBox.Show("Success!", "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				MessageBox.Show("Failure!", "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void MainFormResize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized) {
				this.Hide();
				this.ShowInTaskbar = false;
			}
		}
		
		void NotifyIcon1DoubleClick(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.ShowInTaskbar = true;
		}
		
		void ShowToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.ShowInTaskbar = true;
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
	
}
