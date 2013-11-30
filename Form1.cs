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
        }

        private void customCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Custom Command

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
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
