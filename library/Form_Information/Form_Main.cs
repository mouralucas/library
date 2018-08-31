using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Library.Forms_Insert;
using Library.DB_Manager;
using Library.Entities;
using Library.Connection;

namespace Library.Form_Information
{
    public partial class Form_Main : Form
    {
        Conn Conn = new Conn();
        DB_Author db_author = new DB_Author();

        List<Author> listAuthors = new List<Author>();

        Form_AuthorInsert Author_insert = null;
        Form_BookInsert Book_insert = null;
        Form_CountryInsert Country_insert = null;
        Form_PublisherInsert Publisher_insert = null;
        Form_GenreInsert Genre_insert = null;
        Form_LanguageInsert LanguageInsert = null;
        Form_SerieInsert SerieInsert = null;

        public Form_Main()
        {
            InitializeComponent();

            Conn.OpenConn();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            listAuthors = db_author.ListAllAuthors(Conn.Connection);

            //slot1.Image = Image.FromStream(new MemoryStream(listAuthors[0].AuthorPhoto));
            //slot2.Image = Image.FromStream(new MemoryStream(listAuthors[1].AuthorPhoto));
            //slot3.Image = Image.FromStream(new MemoryStream(listAuthors[2].AuthorPhoto));
            //slot4.Image = Image.FromStream(new MemoryStream(listAuthors[3].AuthorPhoto));
            //slot5.Image = Image.FromStream(new MemoryStream(listAuthors[4].AuthorPhoto));
            //slot6.Image = Image.FromStream(new MemoryStream(listAuthors[5].AuthorPhoto));
            //slot7.Image = Image.FromStream(new MemoryStream(listAuthors[6].AuthorPhoto));
            //slot8.Image = Image.FromStream(new MemoryStream(listAuthors[7].AuthorPhoto));
            //slot9.Image = Image.FromStream(new MemoryStream(listAuthors[8].AuthorPhoto));
            //slot10.Image = Image.FromStream(new MemoryStream(listAuthors[9].AuthorPhoto));
            //slot11.Image = Image.FromStream(new MemoryStream(listAuthors[10].AuthorPhoto));
            //slot12.Image = Image.FromStream(new MemoryStream(listAuthors[11].AuthorPhoto));
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author_insert = new Form_AuthorInsert(this) { Visible = true };
            this.Visible = false;
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_insert = new Form_BookInsert(this) { Visible = true };
            this.Visible = false;
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Country_insert = new Form_CountryInsert(this) { Visible = true };
            this.Visible = false;
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publisher_insert = new Form_PublisherInsert(this) { Visible = true };
            this.Visible = false;
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genre_insert = new Form_GenreInsert(this) { Visible = true };
            this.Visible = false;
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageInsert = new Form_LanguageInsert(this) { Visible = true };
            this.Visible = false;
        }

        private void serieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerieInsert = new Form_SerieInsert(this) { Visible = true };
            this.Visible = false;
        }
    }
}
