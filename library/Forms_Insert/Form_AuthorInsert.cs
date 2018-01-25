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
using library.Connection;
using library.Entities;
using library.DB_Manager;

namespace library.Forms_Insert
{
    public partial class Form_AuthorInsert : Form
    {
        /*---- This call the default image in the AuthorPhoto ----*/
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AuthorInsert));
        MemoryStream ms = new MemoryStream();
        Conn conn = new Conn();
        DB_Countries db_country = new DB_Countries();
        DB_Languages languages = new DB_Languages();
        DB_Authors dba = new DB_Authors();

        private List<Countries> countryList;
        private List<Languages> languageList;

        private bool insertOk = false;
        private byte[] imageBytes;

        public Form_AuthorInsert()
        {
            InitializeComponent();

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_author.Image.Save(ms, picture_author.Image.RawFormat);
            imageBytes = ms.ToArray();
            ms.Close();

            /*---- Open the connection with the database ----*/
            conn.OpenConn();
        }

        private void Form_AuthorIns_Load(object sender, EventArgs e)
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

            languageList = languages.SearchAllLanguages(conn.Connection);
            foreach (Languages l in languageList)
            {
                if (l.ShowLanguage.Equals("Yes"))
                {
                    box_language.Items.Add(l.LanguageName);
                }
            }
            box_language.Items.Add("Show All");
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            /*Validations*/
            if (box_country.SelectedIndex < 0 || box_language.SelectedIndex < 0)
            {
                MessageBox.Show("You Must Select a Country and a Language!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (text_authorName.Text.Equals(""))
            {
                MessageBox.Show("You Must Enter a Name!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                insertOk = dba.InsertAuthor(text_authorName.Text, text_authorAbout.Text,
                    countryList[box_country.SelectedIndex].Country_id,
                    languageList[box_language.SelectedIndex].Language_id, imageBytes,
                    conn.Connection);

                if (insertOk)
                {
                    text_authorName.Text = "";
                    text_authorAbout.Text = "";
                    box_country.SelectedIndex = -1;
                    box_country.Text = "Country";
                    box_language.SelectedIndex = -1;
                    box_language.Text = "Language";
                    picture_author.Image = ((System.Drawing.Image)(resources.GetObject("picture_author.Image")));
                }
            }
        }

        private void Form_AuthorIns_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }

        private void box_country_Click(object sender, MouseEventArgs e)
        {
            if(box_country.SelectedItem.Equals("Show All"))
            {
                box_country.Items.Clear();
                box_country.Items.Add("Country");
                foreach (Countries c in countryList)
                {
                    box_country.Items.Add(c.CountryName);
                }
                box_country.SelectedIndex = 0;
            }
        }

        private void box_language_Click(object sender, MouseEventArgs e)
        {
            if (box_language.SelectedItem.Equals("Show All"))
            {
                box_language.Items.Clear();
                box_language.Items.Add("Language");
                foreach (Languages l in languageList)
                {
                    box_language.Items.Add(l.LanguageName);
                }
                box_language.SelectedIndex = 0;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picture_author_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; // image filters  

            if (open.ShowDialog() == DialogResult.OK)
            {
                picture_author.Image = Image.FromFile(open.FileName);                // display image in picture box 

                /*---- Convert the image to a byte array ----*/
                MemoryStream ms = new MemoryStream();
                picture_author.Image.Save(ms, picture_author.Image.RawFormat);
                imageBytes = ms.ToArray();
                ms.Close();
            }
        }
    }
}
