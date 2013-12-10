using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuickLinks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            HotKeyManager.RegisterHotKey(Keys.Q, KeyModifiers.Control);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);   
        }
        void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            Popup CustomCommand = new Popup();
            CustomCommand.Show();
            CustomCommand.Focus();
        }
        private void customCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popup CustomCommand = new Popup();
            CustomCommand.Show();
            CustomCommand.Focus();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Popup CustomCommand = new Popup();
            CustomCommand.Show();
            CustomCommand.Focus();
        }
        
        private void frontpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("reddit.com");
        }

        private void leagueoflegendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("/r/leagueoflegends");
        }

        private void askredditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("/r/AskReddit");
        }

        private void iamAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("/r/IamA");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void facepunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("fb");
        }

        private void facepunchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Parser.Parse("facepunch.com");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("twitter");
        }

        private void googleMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("https://play.google.com/music/listen");
        }

        private void spotifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("https://play.spotify.com/?utm_source=web-player&utm_campaign=bookmark");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parser.Parse("www.youtube.com/my_favorites");
        }
    }
}
