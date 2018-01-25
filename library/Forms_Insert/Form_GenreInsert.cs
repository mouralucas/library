using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using library.Connection;
using library.DB_Manager;
using library.Entities;
using library.Forms_Retrieve;

namespace library.Forms_Insert
{
    public partial class Form_GenreInsert : Form
    {

        Conn conn = new Conn();
        DB_Genres db_genre = new DB_Genres();
        Form_GenreRetrieve returnForm = null;


        private bool insertOk = false;

        public Form_GenreInsert()
        {
            InitializeComponent();

            conn.OpenConn();
        }

        /*----- Constructor to Edit Language ------*/
        public Form_GenreInsert(Genres genre, Form_GenreRetrieve returnForm)
        {
            InitializeComponent();
            conn.OpenConn();

            this.returnForm = returnForm;

            text_genreName.Text = genre.GenreName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_genreName.Text != "")
            {
                insertOk = db_genre.InsertGenre(text_genreName.Text, conn.Connection);

                if (insertOk)
                {
                    text_genreName.Text = "";
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Name Field Must Be Filled In", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Form_GenreInsert_Load(object sender, EventArgs e)
        {

        }

        private void Form_GenreInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            //return to the form who called this form, if there is
            if (returnForm != null)
            {
                returnForm.Visible = true;
            }
            conn.CloseConn();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            //return to the form who called this form, if there is
            if (returnForm != null)
            {
                returnForm.Visible = true;
            }
            this.Close();
        }
    }
}
