using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Entities;
using Library.DB_Manager;
using Library.Connection;

namespace Library.Forms_Retrieve
{
    public partial class Form_BookRetrieve : Form
    {
        Conn Conn = new Conn();
        DB_Book DB_Book = new DB_Book();


        List<Book> BookList = new List<Book>();

        public Form_BookRetrieve()
        {
            InitializeComponent();
            Conn.OpenConn();
        }

        private void Form_BookRetrieve_Load(object sender, EventArgs e)
        {
            BookList = DB_Book.ListAll(Conn.Connection);
            foreach (Book b in BookList)
            {
                Table_Books.Rows.Add(b.Authors.AuthorName, b.Title, b.SubTitle, b.Serie.SerieName, b.Volume, b.Pages, b.Isbn, b.Publisher.PublisherName,
                    b.Format, b.CoverPrice);
            }
        }
    }
}
