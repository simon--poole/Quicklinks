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
            this.button1 = new System.Windows.Forms.Button();
            this.redditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leagueoflegendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askredditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iamAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frontpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.redditToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 48);
            // 
            // customCommandToolStripMenuItem
            // 
            this.customCommandToolStripMenuItem.Name = "customCommandToolStripMenuItem";
            this.customCommandToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.customCommandToolStripMenuItem.Text = "Custom Command";
            this.customCommandToolStripMenuItem.Click += new System.EventHandler(this.customCommandToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // frontpageToolStripMenuItem
            // 
            this.frontpageToolStripMenuItem.Name = "frontpageToolStripMenuItem";
            this.frontpageToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.frontpageToolStripMenuItem.Text = "Frontpage";
            this.frontpageToolStripMenuItem.Click += new System.EventHandler(this.frontpageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 420);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customCommandToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem redditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frontpageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leagueoflegendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askredditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iamAToolStripMenuItem;
    }
}

