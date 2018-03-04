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
using library.Entities;
using library.Connection;
using library.DB_Manager;

namespace library.Forms_Insert
{
    public partial class Form_BookInsert : Form
    {
        Conn conn = new Conn();
        DB_Authors db_author = new DB_Authors();
        DB_Languages db_language = new DB_Languages();
        DB_Publishers db_publisher = new DB_Publishers();

        List<Authors> authorList = new List<Authors>();
        List<Languages> languageList = new List<Languages>();
        List<Publishers> publisherList = new List<Publishers>();

        private byte[] imageBytes;

        public Form_BookInsert()
        {
            InitializeComponent();
            /*---- Open the connection with the database ----*/
            conn.OpenConn();

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_author.Image.Save(ms, picture_author.Image.RawFormat);
            imageBytes = ms.ToArray();
            ms.Close();
        }

        private void Form_BookInsert_Load(object sender, EventArgs e)
        {
            authorList = db_author.SearchAllAuthors(-1, "", -1, -1, 0, conn.Connection);
            foreach (Authors a in authorList)
            {
                box_authors.Items.Add(a.AuthorName);
            }

            languageList = db_language.SearchAllLanguages(conn.Connection);
            foreach (Languages l in languageList)
            {
                if (l.ShowLanguage.Equals("Yes"))
                {
                    box_language.Items.Add(l.LanguageName);
                }
            }
            box_language.Items.Add("Show All");

            publisherList = db_publisher.SearchAllPublishers(-1, "", -1, 0, conn.Connection);
            foreach (Publishers p in publisherList)
            {
                box_publisher.Items.Add(p.PublisherName);
            }
        }

        private void checkBox_sameAsTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sameAsTitle.Checked)
            {
                text_OriginalTitle.Text = text_title.Text;
                text_originalSubTitle.Text = text_sublTitle.Text;
            }
            else
            {
                text_OriginalTitle.Text = "";
                text_originalSubTitle.Text = "";
            }
        }


        private void text_title_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_sameAsTitle.Checked)
            {
                text_OriginalTitle.Text = text_title.Text;
            }
        }

        private void text_sublTitle_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_sameAsTitle.Checked)
            {
                text_originalSubTitle.Text = text_sublTitle.Text;
            }
        }

        private void box_authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_authors.FindStringExact(box_authors.SelectedItem.ToString()) == -1)
            {
                listBox_authors.Items.Add(box_authors.SelectedItem);
            }
            else
            {
                MessageBox.Show("You Already Selected This Author");
                
            }
        }



        

        private void button_removeAuthor_Click(object sender, EventArgs e)
        {
            listBox_authors.Items.Remove(listBox_authors.SelectedItem);
        }

        private void picture_author_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; // image filters  

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


    }
}
