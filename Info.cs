﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        private void emailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            emailLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://vk.com/nee_gear");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
