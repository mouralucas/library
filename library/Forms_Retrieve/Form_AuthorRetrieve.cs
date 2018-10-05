using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Connection;
using Library.DB_Manager;
using Library.Entities;


namespace Library.Forms_Retrieve
{
    public partial class Form_AuthorRetrieve : Form
    {
        Conn Conn = new Conn();

        DB_Author DB_Author = new DB_Author();
        DB_Country DB_Country = new DB_Country();
        DB_Language DB_Language = new DB_Language();

        Form ReturnGeneric = null;

        private List<Country> CountryList;
        private List<Language> LanguageList;
        private List<Author> AuthorList = new List<Author>();

        private int Search_id;
        private string searchName;
        private int searchCountry;
        private int searchLanguage;

        public Form_AuthorRetrieve()
        {
            InitializeComponent();
            Conn.OpenConn();
        }

        /*** Constructor from Main Form ***/
        public Form_AuthorRetrieve(Form ReturnForm)
        {
            InitializeComponent();
            Conn.OpenConn();

            this.ReturnGeneric = ReturnForm;
        }

        private void Form_AuthorRetrieve_Load(object sender, EventArgs e)
        {
            CountryList = DB_Country.ListAll(Conn.Connection);
            foreach (Country c in CountryList)
            {
                if (c.ShowCountry.Equals("Yes"))
                {
                    Box_Country.Items.Add(c.CountryName);
                }
            }
            Box_Country.Items.Add("Show All");

            LanguageList = DB_Language.SearchAllLanguages(Conn.Connection);
            foreach (Language l in LanguageList)
            {
                if (l.ShowLanguage.Equals("Yes"))
                {
                    Box_Language.Items.Add(l.LanguageName);
                }
            }
            Box_Language.Items.Add("Show All");

            int count = DB_Author.CountRows(Conn.Connection);
            if (count > 1)
            {
                Label_AuthorCount.Text = "There are " + count + " authors registered.";
            }
            else if (count == 1)
            {
                Label_AuthorCount.Text = "There is " + count + " author registered.";
            }
            else
            {
                Label_AuthorCount.Text = "There are no registered authors.";
            }


        }

        private void Button_ListAllAuthorsClick(object sender, EventArgs e)
        {
            Table_Authors.Rows.Clear();
            AuthorList.Clear();
            AuthorList = DB_Author.ListAllAuthors(Conn.Connection);

            //fills the table
            foreach(Author a in AuthorList)
            {
                Table_Authors.Rows.Add(a.Author_Id, a.AuthorName, a.AuthorCountry.CountryName, a.AuthorLanguage.LanguageName);
            }

            //Enables the button to view and delete an author
            if (AuthorList.Count != 0)
            {
                Button_Detail.Enabled = true;
                Button_Delete.Enabled = true;
            }
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            Table_Authors.Rows.Clear();
            AuthorList.Clear();

            Search_id = (Text_Autor_id.Text.Equals("")) ? -1 : Convert.ToInt32(Text_Autor_id.Text);
            searchName = Text_AuthorName.Text;
            searchCountry = (Box_Country.SelectedItem == null) ? -1 : CountryList[Box_Country.SelectedIndex].Country_Id;
            searchLanguage = (Box_Language.SelectedItem == null) ? -1 : LanguageList[Box_Language.SelectedIndex].Language_Id;

            AuthorList = DB_Author.ListAuthorByAnyField(Search_id, searchName, searchCountry, searchLanguage, Conn.Connection);

            foreach (Author a in AuthorList)
            {
                Table_Authors.Rows.Add(a.Author_Id, a.AuthorName, a.AuthorCountry.CountryName, a.AuthorLanguage.LanguageName);
            }

            if (AuthorList.Count != 0)
            {
                Button_Detail.Enabled = true;
            }
            else
            {
                Button_Detail.Enabled = false;
            }
        }

        private void Button_detail_Click(object sender, EventArgs e)
        {

        }

        private void Button_clean_Click(object sender, EventArgs e)
        {
            Text_Autor_id.Text = "";
            Text_AuthorName.Text = "";

        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AuthorRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ReturnGeneric != null)
            {
                ReturnGeneric.Visible = true;
            }

            Conn.CloseConn();
        }
    }
}
