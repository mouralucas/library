using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.DB_Manager;
using library.Entities;
using library.Connection;
using library.Forms_Insert;

namespace library.Forms_Retrieve
{
    public partial class Form_GenreRetrieve : Form
    {
        DB_Genres db_genre = new DB_Genres();
        Conn conn = new Conn();

        List<Genres> genreList = new List<Genres>();

        public Form_GenreRetrieve()
        {
            InitializeComponent();
            conn.OpenConn();
        }

        private void button_retrieveAll_Click(object sender, EventArgs e)
        {
            table_genres.Rows.Clear();

            genreList.Clear();
            genreList = db_genre.SearchAllGenres(conn.Connection);

            foreach(Genres g in genreList)
            {
                table_genres.Rows.Add(g.Genre_id.ToString(), g.GenreName);
            }

            if (genreList.Count != 0)
            {
                button_edit.Enabled = true;
            }
        }

        private void Form_GenreRetrieve_Load(object sender, EventArgs e)
        {
            int count = db_genre.Count(conn.Connection);
            if(count > 1){
                label_genresCount.Text = "There are " + count + " genres registered.";
            }
            else if(count == 1)
            {
                label_genresCount.Text = "There is " + count + " genre registered.";
            }
            else
            {
                label_genresCount.Text = "There are no registered genres.";
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            table_genres.Rows.Clear();
            text_Id.Text = "";
            text_Name.Text = "";
        }

        private void table_languages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void Form_GenreRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Form_GenreInsert genreInsert = null;
            int selectedRow = table_genres.CurrentRow.Index;

            if (selectedRow < genreList.Count())
            {
                genreInsert = new Form_GenreInsert(genreList[selectedRow], this) { Visible = true};
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Select a Genre to Edit", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
