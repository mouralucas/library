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
        Conn Conn = new Conn();
        DB_Country DB_Country = new DB_Country();
        DB_Language DB_Language = new DB_Language();
        DB_Category DB_Category = new DB_Category();
        DB_Author DB_Author = new DB_Author();

        Form ReturnGeneric = null;
        Form_BookInsert ReturnBookInsert = null;

        private List<Country> CountryList = new List<Country>();
        private List<Language> LanguageList = new List<Language>();
        private List<Category> CategoryList = new List<Category>();

        private bool InsertOk = false;
        private byte[] ImageBytes;

        /*
        O = insert
        1 = update
        */
        private int TransactionType = 0;

        public Form_AuthorInsert()
        {
            InitializeComponent();

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_author.Image.Save(ms, picture_author.Image.RawFormat);
            ImageBytes = ms.ToArray();
            ms.Close();

            Conn.OpenConn();
        }

        /*----- Constructor From Main Form ------*/
        public Form_AuthorInsert(Form returnForm)
        {
            InitializeComponent();

            this.ReturnGeneric = returnForm;      

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_author.Image.Save(ms, picture_author.Image.RawFormat);
            ImageBytes = ms.ToArray();
            ms.Close();

            Conn.OpenConn();
        }

        /*----- Constructor From Book Inser ------*/
        public Form_AuthorInsert(Form_BookInsert ReturnBookInsert)
        {
            InitializeComponent();
            this.ReturnBookInsert = ReturnBookInsert;

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_author.Image.Save(ms, picture_author.Image.RawFormat);
            ImageBytes = ms.ToArray();
            ms.Close();

            Conn.OpenConn();
        }


        private void Form_AuthorInsert_Load(object sender, EventArgs e)
        {

            UpdateCountryBox();
            UpdateLanguageBox();
            UpdateCategoryBox();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if(TransactionType == 0)
            {
                SaveTransaction();
            }
            else
            {
                MessageBox.Show("Esta operação veio de uma janela não prevista", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Box_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (Box_Country.SelectedIndex == Box_Country.Items.Count - 1)
            //{
            //    Box_Country.Items.Clear();
            //    Box_Country.Items.Add("Country");
            //    foreach (Country c in CountryList)
            //    {
            //        Box_Country.Items.Add(c.CountryName);
            //    }
            //    Box_Country.Items.Add("--");
            //    Box_Country.SelectedIndex = -1;
            //    Box_Country.Text = "Country";
            //}
        }

        private void Box_Language_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (Box_Language.SelectedIndex == Box_Language.Items.Count - 1)
            //{
            //    Box_Language.Items.Clear();
            //    Box_Language.Items.Add("Language");
            //    foreach (Language l in LanguageList)
            //    {
            //        Box_Language.Items.Add(l.LanguageName);
            //    }
            //    Box_Language.Items.Add("--");
            //    Box_Language.SelectedIndex = -1;
            //    Box_Language.Text = "Language";
            //}
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
                ImageBytes = ms.ToArray();
                ms.Close();
            }
        }

        private void SaveTransaction()
        {
            if (Box_Country.SelectedIndex < 0 || Box_Language.SelectedIndex < 0)
            {
                MessageBox.Show("You Must Select a Country and a Language!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (text_authorName.Text.Equals(""))
            {
                MessageBox.Show("You Must Enter a Name!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsertOk = DB_Author.InsertAuthor(text_authorName.Text,
                    text_authorAbout.Text,
                    (int)Box_Country.SelectedValue,
                    (int)Box_Language.SelectedValue,
                    (int)Box_Category.SelectedValue,
                    ImageBytes,
                    Conn.Connection);

                if (InsertOk)
                {
                    text_authorName.Clear();
                    text_authorAbout.Clear();
                    Box_Country.SelectedIndex = -1;
                    Box_Country.Text = "Country";
                    Box_Language.SelectedIndex = -1;
                    Box_Language.Text = "Language";
                    Box_Category.SelectedIndex = 0;
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
                ReturnBookInsert.GetAuthorInfo();
            }
            Conn.CloseConn();
        }


        /*** Combobox Operations ***/
        public void UpdateCategoryBox()
        {
            CategoryList.Clear();
            CategoryList = DB_Category.ListAllCategories(Conn.Connection);

            Box_Category.DataSource = CategoryList;
            Box_Category.ValueMember = "Category_Id";
            Box_Category.DisplayMember = "CategoryName";

        }

        public void UpdateLanguageBox()
        {
            LanguageList.Clear();
            LanguageList = DB_Language.SearchAllLanguages(Conn.Connection);

            var item = LanguageList.Find(x => x.Language_id == 1);
            LanguageList.Remove(item);
            LanguageList.Insert(0, item);
            LanguageList.Add(new Language() { Language_id = 50000, LanguageName = "Add New" });

            Box_Language.DataSource = LanguageList;
            Box_Language.ValueMember = "Language_id";
            Box_Language.DisplayMember = "LanguageName";

        }

        public void UpdateCountryBox()
        {
            CountryList.Clear();
            CountryList = DB_Country.SearchAllCountries(Conn.Connection);

            Box_Country.DataSource = CountryList;
            Box_Country.ValueMember = "Country_Id";
            Box_Country.DisplayMember = "CountryName";
        }
    }
}
