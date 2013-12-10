namespace QuickLinks
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.redditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frontpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leagueoflegendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askredditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iamAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facepunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facepunchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "QuickItems";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customCommandToolStripMenuItem,
            this.dToolStripMenuItem,
            this.redditToolStripMenuItem,
            this.sitesToolStripMenuItem,
            this.mediaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 126);
            // 
            // customCommandToolStripMenuItem
            // 
            this.customCommandToolStripMenuItem.Name = "customCommandToolStripMenuItem";
            this.customCommandToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.customCommandToolStripMenuItem.Text = "Custom Command";
            this.customCommandToolStripMenuItem.Click += new System.EventHandler(this.customCommandToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(189, 6);
            // 
            // redditToolStripMenuItem
            // 
            this.redditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frontpageToolStripMenuItem,
            this.leagueoflegendsToolStripMenuItem,
            this.askredditToolStripMenuItem,
            this.iamAToolStripMenuItem});
            this.redditToolStripMenuItem.Name = "redditToolStripMenuItem";
            this.redditToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.redditToolStripMenuItem.Text = "Reddit";
            // 
            // frontpageToolStripMenuItem
            // 
            this.frontpageToolStripMenuItem.Name = "frontpageToolStripMenuItem";
            this.frontpageToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.frontpageToolStripMenuItem.Text = "Frontpage";
            this.frontpageToolStripMenuItem.Click += new System.EventHandler(this.frontpageToolStripMenuItem_Click);
            // 
            // leagueoflegendsToolStripMenuItem
            // 
            this.leagueoflegendsToolStripMenuItem.Name = "leagueoflegendsToolStripMenuItem";
            this.leagueoflegendsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.leagueoflegendsToolStripMenuItem.Text = "leagueoflegends";
            this.leagueoflegendsToolStripMenuItem.Click += new System.EventHandler(this.leagueoflegendsToolStripMenuItem_Click);
            // 
            // askredditToolStripMenuItem
            // 
            this.askredditToolStripMenuItem.Name = "askredditToolStripMenuItem";
            this.askredditToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.askredditToolStripMenuItem.Text = "askreddit";
            this.askredditToolStripMenuItem.Click += new System.EventHandler(this.askredditToolStripMenuItem_Click);
            // 
            // iamAToolStripMenuItem
            // 
            this.iamAToolStripMenuItem.Name = "iamAToolStripMenuItem";
            this.iamAToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.iamAToolStripMenuItem.Text = "IamA";
            this.iamAToolStripMenuItem.Click += new System.EventHandler(this.iamAToolStripMenuItem_Click);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facepunchToolStripMenuItem,
            this.facepunchToolStripMenuItem1,
            this.twitterToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sitesToolStripMenuItem.Text = "Sites";
            // 
            // facepunchToolStripMenuItem
            // 
            this.facepunchToolStripMenuItem.Name = "facepunchToolStripMenuItem";
            this.facepunchToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.facepunchToolStripMenuItem.Text = "Facebook";
            this.facepunchToolStripMenuItem.Click += new System.EventHandler(this.facepunchToolStripMenuItem_Click);
            // 
            // facepunchToolStripMenuItem1
            // 
            this.facepunchToolStripMenuItem1.Name = "facepunchToolStripMenuItem1";
            this.facepunchToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.facepunchToolStripMenuItem1.Text = "Facepunch";
            this.facepunchToolStripMenuItem1.Click += new System.EventHandler(this.facepunchToolStripMenuItem1_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click);
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleMusicToolStripMenuItem,
            this.spotifyToolStripMenuItem,
            this.youtubeToolStripMenuItem});
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // googleMusicToolStripMenuItem
            // 
            this.googleMusicToolStripMenuItem.Name = "googleMusicToolStripMenuItem";
            this.googleMusicToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.googleMusicToolStripMenuItem.Text = "Google Music";
            this.googleMusicToolStripMenuItem.Click += new System.EventHandler(this.googleMusicToolStripMenuItem_Click);
            // 
            // spotifyToolStripMenuItem
            // 
            this.spotifyToolStripMenuItem.Name = "spotifyToolStripMenuItem";
            this.spotifyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spotifyToolStripMenuItem.Text = "Spotify";
            this.spotifyToolStripMenuItem.Click += new System.EventHandler(this.spotifyToolStripMenuItem_Click);
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.youtubeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(629, 294);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tray";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 341);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frontpageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leagueoflegendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askredditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iamAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facepunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facepunchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spotifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}

