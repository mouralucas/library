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
    public partial class Form_AuthorInsert : Form
    {
        /*---- This call the default image in the AuthorPhoto ----*/
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AuthorInsert));
        MemoryStream ms = new MemoryStream();
        Conn conn = new Conn();
        DB_Country db_country = new DB_Country();
        DB_Language db_language = new DB_Language();
        DB_Author db_author = new DB_Author();

        Form ReturnGeneric = null;
        Form_BookInsert ReturnBookInsert = null;

        private List<Country> countryList;
        private List<Language> languageList;

        private bool insertOk = false;
        private byte[] imageBytes;

        /*
        O = insert
        1 = update
        */
        private int transactionType = 0;

        public Form_AuthorInsert()
        {
            InitializeComponent();

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_author.Image.Save(ms, picture_author.Image.RawFormat);
            imageBytes = ms.ToArray();
            ms.Close();

            conn.OpenConn();
        }

        /*----- Constructor From Main Form ------*/
        public Form_AuthorInsert(Form returnForm)
        {
            InitializeComponent();

            this.ReturnGeneric = returnForm;      

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_author.Image.Save(ms, picture_author.Image.RawFormat);
            imageBytes = ms.ToArray();
            ms.Close();

            conn.OpenConn();
        }

        /*----- Constructor From Book Inser ------*/
        public Form_AuthorInsert(Form_BookInsert ReturnBookInsert)
        {
            InitializeComponent();
            this.ReturnBookInsert = ReturnBookInsert;

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_author.Image.Save(ms, picture_author.Image.RawFormat);
            imageBytes = ms.ToArray();
            ms.Close();

            conn.OpenConn();
        }


        private void Form_AuthorIns_Load(object sender, EventArgs e)
        {
            countryList = db_country.SearchAllCountries(conn.Connection);
            foreach (Country c in countryList)
            {
                if (c.ShowCountry.Equals("Yes"))
                {
                    box_country.Items.Add(c.CountryName);
                }
            }
            box_country.Items.Add("Show All");

            languageList = db_language.SearchAllLanguages(conn.Connection);
            foreach (Language l in languageList)
            {
                if (l.ShowLanguage.Equals("Yes"))
                {
                    box_language.Items.Add(l.LanguageName);
                }
            }
            box_language.Items.Add("Show All");
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            if(transactionType == 0)
            {
                SaveTransaction();
            }
            else
            {
                MessageBox.Show("Esta operação veio de uma janela não prevista", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Box_language_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (box_language.SelectedIndex == box_language.Items.Count - 1)
            {
                box_language.Items.Clear();
                box_language.Items.Add("Language");
                foreach (Language l in languageList)
                {
                    box_language.Items.Add(l.LanguageName);
                }
                box_language.Items.Add("--");
                box_language.SelectedIndex = -1;
                box_language.Text = "Language";
            }
        }

        private void Picture_author_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"; // image filters  

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

        private void SaveTransaction()
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
                insertOk = db_author.InsertAuthor(text_authorName.Text,
                    text_authorAbout.Text,
                    countryList.Find(x => x.CountryName.Equals(box_country.SelectedItem)).Country_id,
                    languageList.Find(x => x.LanguageName.Equals(box_language.SelectedItem)).Language_id,
                    imageBytes,
                    conn.Connection);

                if (insertOk)
                {
                    text_authorName.Clear();
                    text_authorAbout.Clear();
                    box_country.SelectedIndex = -1;
                    box_country.Text = "Country";
                    box_language.SelectedIndex = -1;
                    box_language.Text = "Language";
                    picture_author.Image = ((System.Drawing.Image)(resources.GetObject("picture_author.Image")));
                }
            }
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AuthorIns_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReturnGeneric != null)
            {
                ReturnGeneric.Visible = true;
            }

            if(ReturnBookInsert != null)
            {
                ReturnBookInsert.UpdateAuthorBox();
            }
            conn.CloseConn();
        }
    }
}
