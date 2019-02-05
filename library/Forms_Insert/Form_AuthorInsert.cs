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
using Library.Forms_Retrieve;

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
        Form_AuthorRetrieve ReturnAuthorRetrieve = null;

        private List<Country> CountryList = new List<Country>();
        private List<Language> LanguageList = new List<Language>();
        private List<Category> CategoryList = new List<Category>();

        private bool InsertOk = false;
        private byte[] ImageBytes;

        /*** Update Variables ***/
        private int CurrentAuthor_Id;
        private String OldAuthorName;
        private String OldAuthorAbout;
        private int OldAuthorCountry_Id;
        private int OldAuthorCategory_Id;
        private Byte[] OldAuthorPhoto;



        /*
        O = insert
        1 = update
        */
        private int TransactionType = 0;

        /*** Default Constructor ***/
        public Form_AuthorInsert()
        {
            InitializeComponent();
            Conn.OpenConn();
            LoadData();

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            Picture_Author.Image.Save(ms, Picture_Author.Image.RawFormat);
            ImageBytes = ms.ToArray();
            ms.Close();
        }

        /****** Constructor from Main Form ******/
        public Form_AuthorInsert(Form returnForm)
        {
            InitializeComponent();
            Conn.OpenConn();
            LoadData();

            this.ReturnGeneric = returnForm;      

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            Picture_Author.Image.Save(ms, Picture_Author.Image.RawFormat);
            ImageBytes = ms.ToArray();
            ms.Close();
        }

        /****** Constructor from Book Insert ******/
        public Form_AuthorInsert(Form_BookInsert ReturnBookInsert)
        {
            InitializeComponent();
            Conn.OpenConn();
            LoadData();

            this.ReturnBookInsert = ReturnBookInsert;

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            Picture_Author.Image.Save(ms, Picture_Author.Image.RawFormat);
            ImageBytes = ms.ToArray();
            ms.Close();
        }

        /****** Constructor for Update ******/
        public Form_AuthorInsert(Form_AuthorRetrieve ReturnAuthorRetrieve, Author EditAuthor)
        {
            InitializeComponent();
            Conn.OpenConn();
            LoadData();

            this.TransactionType = 1;
            this.ReturnAuthorRetrieve = ReturnAuthorRetrieve;
            Button_Transaction.Text = "Atualizar";

            this.CurrentAuthor_Id = EditAuthor.Author_Id;
            this.OldAuthorName = EditAuthor.AuthorName;
            this.OldAuthorAbout = EditAuthor.AuthorAbout;
            this.OldAuthorCountry_Id = EditAuthor.AuthorCountry.Country_Id;
            this.OldAuthorCategory_Id = EditAuthor.AuthorCategory.Category_Id;
            this.OldAuthorPhoto = EditAuthor.AuthorPhoto;

            Text_AuthorName.Text = OldAuthorName;
            Text_AuthorAbout.Text = OldAuthorAbout;
            Box_Country.SelectedValue = OldAuthorCountry_Id;
            Box_Category.SelectedValue = OldAuthorCategory_Id;
            Picture_Author.Image = Image.FromStream(new MemoryStream(OldAuthorPhoto));


        }

        public void LoadData()
        {
            GetCountryData();
            GetCategoryData();
        }

        private void Form_AuthorInsert_Load(object sender, EventArgs e)
        {
            //GetCountryData();
            //GetCategoryData();
        }

        private void Button_Transaction_Click(object sender, EventArgs e)
        {
            if(TransactionType == 0)
            {
                SaveTransaction();
            }
            else if(TransactionType == 1)
            {
                UpdateTransaction();
            }
            else
            {
                MessageBox.Show("Esta operação veio de uma janela não prevista", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Box_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {

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
                Picture_Author.Image = Image.FromFile(open.FileName);                // display image in picture box 

                /*---- Convert the image to a byte array ----*/
                MemoryStream ms = new MemoryStream();
                Picture_Author.Image.Save(ms, Picture_Author.Image.RawFormat);
                ImageBytes = ms.ToArray();
                ms.Close();
            }
        }

        /*** Closing form operations ***/
        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AuthorIns_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReturnGeneric != null)
            {
                ReturnGeneric.Visible = true;
            }

            if (ReturnBookInsert != null)
            {
                ReturnBookInsert.GetAuthorData();
            }

            if(ReturnAuthorRetrieve != null)
            {
                ReturnAuthorRetrieve.GetAuthorData();
            }

            Conn.CloseConn();
        }

        /*** Transaction Operations ***/
        private void SaveTransaction()
        {
            if (Box_Country.SelectedIndex < 0)
            {
                MessageBox.Show("Você deve escolher um País", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Text_AuthorName.Text.Equals(""))
            {
                MessageBox.Show("Digite o nome!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsertOk = DB_Author.InsertAuthor(Text_AuthorName.Text,
                    Text_AuthorAbout.Text,
                    (int)Box_Country.SelectedValue,
                    (int)Box_Category.SelectedValue,
                    ImageBytes,
                    Conn.Connection);

                if (InsertOk)
                {
                    Text_AuthorName.Clear();
                    Text_AuthorAbout.Clear();
                    Box_Country.SelectedIndex = -1;
                    Box_Country.Text = "Country";
                    Box_Category.SelectedIndex = 0;
                    Picture_Author.Image = ((System.Drawing.Image)(resources.GetObject("picture_author.Image")));
                }
            }
        }
        
        private void UpdateTransaction()
        {
            if(Text_AuthorName.Text.Length == 0)
            {
                MessageBox.Show("O nome do autor deve ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if((Text_AuthorName.Equals(OldAuthorName)) 
                    && ((int)Box_Country.SelectedValue == OldAuthorCountry_Id)
                    && ((int)Box_Category.SelectedValue == OldAuthorCategory_Id)
                    && (Text_AuthorAbout.Equals(OldAuthorAbout)))
                {

                }
            }
        }

        /*** Comboboxes Setup ***/
        public void GetCategoryData()
        {
            CategoryList.Clear();
            CategoryList = DB_Category.ListAll(Conn.Connection);
            SetCategoryBox();
        }

        private void SetCategoryBox()
        {
            Box_Category.DataSource = null;
            Box_Category.DataSource = CategoryList;
            Box_Category.ValueMember = "Category_Id";
            Box_Category.DisplayMember = "CategoryName";
        }
       
        public void GetCountryData()
        {
            CountryList.Clear();
            CountryList = DB_Country.ListAll(Conn.Connection);
            SetCountryBox();

        }

        private void SetCountryBox()
        {
            Box_Country.DataSource = null;
            Box_Country.DataSource = CountryList;
            Box_Country.ValueMember = "Country_Id";
            Box_Country.DisplayMember = "CountryName";
        }
    }
}
