using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DB_Manager;
using Library.Connection;
using Library.Entities;

namespace Library.Forms_Retrieve
{
    public partial class Form_PublisherRetrieve : Form
    {
        Conn Conn = new Conn();
        DB_Publisher db_publusher = new DB_Publisher();
        DB_Country db_country = new DB_Country();

        private List<Publisher> publisherList = new List<Publisher>();
        private List<Country> countryList;

        public Form_PublisherRetrieve()
        {
            InitializeComponent();
            Conn.OpenConn();
        }

        private void Form_PublisherRetrieve_Load(object sender, EventArgs e)
        {
            countryList = db_country.ListAll(Conn.Connection);
            foreach (Country c in countryList)
            {
                if (c.ShowCountry.Equals("Yes"))
                {
                    box_country.Items.Add(c.CountryName);
                }
            }
            box_country.Items.Add("Show All");

            int count = db_publusher.CountRows(Conn.Connection);
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

        private void Button_RetrieveAll_Click(object sender, EventArgs e)
        {
            table_publishers.Rows.Clear();
            publisherList.Clear();
            publisherList = db_publusher.ListAllPublishers(Conn.Connection);

            foreach(Publisher p in publisherList)
            {
                table_publishers.Rows.Add(p.Publisher_Id, p.PublisherName, p.PublisherCountry.CountryName);
            }

            if(publisherList.Count != 0)
            {
                button_detail.Enabled = true;
                button_delete.Enabled = true;
            }
        }

        private void Form_PublisherRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conn.CloseConn();
        }
    }
}
