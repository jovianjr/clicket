﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicket
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void populateItems()
        {
            MovieItemAdmin[] movieItems = new MovieItemAdmin[20];

            for (int i = 0; i < movieItems.Length; i++)
            {
                movieItems[i] = new MovieItemAdmin();
                movieItems[i].title = "Movie " + i.ToString();

                //if (flp_movie.Controls.Count > 0)
                //{
                //    flp_movie.Controls.Clear();
                //}
                //else
                flp_movie.Controls.Add(movieItems[i]);
            }

            EventItemAdmin[] eventItems = new EventItemAdmin[20];
            for (int i = 0; i < eventItems.Length; i++)
            {
                eventItems[i] = new EventItemAdmin();
                eventItems[i].title = "Event " + i.ToString();

                //if (flp_movie.Controls.Count > 0)
                //{
                //    flp_movie.Controls.Clear();
                //}
                //else
                flp_event.Controls.Add(eventItems[i]);
            }

            Transaction[] transaction = new Transaction[20];
            for (int i = 0; i < transaction.Length; i++)
            {
                transaction[i] = new Transaction();
                transaction[i].title = i.ToString();
                transaction[i].date = i.ToString();
                transaction[i].location = i.ToString();
                transaction[i].price = i.ToString();
                transaction[i].qty = i.ToString();
                transaction[i].total = i.ToString();
                transaction[i].status = "Status";

                flp_history.Controls.Add(transaction[i]);
            }
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            populateItems();
            flp_event.Visible = false;
            flp_history.Visible = false;
            btn_Movie.BackColor = Color.FromArgb(255, 195, 0);
            iconMovie.BackColor = Color.FromArgb(255, 195, 0);
        }
        private void btn_Movie_Click(object sender, EventArgs e)
        {
            flp_movie.Visible = true;
            flp_event.Visible = false;
            flp_history.Visible = false;

            lbTitle.Text = "#MOVIES";
            lbSubTitle.Text = "NOW SHOWING";

            btn_Movie.BackColor = iconMovie.BackColor = Color.FromArgb(255, 195, 0);

            btn_Event.BackColor = iconEvent.BackColor = Color.White;

            btnHistory.BackColor = iconHistory.BackColor = Color.White;
        }

        private void btn_Event_Click(object sender, EventArgs e)
        {
            flp_movie.Visible = false;
            flp_event.Visible = true;
            flp_history.Visible = false;

            lbTitle.Text = "#EVENTS";
            lbSubTitle.Text = "WILL BE HELD";

            btn_Movie.BackColor = iconMovie.BackColor = Color.White;

            btn_Event.BackColor = iconEvent.BackColor = Color.FromArgb(255, 195, 0);

            btnHistory.BackColor = iconHistory.BackColor = Color.White;
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            flp_movie.Visible = false;
            flp_event.Visible = false;
            flp_history.Visible = true;

            lbTitle.Text = "#HISTORY";
            lbSubTitle.Text = "TRANSACTION LIST";

            btn_Movie.BackColor = iconMovie.BackColor = Color.White;

            btn_Event.BackColor = iconEvent.BackColor = Color.White;

            btnHistory.BackColor = iconHistory.BackColor = Color.FromArgb(255, 195, 0);
        }

        private void iconEvent_Click(object sender, EventArgs e)
        {
            btn_Event.PerformClick();
        }

        private void iconMovie_Click(object sender, EventArgs e)
        {
            btn_Movie.PerformClick();
        }

        private void iconHistory_Click(object sender, EventArgs e)
        {
            btnHistory.PerformClick();
        }
    }
}
