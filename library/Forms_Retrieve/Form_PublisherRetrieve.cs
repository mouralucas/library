﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.DB_Manager;
using library.Connection;
using library.Entities;

namespace library.Forms_Retrieve
{
    public partial class Form_PublisherRetrieve : Form
    {
        Conn conn = new Conn();
        DB_Publishers db_publusher = new DB_Publishers();
        DB_Countries db_country = new DB_Countries();

        private List<Publishers> publisherList = new List<Publishers>();
        private List<Countries> countryList;

        public Form_PublisherRetrieve()
        {
            InitializeComponent();
            conn.OpenConn();
        }

        private void Form_PublisherRetrieve_Load(object sender, EventArgs e)
        {
            countryList = db_country.SearchAllCountries(conn.Connection);
            foreach (Countries c in countryList)
            {
                if (c.ShowCountry.Equals("Yes"))
                {
                    box_country.Items.Add(c.CountryName);
                }
            }
            box_country.Items.Add("Show All");

            int count = db_publusher.Count(conn.Connection);
            if (count > 1)
            {
                label_publishersCount.Text = "There are " + count + " publishers registered.";
            }
            else if (count == 1)
            {
                label_publishersCount.Text = "There is " + count + " publisher registered.";
            }
            else
            {
                label_publishersCount.Text = "There are no registered publisher.";
            }
        }

        private void button_retrieveAll_Click(object sender, EventArgs e)
        {
            table_publishers.Rows.Clear();
            publisherList.Clear();
            publisherList = db_publusher.SearchAllPublishers(-1, "", -1, 0, conn.Connection);

            foreach(Publishers p in publisherList)
            {
                table_publishers.Rows.Add(p.Publisher_id, p.PublisherName, p.PublisherCountry.CountryName);
            }

            if(publisherList.Count != 0)
            {
                button_detail.Enabled = true;
                button_delete.Enabled = true;
            }
        }

        private void Form_PublisherRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }
    }
}
