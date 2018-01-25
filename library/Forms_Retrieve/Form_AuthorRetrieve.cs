using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Connection;
using library.DB_Manager;
using library.Entities;


namespace library.Forms_Retrieve
{
    public partial class Form_AuthorRetrieve : Form
    {
        DB_Authors db_author = new DB_Authors();
        DB_Countries db_country = new DB_Countries();
        DB_Languages db_language = new DB_Languages();
        DB_Authors dba = new DB_Authors();
        Conn conn = new Conn();

        private List<Countries> countryList;
        private List<Languages> languageList;
        private List<Authors> authorList = new List<Authors>();

        private int search_id;
        private string searchName;
        private int searchCountry;
        private int searchLanguage;

        public Form_AuthorRetrieve()
        {
            InitializeComponent();
            conn.OpenConn();
        }

        private void Form_AuthorRetrieve_Load(object sender, EventArgs e)
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

            languageList = db_language.SearchAllLanguages(conn.Connection);
            foreach (Languages l in languageList)
            {
                if (l.ShowLanguage.Equals("Yes"))
                {
                    box_language.Items.Add(l.LanguageName);
                }
            }
            box_language.Items.Add("Show All");

            int count = db_author.Count(conn.Connection);
            if (count > 1)
            {
                label_authorCount.Text = "There are " + count + " authors registered.";
            }
            else if (count == 1)
            {
                label_authorCount.Text = "There is " + count + " author registered.";
            }
            else
            {
                label_authorCount.Text = "There are no registered authors.";
            }


        }

        private void button_retrieveAll_Click(object sender, EventArgs e)
        {
            table_authors.Rows.Clear();
            authorList.Clear();
            authorList = db_author.SearchAllAuthors(-1, "", -1, -1, 0, conn.Connection);

            //fills the table
            foreach(Authors a in authorList)
            {
                table_authors.Rows.Add(a.Author_id, a.AuthorName, a.AuthorCountry.CountryName, a.AuthorLanguage.LanguageName);
            }

            //Enables the button to view and delete an author
            if (authorList.Count != 0)
            {
                button_detail.Enabled = true;
                button_delete.Enabled = true;
            }
        }

        private void Form_AuthorRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }

        private void check_searchType_CheckedChanged(object sender, EventArgs e)
        {
            if (check_searchType.Checked)
            {
                check_searchType.Text = " Match All Fields";
                //mudar alguma variavel que chama a query correta
            }
            else
            {
                check_searchType.Text = "Match Any Field";
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            text_autor_id.Text = "";
            text_authorName.Text = "";

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            table_authors.Rows.Clear();
            authorList.Clear();

            search_id = (text_autor_id.Text.Equals("")) ? -1 : Convert.ToInt32(text_autor_id.Text);
            searchName = text_authorName.Text;
            searchCountry = (box_country.SelectedItem == null) ? -1 : countryList[box_country.SelectedIndex].Country_id;
            searchLanguage = (box_language.SelectedItem == null) ? -1 : languageList[box_language.SelectedIndex].Language_id;

            authorList = db_author.SearchAllAuthors(search_id, searchName, searchCountry, searchLanguage, 1, conn.Connection);

            foreach (Authors a in authorList)
            {
                table_authors.Rows.Add(a.Author_id, a.AuthorName, a.AuthorCountry.CountryName, a.AuthorLanguage.LanguageName);
            }

            if (authorList.Count != 0)
            {
                button_detail.Enabled = true;
            }
            else
            {
                button_detail.Enabled = false;
            }
        }

        private void button_detail_Click(object sender, EventArgs e)
        {

        }
    }
}
