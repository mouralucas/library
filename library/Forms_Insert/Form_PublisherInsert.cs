using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Connection;
using Library.Entities;
using Library.DB_Manager;

namespace Library.Forms_Insert
{
    public partial class Form_PublisherInsert : Form
    {
        /*---- This call the default image in the publisher logo ----*/
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PublisherInsert));
        Conn conn = new Conn();
        DB_Country db_country = new DB_Country();
        DB_Publisher db_publisher = new DB_Publisher();

        Form returnForm;

        private List<Country> countryList;

        private bool insertOk = false;
        private bool updateOk = false;
        private byte[] logoBytes;

        public Form_PublisherInsert()
        {
            InitializeComponent();

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_logo.Image.Save(ms, picture_logo.Image.RawFormat);
            logoBytes = ms.ToArray();
            ms.Close();

            /*---- Open the connection with the database ----*/
            conn.OpenConn();
        }

        /*----- Constructor From Main Form ------*/
        public Form_PublisherInsert(Form returnForm)
        {
            InitializeComponent();

            this.returnForm = returnForm;       //the form who invoked this form

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_logo.Image.Save(ms, picture_logo.Image.RawFormat);
            logoBytes = ms.ToArray();
            ms.Close();

            /*---- Open the connection with the database ----*/
            conn.OpenConn();
        }

        private void Form_PublisherInsert_Load(object sender, EventArgs e)
        {
            countryList = db_country.ListAll(conn.Connection);
            foreach (Country c in countryList)
            {
                if (c.ShowCountry.Equals("Yes"))
                {
                    box_country.Items.Add(c.CountryName);
                }
            }
            box_country.Items.Add("Show All");
        }

        private void picture_logo_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"; // image filters  

            if (open.ShowDialog() == DialogResult.OK)
            {
                picture_logo.Image = Image.FromFile(open.FileName);                // display image in picture box 

                /*---- Convert the image to a byte array ----*/
                MemoryStream ms = new MemoryStream();
                picture_logo.Image.Save(ms, picture_logo.Image.RawFormat);
                logoBytes = ms.ToArray();
                ms.Close();
            }
        }

        private void Box_country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (box_country.SelectedIndex == box_country.Items.Count - 1)
            {
                box_country.Items.Clear();
                box_country.Items.Add("Country");
                foreach (Country c in countryList)
                {
                    box_country.Items.Add(c.CountryName);
                }
                box_country.Items.Add("--");
                box_country.SelectedIndex = -1;
                box_country.Text = "Country";
            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            if (text_publisherName.Equals(""))
            {
                DialogResult dr = MessageBox.Show("Name Field Must Be Filled In", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(box_country.SelectedIndex < 0)
            {
                DialogResult dr = MessageBox.Show("You Must Select a Country", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                insertOk = db_publisher.InsertPublisher(text_publisherName.Text,
                    text_publisherAbout.Text,
                    countryList.Find(x => x.CountryName.Equals(box_country.SelectedItem)).Country_Id,
                    //countryList[box_country.SelectedIndex].Country_id, 
                    logoBytes,
                    conn.Connection);

                if (insertOk)
                {
                    text_publisherName.Text = "";
                    text_publisherAbout.Text = "";
                    box_country.SelectedIndex = -1;
                    box_country.Text = "Country";
                    picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_PublisherInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (returnForm != null)
            {
                returnForm.Visible = true;
            }
            conn.CloseConn();
        }

    }
}
