namespace WindowsFormsApp4
{
    partial class windowApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowApplication));
            this.downloadButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2Label = new System.Windows.Forms.Label();
            this.ListBox1Label = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox3Label = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox4Label = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.onlineInfoButton = new System.Windows.Forms.Button();
            this.versionInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(12, 340);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(86, 32);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "FPSUnlock",
            "Mousefix",
            "Harta pe M",
            "Fast Weapon Switch",
            "Infinite Run",
            "Crosshair Resize",
            "Digital Info",
            "Auto Pin",
            "Online Faction Members",
            "Reconnect",
            "Rainbow Car",
            "Anti Crasher",
            "Money Info",
            "Auto Radio Off",
            "Custom Textdraw Creator",
            "AutoCorrector",
            "Texture Render"});
            this.listBox1.Location = new System.Drawing.Point(15, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 147);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // listBox2Label
            // 
            this.listBox2Label.AllowDrop = true;
            this.listBox2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2Label.AutoSize = true;
            this.listBox2Label.Location = new System.Drawing.Point(174, 8);
            this.listBox2Label.Name = "listBox2Label";
            this.listBox2Label.Size = new System.Drawing.Size(108, 13);
            this.listBox2Label.TabIndex = 3;
            this.listBox2Label.Text = "Mods List (.SF / .ASI)";
            this.listBox2Label.Click += new System.EventHandler(this.ListBox2Label_Click);
            // 
            // ListBox1Label
            // 
            this.ListBox1Label.AutoSize = true;
            this.ListBox1Label.Location = new System.Drawing.Point(12, 9);
            this.ListBox1Label.Name = "ListBox1Label";
            this.ListBox1Label.Size = new System.Drawing.Size(89, 13);
            this.ListBox1Label.TabIndex = 4;
            this.ListBox1Label.Text = "Mods List (CLEO)";
            this.ListBox1Label.Click += new System.EventHandler(this.ListBox1Label_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Rainbow Chat",
            "Change Skin",
            "Discord Plugin",
            "BulletTrack",
            "Fake FPS"});
            this.listBox2.Location = new System.Drawing.Point(175, 25);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(141, 147);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "SAMP 0.3.7 RC1",
            "SAMPFUNCS 5.4.1",
            "CLEO"});
            this.listBox3.Location = new System.Drawing.Point(337, 25);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(141, 147);
            this.listBox3.TabIndex = 6;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.ListBox3_SelectedIndexChanged);
            // 
            // listBox3Label
            // 
            this.listBox3Label.AutoSize = true;
            this.listBox3Label.Location = new System.Drawing.Point(334, 9);
            this.listBox3Label.Name = "listBox3Label";
            this.listBox3Label.Size = new System.Drawing.Size(57, 13);
            this.listBox3Label.TabIndex = 7;
            this.listBox3Label.Text = "Mandatory";
            this.listBox3Label.Click += new System.EventHandler(this.ListBox3Label_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Items.AddRange(new object[] {
            "SAMP Addon",
            "Alci\'s IMG Editor",
            "Spark IMG Editor",
            "TXD Workshop",
            "Automatic Gang Evidence"});
            this.listBox4.Location = new System.Drawing.Point(501, 25);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(141, 147);
            this.listBox4.TabIndex = 8;
            // 
            // listBox4Label
            // 
            this.listBox4Label.AutoSize = true;
            this.listBox4Label.Location = new System.Drawing.Point(498, 8);
            this.listBox4Label.Name = "listBox4Label";
            this.listBox4Label.Size = new System.Drawing.Size(38, 13);
            this.listBox4Label.TabIndex = 9;
            this.listBox4Label.Text = "Others";
            this.listBox4Label.Click += new System.EventHandler(this.ListBox4Label_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 188);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(81, 13);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Status: Inactive";
            this.statusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(104, 340);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(86, 32);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear all lists";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // onlineInfoButton
            // 
            this.onlineInfoButton.Location = new System.Drawing.Point(196, 340);
            this.onlineInfoButton.Name = "onlineInfoButton";
            this.onlineInfoButton.Size = new System.Drawing.Size(86, 32);
            this.onlineInfoButton.TabIndex = 16;
            this.onlineInfoButton.Text = "Online Info";
            this.onlineInfoButton.UseVisualStyleBackColor = true;
            this.onlineInfoButton.Click += new System.EventHandler(this.OnlineInfoButton_Click);
            // 
            // versionInfo
            // 
            this.versionInfo.AutoSize = true;
            this.versionInfo.Location = new System.Drawing.Point(622, 357);
            this.versionInfo.Name = "versionInfo";
            this.versionInfo.Size = new System.Drawing.Size(60, 13);
            this.versionInfo.TabIndex = 17;
            this.versionInfo.Text = "Version 1.0";
            this.versionInfo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // windowApplication
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(701, 379);
            this.Controls.Add(this.versionInfo);
            this.Controls.Add(this.onlineInfoButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.listBox4Label);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3Label);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ListBox1Label);
            this.Controls.Add(this.listBox2Label);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.downloadButton);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "windowApplication";
            this.Text = "B-Zone - Mods";
            this.Load += new System.EventHandler(this.WindowApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ListBox listBox1;
        protected System.Windows.Forms.Label listBox2Label;
        private System.Windows.Forms.Label ListBox1Label;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label listBox3Label;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label listBox4Label;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button onlineInfoButton;
        private System.Windows.Forms.Label versionInfo;
    }
}

