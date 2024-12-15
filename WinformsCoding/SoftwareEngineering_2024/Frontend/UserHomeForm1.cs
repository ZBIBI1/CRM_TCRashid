﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using LiveCharts.Charts;
using LiveCharts.WinForms;

namespace SoftwareEngineering_2024
{
    public partial class UserHomeForm1 : Form
    {
        public UserHomeForm1()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            FormOpener.OpenUserDashboardPages(HomeBt, MembershipsBt, EventsBt, MyBookingsBt, SpaceBt, QueryBt);
        }

        private void Websitelb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opener.OpenLink("https://www.togetherculture.com");
        }

        private void LogOutBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }
    }
}
