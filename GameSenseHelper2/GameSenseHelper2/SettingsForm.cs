using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Specialized;

namespace GameSenseHelper2
{
    public partial class SettingsForm : Form
    {
        xSplitHandler2 xsHandler;
        GSTwitterClient twitter;
        public SettingsForm()
        {
            InitializeComponent();
            xsHandler = new xSplitHandler2();
        }

        private void settingsXsplitBrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select the location of the XSplit installation folder.";
            folderBrowserDialog1.ShowNewFolderButton = false;

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                settingsXsplitLocationBox.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void settingsSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.XsplitInstallLocation = settingsXsplitLocationBox.Text;
            Properties.Settings.Default.GSFolderLocation = settingsBTLFolderLocationBox.Text;
            Properties.Settings.Default.chatLogsLocation = chatLogsLocationBox.Text;
            StringCollection hosts = new StringCollection();
            StringCollection guests = new StringCollection();
            hosts.AddRange(defaultHostsBox.Text.Replace("\r", "").Split('\n'));
            guests.AddRange(defaultGuestsBox.Text.Replace("\r", "").Split('\n'));
            Properties.Settings.Default.defaultHosts = hosts;
            Properties.Settings.Default.defaultGuests = guests;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();          
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settingsXsplitLocationBox.Text = Properties.Settings.Default.XsplitInstallLocation;
            settingsBTLFolderLocationBox.Text = Properties.Settings.Default.GSFolderLocation;
            chatLogsLocationBox.Text = Properties.Settings.Default.chatLogsLocation;

            string[] hosts = new string[Properties.Settings.Default.defaultHosts.Count];
            Properties.Settings.Default.defaultHosts.CopyTo(hosts, 0);

            string[] guests = new string[Properties.Settings.Default.defaultGuests.Count];
            Properties.Settings.Default.defaultGuests.CopyTo(guests, 0);

            defaultHostsBox.Text = String.Join("\r\n", hosts);
            defaultGuestsBox.Text = String.Join("\r\n", guests);
            if (Properties.Settings.Default.twitterVerified)
            {
                twitterConnectbutton.Enabled = false;
                twitterConnectbutton.Text = "Already Verified";
            }
        }

        private void settingsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsOverlaysBrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select the location of the GameSense folder.";
            folderBrowserDialog1.ShowNewFolderButton = false;

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                settingsBTLFolderLocationBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void chatLogsBrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select the location of the where to save chat logs.";
            folderBrowserDialog1.ShowNewFolderButton = false;

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                chatLogsLocationBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure? \n\nThis will overwrite all settings in streamcontrol.xml", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        xsHandler.moveStreamControlXMLToXsplitLocation(openFileDialog1.FileName);
                        MessageBox.Show("Success!\n\nstreamcontrol.xml succesfully overwritten.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to overwrite streamcontrol.xml. \n\n" + ex.Message);
                    }                    
                }
            }            
        }

        private void twitterConnectbutton_Click(object sender, EventArgs e)
        {
            twitter = new GSTwitterClient();
            twitter.getPIN();

            twitterInstructionsLabel.Visible = true;
            twitterVerifyButton.Enabled = true;
        }

        private void twitterVerifyButton_Click(object sender, EventArgs e)
        {
            twitter.Authenticate(twitterPinBox.Text);
            if (Properties.Settings.Default.twitterVerified)
            {
                twitterConnectbutton.Text = "Verified!";
                twitterVerifyButton.Enabled = false;
                twitterConnectbutton.Enabled = false;
            }
            else
            {
                twitterConnectbutton.Text = "Failed to Verify.";
                twitterVerifyButton.Enabled = true;
                twitterConnectbutton.Enabled = true;
                twitterPinBox.Clear();
            }
        }

        private void resetSettingsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset to default settings?",  "This cannot be undone.", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }
        }

        private void enableResetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            resetSettingsButton.Enabled = enableResetCheckBox.Checked;
        }


    }
}
