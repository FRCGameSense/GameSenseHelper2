﻿namespace GameSenseHelper2
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsSaveButton = new System.Windows.Forms.Button();
            this.settingsCancelButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsXsplitLocationBox = new System.Windows.Forms.TextBox();
            this.chatLogsLocationBox = new System.Windows.Forms.TextBox();
            this.chatLogBrowseButton = new System.Windows.Forms.Button();
            this.settingsBTLFolderLocationBox = new System.Windows.Forms.TextBox();
            this.settingsBTLFolderBrowseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsXsplitBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.twitterTab = new System.Windows.Forms.TabPage();
            this.twitterInstructionsLabel = new System.Windows.Forms.Label();
            this.twitterPinBox = new System.Windows.Forms.TextBox();
            this.twitterConnectbutton = new System.Windows.Forms.Button();
            this.twitterVerifyButton = new System.Windows.Forms.Button();
            this.otherTab = new System.Windows.Forms.TabPage();
            this.enableResetCheckBox = new System.Windows.Forms.CheckBox();
            this.resetSettingsButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.defaultHostsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.defaultGuestsBox = new System.Windows.Forms.TextBox();
            this.filesTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.twitterTab.SuspendLayout();
            this.otherTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsSaveButton
            // 
            this.settingsSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsSaveButton.Location = new System.Drawing.Point(343, 350);
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.settingsSaveButton.TabIndex = 0;
            this.settingsSaveButton.Text = "Save";
            this.settingsSaveButton.UseVisualStyleBackColor = true;
            this.settingsSaveButton.Click += new System.EventHandler(this.settingsSaveButton_Click);
            // 
            // settingsCancelButton
            // 
            this.settingsCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsCancelButton.Location = new System.Drawing.Point(262, 350);
            this.settingsCancelButton.Name = "settingsCancelButton";
            this.settingsCancelButton.Size = new System.Drawing.Size(75, 23);
            this.settingsCancelButton.TabIndex = 1;
            this.settingsCancelButton.Text = "Cancel";
            this.settingsCancelButton.UseVisualStyleBackColor = true;
            this.settingsCancelButton.Click += new System.EventHandler(this.settingsCancelButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // filesTab
            // 
            this.filesTab.Controls.Add(this.label1);
            this.filesTab.Controls.Add(this.settingsXsplitLocationBox);
            this.filesTab.Controls.Add(this.chatLogsLocationBox);
            this.filesTab.Controls.Add(this.chatLogBrowseButton);
            this.filesTab.Controls.Add(this.settingsBTLFolderLocationBox);
            this.filesTab.Controls.Add(this.settingsBTLFolderBrowseButton);
            this.filesTab.Controls.Add(this.label3);
            this.filesTab.Controls.Add(this.settingsXsplitBrowseButton);
            this.filesTab.Controls.Add(this.label2);
            this.filesTab.Location = new System.Drawing.Point(4, 22);
            this.filesTab.Name = "filesTab";
            this.filesTab.Padding = new System.Windows.Forms.Padding(3);
            this.filesTab.Size = new System.Drawing.Size(427, 318);
            this.filesTab.TabIndex = 0;
            this.filesTab.Text = "Files / Folders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "XSplit Location";
            // 
            // settingsXsplitLocationBox
            // 
            this.settingsXsplitLocationBox.Location = new System.Drawing.Point(8, 22);
            this.settingsXsplitLocationBox.Name = "settingsXsplitLocationBox";
            this.settingsXsplitLocationBox.Size = new System.Drawing.Size(333, 20);
            this.settingsXsplitLocationBox.TabIndex = 2;
            // 
            // chatLogsLocationBox
            // 
            this.chatLogsLocationBox.Location = new System.Drawing.Point(6, 127);
            this.chatLogsLocationBox.Name = "chatLogsLocationBox";
            this.chatLogsLocationBox.Size = new System.Drawing.Size(333, 20);
            this.chatLogsLocationBox.TabIndex = 5;
            // 
            // chatLogBrowseButton
            // 
            this.chatLogBrowseButton.Location = new System.Drawing.Point(345, 125);
            this.chatLogBrowseButton.Name = "chatLogBrowseButton";
            this.chatLogBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.chatLogBrowseButton.TabIndex = 7;
            this.chatLogBrowseButton.Text = "Browse";
            this.chatLogBrowseButton.UseVisualStyleBackColor = true;
            this.chatLogBrowseButton.Click += new System.EventHandler(this.chatLogsBrowseButton_Click);
            // 
            // settingsBTLFolderLocationBox
            // 
            this.settingsBTLFolderLocationBox.Location = new System.Drawing.Point(8, 71);
            this.settingsBTLFolderLocationBox.Name = "settingsBTLFolderLocationBox";
            this.settingsBTLFolderLocationBox.Size = new System.Drawing.Size(333, 20);
            this.settingsBTLFolderLocationBox.TabIndex = 5;
            // 
            // settingsBTLFolderBrowseButton
            // 
            this.settingsBTLFolderBrowseButton.Location = new System.Drawing.Point(347, 69);
            this.settingsBTLFolderBrowseButton.Name = "settingsBTLFolderBrowseButton";
            this.settingsBTLFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.settingsBTLFolderBrowseButton.TabIndex = 7;
            this.settingsBTLFolderBrowseButton.Text = "Browse";
            this.settingsBTLFolderBrowseButton.UseVisualStyleBackColor = true;
            this.settingsBTLFolderBrowseButton.Click += new System.EventHandler(this.settingsOverlaysBrowseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chat Logs Location";
            // 
            // settingsXsplitBrowseButton
            // 
            this.settingsXsplitBrowseButton.Location = new System.Drawing.Point(347, 20);
            this.settingsXsplitBrowseButton.Name = "settingsXsplitBrowseButton";
            this.settingsXsplitBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.settingsXsplitBrowseButton.TabIndex = 4;
            this.settingsXsplitBrowseButton.Text = "Browse";
            this.settingsXsplitBrowseButton.UseVisualStyleBackColor = true;
            this.settingsXsplitBrowseButton.Click += new System.EventHandler(this.settingsXsplitBrowseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GS Folder Location";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.filesTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.twitterTab);
            this.tabControl1.Controls.Add(this.otherTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 344);
            this.tabControl1.TabIndex = 9;
            // 
            // twitterTab
            // 
            this.twitterTab.Controls.Add(this.twitterInstructionsLabel);
            this.twitterTab.Controls.Add(this.twitterPinBox);
            this.twitterTab.Controls.Add(this.twitterConnectbutton);
            this.twitterTab.Controls.Add(this.twitterVerifyButton);
            this.twitterTab.Location = new System.Drawing.Point(4, 22);
            this.twitterTab.Name = "twitterTab";
            this.twitterTab.Padding = new System.Windows.Forms.Padding(3);
            this.twitterTab.Size = new System.Drawing.Size(427, 318);
            this.twitterTab.TabIndex = 1;
            this.twitterTab.Text = "Twitter";
            this.twitterTab.UseVisualStyleBackColor = true;
            // 
            // twitterInstructionsLabel
            // 
            this.twitterInstructionsLabel.AutoSize = true;
            this.twitterInstructionsLabel.Location = new System.Drawing.Point(3, 38);
            this.twitterInstructionsLabel.Name = "twitterInstructionsLabel";
            this.twitterInstructionsLabel.Size = new System.Drawing.Size(423, 13);
            this.twitterInstructionsLabel.TabIndex = 2;
            this.twitterInstructionsLabel.Text = "Authorize the app and enter the PIN you\'re shown in the box below.  Then click \"V" +
    "erify.\"";
            this.twitterInstructionsLabel.Visible = false;
            // 
            // twitterPinBox
            // 
            this.twitterPinBox.Location = new System.Drawing.Point(6, 64);
            this.twitterPinBox.Name = "twitterPinBox";
            this.twitterPinBox.Size = new System.Drawing.Size(100, 20);
            this.twitterPinBox.TabIndex = 1;
            // 
            // twitterConnectbutton
            // 
            this.twitterConnectbutton.Location = new System.Drawing.Point(6, 6);
            this.twitterConnectbutton.Name = "twitterConnectbutton";
            this.twitterConnectbutton.Size = new System.Drawing.Size(415, 23);
            this.twitterConnectbutton.TabIndex = 0;
            this.twitterConnectbutton.Text = "Get PIN";
            this.twitterConnectbutton.UseVisualStyleBackColor = true;
            this.twitterConnectbutton.Click += new System.EventHandler(this.twitterConnectbutton_Click);
            // 
            // twitterVerifyButton
            // 
            this.twitterVerifyButton.Enabled = false;
            this.twitterVerifyButton.Location = new System.Drawing.Point(112, 61);
            this.twitterVerifyButton.Name = "twitterVerifyButton";
            this.twitterVerifyButton.Size = new System.Drawing.Size(72, 23);
            this.twitterVerifyButton.TabIndex = 0;
            this.twitterVerifyButton.Text = "Verify";
            this.twitterVerifyButton.UseVisualStyleBackColor = true;
            this.twitterVerifyButton.Click += new System.EventHandler(this.twitterVerifyButton_Click);
            // 
            // otherTab
            // 
            this.otherTab.Controls.Add(this.enableResetCheckBox);
            this.otherTab.Controls.Add(this.resetSettingsButton);
            this.otherTab.Location = new System.Drawing.Point(4, 22);
            this.otherTab.Name = "otherTab";
            this.otherTab.Padding = new System.Windows.Forms.Padding(3);
            this.otherTab.Size = new System.Drawing.Size(427, 318);
            this.otherTab.TabIndex = 2;
            this.otherTab.Text = "Other";
            this.otherTab.UseVisualStyleBackColor = true;
            // 
            // enableResetCheckBox
            // 
            this.enableResetCheckBox.AutoSize = true;
            this.enableResetCheckBox.Location = new System.Drawing.Point(174, 17);
            this.enableResetCheckBox.Name = "enableResetCheckBox";
            this.enableResetCheckBox.Size = new System.Drawing.Size(131, 17);
            this.enableResetCheckBox.TabIndex = 2;
            this.enableResetCheckBox.Text = "Enable Settings Reset";
            this.enableResetCheckBox.UseVisualStyleBackColor = true;
            this.enableResetCheckBox.CheckedChanged += new System.EventHandler(this.enableResetCheckBox_CheckedChanged);
            // 
            // resetSettingsButton
            // 
            this.resetSettingsButton.Enabled = false;
            this.resetSettingsButton.Location = new System.Drawing.Point(9, 13);
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Size = new System.Drawing.Size(159, 23);
            this.resetSettingsButton.TabIndex = 0;
            this.resetSettingsButton.Text = "Reset All Settings";
            this.resetSettingsButton.UseVisualStyleBackColor = true;
            this.resetSettingsButton.Click += new System.EventHandler(this.resetSettingsButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.defaultGuestsBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.defaultHostsBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 318);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Hosts & Guests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // defaultHostsBox
            // 
            this.defaultHostsBox.AcceptsReturn = true;
            this.defaultHostsBox.Location = new System.Drawing.Point(8, 24);
            this.defaultHostsBox.Multiline = true;
            this.defaultHostsBox.Name = "defaultHostsBox";
            this.defaultHostsBox.Size = new System.Drawing.Size(158, 184);
            this.defaultHostsBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Default Hosts (one per line)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Default Guests (one per line)";
            // 
            // defaultGuestsBox
            // 
            this.defaultGuestsBox.AcceptsReturn = true;
            this.defaultGuestsBox.Location = new System.Drawing.Point(202, 24);
            this.defaultGuestsBox.Multiline = true;
            this.defaultGuestsBox.Name = "defaultGuestsBox";
            this.defaultGuestsBox.Size = new System.Drawing.Size(158, 184);
            this.defaultGuestsBox.TabIndex = 5;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(431, 385);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.settingsCancelButton);
            this.Controls.Add(this.settingsSaveButton);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.filesTab.ResumeLayout(false);
            this.filesTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.twitterTab.ResumeLayout(false);
            this.twitterTab.PerformLayout();
            this.otherTab.ResumeLayout(false);
            this.otherTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsSaveButton;
        private System.Windows.Forms.Button settingsCancelButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox settingsXsplitLocationBox;
        private System.Windows.Forms.TextBox settingsBTLFolderLocationBox;
        private System.Windows.Forms.Button settingsBTLFolderBrowseButton;
        private System.Windows.Forms.Button settingsXsplitBrowseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage twitterTab;
        private System.Windows.Forms.Label twitterInstructionsLabel;
        private System.Windows.Forms.TextBox twitterPinBox;
        private System.Windows.Forms.Button twitterConnectbutton;
        private System.Windows.Forms.Button twitterVerifyButton;
        private System.Windows.Forms.TabPage otherTab;
        private System.Windows.Forms.Button resetSettingsButton;
        private System.Windows.Forms.CheckBox enableResetCheckBox;
        private System.Windows.Forms.TextBox chatLogsLocationBox;
        private System.Windows.Forms.Button chatLogBrowseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox defaultGuestsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox defaultHostsBox;
    }
}