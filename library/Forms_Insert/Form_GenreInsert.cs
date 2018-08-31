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
using Library.Connection;
using Library.DB_Manager;
using Library.Entities;
using Library.Forms_Retrieve;

namespace Library.Forms_Insert
{
    public partial class Form_GenreInsert : Form
    {

        Conn conn = new Conn();
        DB_Genre db_genre = new DB_Genre();
        Form ReturnGeneric = null;
        Form_BookInsert ReturnBookInsert = null;


        private bool insertOk = false;

        public Form_GenreInsert()
        {
            InitializeComponent();
            conn.OpenConn();
        }

        /*----- Constructor to Edit Genre ------*/
        public Form_GenreInsert(Genre genre, Form returnForm)
        {
            InitializeComponent();
            conn.OpenConn();

            this.ReturnGeneric = returnForm;
            text_genreName.Text = genre.GenreName;
        }

        /*----- Constructor From Main Form ------*/
        public Form_GenreInsert(Form ReturnForm)
        {
            InitializeComponent();
            this.ReturnGeneric = ReturnForm;       //the form who invoked this form
            conn.OpenConn();
        }

        /*----- Constructor From Insert Book (to add new genres) ------*/
        public Form_GenreInsert(Form_BookInsert ReturnBookInsert)
        {
            InitializeComponent();
            this.ReturnBookInsert = ReturnBookInsert;  
            conn.OpenConn();
        }

        private void Button_Save_Click(object sender, EventArgs e)
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

        private void Form_GenreInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            //generic form return
            if (ReturnGeneric != null)
            {
                ReturnGeneric.Visible = true;
            }

            //insert book form return
            if(ReturnBookInsert != null)
            {
                ReturnBookInsert.UpdateGenreBox();
            }

            conn.CloseConn();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
