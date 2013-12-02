﻿using System;
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
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        private void Popup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.Run();
                this.Close();
            }
        }
        private void Run()
        {
            String Contents = textBox1.Text;
            String[] commands = Contents.Split('|');
            foreach(string cmd in commands){
                Parser.Parse(cmd);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.Run();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Run();
                this.Close();
        }
    }
}
