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
using Library.Entities;
using Library.Connection;
using Library.DB_Manager;

namespace Library.Forms_Insert
{
    public partial class Form_BookInsert : Form
    {
        Conn Conn = new Conn();

        /*---- This call the default image in the AuthorPhoto ----*/
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BookInsert));

        DB_Author DB_Author         = new DB_Author();
        DB_Language DB_Language     = new DB_Language();
        DB_Publisher DB_Publisher   = new DB_Publisher();
        DB_Genre DB_Genre           = new DB_Genre();
        DB_Book DB_Book             = new DB_Book();
        DB_Serie DB_Serie           = new DB_Serie();
        DB_Category DB_Category     = new DB_Category();

        Form ReturnGeneric;

        List<Author> AuthorList         = new List<Author>();
        List<Language> LanguageList     = new List<Language>();
        List<Publisher> PublisherList   = new List<Publisher>();
        List<Genre> GenreList           = new List<Genre>();
        List<Serie> SerieList           = new List<Serie>();
        List<Category> CategoryList     = new List<Category>();

        List<int> SelectedAuthors       = new List<int>();
        List<int> SelectedGenres        = new List<int>();

        Serie volumeUnico;

        private bool InsertOk = false;
        private byte[] ImageBytes;

        /*
        O = insert
        1 = update
        */
        private int transactionType = 0;

        public Form_BookInsert()
        {
            InitializeComponent();
            Conn.OpenConn();

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            Book_Cover.Image.Save(ms, Book_Cover.Image.RawFormat);
            ImageBytes = ms.ToArray();
            ms.Close();

            /*Criar um construtor para cada tipo de midia (livro, manga, hq) quando for chamado define as series 
              baseado no tipo */

        }

        /*----- Constructor From Main Form ------*/
        public Form_BookInsert(Form ReturnGeneric)
        {
            InitializeComponent();
            this.ReturnGeneric = ReturnGeneric;
            LoadContents();
        }

        private void LoadContents()
        {
            Conn.OpenConn();

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            Book_Cover.Image.Save(ms, Book_Cover.Image.RawFormat);
            ImageBytes = ms.ToArray();
            ms.Close();
        }

        private void Form_BookInsert_Load(object sender, EventArgs e)
        {
            GetCategoryInfo();
            GetAuthorData();
            GetGenreInfo();
            GetLanguageInfo();
            GetPublisherInfo();            
            GetSerieInfo();           
        }

        private void Button_Transaction_Click(object sender, EventArgs e)
        {
            if (transactionType == 0)
            {
                SaveTransaction();
            }
        }

        private void CheckBox_SameAsTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_SameAsTitle.Checked)
            {
                Text_OriginalTitle.Text = Text_Title.Text;
                Text_OriginalSubTitle.Text = Text_SublTitle.Text;

                Text_OriginalTitle.Enabled = false;
                Text_OriginalSubTitle.Enabled = false;
            }
            else
            {
                Text_OriginalTitle.Text = "";
                Text_OriginalSubTitle.Text = "";

                Text_OriginalTitle.Enabled = true;
                Text_OriginalSubTitle.Enabled = true;
            }
        }
        
        private void Text_Title_TextChanged(object sender, EventArgs e)
        {
            if (CheckBox_SameAsTitle.Checked)
            {
                Text_OriginalTitle.Text = Text_Title.Text;
            }
        }

        private void Text_SublTitle_TextChanged(object sender, EventArgs e)
        {
            if (CheckBox_SameAsTitle.Checked)
            {
                Text_OriginalSubTitle.Text = Text_SublTitle.Text;
            }
        }

        private void Box_Serie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int SelectedSerieId = (int)Box_Serie.SelectedValue;
            if(SelectedSerieId == 50000)
            {
                Form_SerieInsert SerieInsert = new Form_SerieInsert(this) { Visible = true };
                return;
            }

            Box_Volume.Items.Clear();
            int v = SerieList.Find(x => x.Serie_Id == (int)Box_Serie.SelectedValue).SerieVolumes;
            for (int i = 1; i <= v; i++)
            {
                Box_Volume.Items.Add(i);
            }
            Box_Volume.SelectedIndex = 0;

        }

        private void Box_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetSerieBox();
            SetAuthorBox();
            SetPublisherBox();
        }

        private void Box_Author_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int SelectedAuthorId = (int)Box_Author.SelectedValue;
            

            if (SelectedAuthorId == 0)
            {
                return;
            }

            if (SelectedAuthorId == 50000)
            {
                Form_AuthorInsert authorInsert = new Form_AuthorInsert(this) { Visible = true };
                return;
            }

            else if (!SelectedAuthors.Contains(SelectedAuthorId))
            {
                String SelectedAuthorName = AuthorList.Find(x => x.Author_Id == SelectedAuthorId).AuthorName;
                ListBox_Authors.Items.Add(SelectedAuthorName);
                SelectedAuthors.Add(SelectedAuthorId);
                Console.WriteLine();
            }
            else
            {
                MessageBox.Show("Este autor já foi selecionado");

            }
        }

        private void Button_RemoveAuthor_Click(object sender, EventArgs e)
        {
            int i = ListBox_Authors.SelectedIndex;
            if (i != -1)
            {
                ListBox_Authors.Items.RemoveAt(i);
                SelectedAuthors.RemoveAt(i);
            }
        }

        private void Box_Genre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int SelectedGenreId = (int)Box_Genre.SelectedValue;
            String SelectedGenreName = GenreList.Find(x => x.Genre_Id == SelectedGenreId).GenreName;

            if (SelectedGenreId == 0)
            {
                return;
            }

            if (SelectedGenreId == 50000)
            {

                Form_GenreInsert fgi = new Form_GenreInsert(this) { Visible = true};
                return;
            }

            if (!SelectedGenres.Contains(SelectedGenreId))
            {
                ListBox_Genres.Items.Add(SelectedGenreName);
                SelectedGenres.Add(SelectedGenreId);
            }
            else
            {
                MessageBox.Show("Este genero já foi selecionado!");

            }
        }

        private void Button_RemoveGenre_Click(object sender, EventArgs e)
        {
            int i = ListBox_Genres.SelectedIndex;
            if (i != -1)
            {
                ListBox_Genres.Items.RemoveAt(i);
                SelectedGenres.RemoveAt(i);
            }
        }

        private void Book_Cover_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png"; // image filters  

            if (open.ShowDialog() == DialogResult.OK)
            {
                Book_Cover.Image = Image.FromFile(open.FileName);                // display image in picture box 

                /*---- Convert the image to a byte array ----*/
                MemoryStream ms = new MemoryStream();
                Book_Cover.Image.Save(ms, Book_Cover.Image.RawFormat);
                ImageBytes = ms.ToArray();
                ms.Close();
            }
        }

        /*** Closing events ***/
        private void Form_BookInsert_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (ReturnGeneric != null)
            {
                ReturnGeneric.Visible = true;
            }
            Conn.CloseConn();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*** Transações com DB ***/
        private void SaveTransaction()
        {
            if (Text_Title.Text.Equals(""))
            {
                MessageBox.Show("You Must Enter a Title for the Book!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Box_Format.SelectedItem.ToString().Equals("e-Book") && Text_Isbn.Text.Equals(""))
            {
                MessageBox.Show("You Must Enter the ISBN for this format of Book!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ListBox_Authors.Items.Count == 0)
            {
                MessageBox.Show("You Must Enter the Author of the Book!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Text_Pages.Text.Equals(""))
            {
                MessageBox.Show("You Must Enter the Pages Number", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((int)Box_Publisher.SelectedValue == 0)
            {
                MessageBox.Show("Select a Publisher", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double coverPrice = Text_CoverPrice.Text.Equals("") ? 0.00 : Convert.ToDouble(Text_CoverPrice.Text.Replace(",", "."));

                InsertOk = DB_Book.InsertBook(
                    (int)Box_Category.SelectedValue, Text_Title.Text, Text_SublTitle.Text, Text_OriginalTitle.Text, Text_OriginalSubTitle.Text, Text_Isbn.Text,
                    Convert.ToInt32(Text_Pages.Text), (int)Box_Publisher.SelectedValue, (int)Box_Language.SelectedValue, Box_Format.SelectedItem.ToString(),
                    (int)Box_Serie.SelectedValue, Convert.ToInt32(Box_Volume.SelectedItem.ToString()), Date_ReleaseDate.Text, Box_Currency.SelectedItem.ToString(),
                    coverPrice, Convert.ToInt32(Text_Edition.Text), Box_Status.SelectedItem.ToString(), Box_ReadingStatus.SelectedItem.ToString(), 
                    Text_Observation.Text.ToString(), Text_Synopsis.Text.ToString(), ImageBytes, SelectedAuthors, SelectedGenres, Conn.Connection);

                if (InsertOk)
                {
                    //Box_Category.SelectedIndex = 0;
                    Text_Title.Text = "";
                    Text_SublTitle.Text = "";
                    Text_OriginalTitle.Text = "";
                    Text_OriginalSubTitle.Text = "";
                    Text_Isbn.Text = "";
                    Text_Pages.Text = "";
                    Box_Publisher.SelectedIndex = 0;
                    Box_Language.SelectedIndex = 0;
                    Box_Format.SelectedIndex = 0;
                    Box_Serie.SelectedIndex = 0;
                    Box_Volume.SelectedIndex = 0;
                    Date_ReleaseDate.Value = DateTime.Now;
                    Box_Currency.SelectedIndex = 0;
                    Text_CoverPrice.Text = "";
                    Text_Edition.Text = "1";
                    Box_Status.SelectedIndex = 0;
                    Box_ReadingStatus.SelectedIndex = 0;
                    Text_Observation.Text = "";
                    Text_Synopsis.Text = "";
                    Book_Cover.Image = ((System.Drawing.Image)(resources.GetObject("Book_Cover.Image")));

                    Box_Author.SelectedIndex = 0;
                    Box_Genre.SelectedIndex = 0;
                    ListBox_Authors.Items.Clear();
                    ListBox_Genres.Items.Clear();
                    SelectedAuthors.Clear();
                    SelectedGenres.Clear();
                }
            }
        }

        private void UpdateTransaction()
        {

        }

        /*** Validadores dos campos ***/
        private void Text_Edition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void Text_pages_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void Text_isbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        /*** Combobox setup ***/
        public void GetGenreInfo()
        {
            GenreList.Clear();
            GenreList = DB_Genre.ListAllGenres(Conn.Connection);
            SetGenreBox();       
        }

        private void SetGenreBox()
        {
            GenreList.Insert(0, new Genre() { Genre_Id = 0, GenreName = "Genre" });
            GenreList.Add(new Genre { Genre_Id = 50000, GenreName = "Adicionar novo gênero" });

            Box_Genre.DataSource = null;
            Box_Genre.DataSource = GenreList;
            Box_Genre.ValueMember = "Genre_id";
            Box_Genre.DisplayMember = "GenreName";

            Box_Genre.SelectedIndex = 0;
        }

        public void GetAuthorData()
        {
            AuthorList.Clear();
            AuthorList = DB_Author.ListAll(Conn.Connection);
            SetAuthorBox();

        }

        private void SetAuthorBox()
        {
            List<Author> aux = AuthorList.FindAll(x => x.AuthorCategory.Category_Id == (int)Box_Category.SelectedValue);
            aux.Insert(0, new Author() { Author_Id = 0, AuthorName = "Autor" });
            aux.Add(new Author() { Author_Id = 50000, AuthorName = "Adicionar novo" });

            Box_Author.DataSource = aux;
            Box_Author.ValueMember = "Author_id";
            Box_Author.DisplayMember = "AuthorName";
        }

        public void GetLanguageInfo()
        {
            LanguageList.Clear();
            LanguageList = DB_Language.SearchAllLanguages(Conn.Connection);

            var item = LanguageList.Find(x => x.Language_Id == 1);
            LanguageList.Remove(item);
            LanguageList.Insert(0, item);
            LanguageList.Add(new Language() { Language_Id = 50000, LanguageName = "Adicionar novo"});

            Box_Language.DataSource = null;
            Box_Language.DataSource = LanguageList;
            Box_Language.ValueMember = "Language_id";
            Box_Language.DisplayMember = "LanguageName";

            Box_Language.SelectedIndex = 0;
        }

        public void GetPublisherInfo()
        {
            PublisherList.Clear();
            PublisherList = DB_Publisher.ListAllPublishers(Conn.Connection);
            SetPublisherBox();
            
        }

        private void SetPublisherBox()
        {
            List<Publisher> aux = PublisherList.FindAll(x => x.PublisherCategory.Category_Id == (int)Box_Category.SelectedValue);
            aux.Insert(0, new Publisher() { Publisher_Id = 0, PublisherName = "Editora" });
            aux.Add(new Publisher() { Publisher_Id = 50000, PublisherName = "Adicionar nova" });

            //Box_Publisher.DataSource = null;
            Box_Publisher.DataSource = aux;
            Box_Publisher.ValueMember = "Publisher_Id";
            Box_Publisher.DisplayMember = "PublisherName";

            Box_Publisher.SelectedIndex = 0;
        }

        public void GetCategoryInfo()
        {
            CategoryList.Clear();
            CategoryList = DB_Category.ListAll(Conn.Connection);

            SetCategoryInfo();
        }

        private void SetCategoryInfo()
        {
            var Item = CategoryList.Find(x => x.Category_Id == 2);
            CategoryList.Remove(Item);
            CategoryList.Insert(0, Item);

            Box_Category.DataSource = null;
            Box_Category.DataSource = CategoryList;
            Box_Category.ValueMember = "Category_Id";
            Box_Category.DisplayMember = "CategoryName";

            Box_Category.SelectedIndex = 0;
        }

        public void GetSerieInfo()
        {
            SerieList.Clear();
            SerieList = DB_Serie.ListAllSeries(Conn.Connection);
            volumeUnico = SerieList.Find(x => x.SerieCategory_id == 1);
            SetSerieBox();

        }

        private void SetSerieBox()
        {
            List<Serie> aux = SerieList.FindAll(x => x.SerieCategory_id == (int)Box_Category.SelectedValue);
            aux.Insert(0, volumeUnico);
            aux.Add(new Serie() { Serie_Id = 50000, SerieName = "Adicionar nova"});

            Box_Serie.DataSource = aux;
            Box_Serie.ValueMember = "Serie_id";
            Box_Serie.DisplayMember = "SerieName";
        }

        /*** Eventos de Foco ***/
        private void Text_Isbn_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Ganhou foco");
            
        }
    }
}
