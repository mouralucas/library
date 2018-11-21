using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Forms_Insert;
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
        DB_Category DB_Category = new DB_Category();

        Form ReturnGeneric = null;

        private List<Country> List_Countries = new List<Country>();
        private List<Category> List_Categories = new List<Category>();
        private List<Author> List_Authors = new List<Author>();

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
            GetCountryData();
            GetCategoryData();
            GetAuthorData();

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

        /*** Comboboxes ***/
        private void Box_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetAuthorTable(List_Authors.FindAll(x => x.AuthorCountry.Country_Id == (int)Box_Country.SelectedValue));
        }

        private void Box_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetAuthorTable(List_Authors.FindAll(x => x.AuthorCategory.Category_Id == (int)Box_Category.SelectedValue));
        }

        /*** Textboxes event ***/
        private void Text_AuthorName_TextChanged(object sender, EventArgs e)
        {
            if (Text_AuthorName.Text.Length == 0)
            {
                SetAuthorTable(List_Authors);
            }
            else
            {
                SetAuthorTable(List_Authors.FindAll(x => x.AuthorName.ToLower().Contains(Text_AuthorName.Text.ToLower())));
            }
        }

        /*** Buttons ***/
        private void Button_Search_Click(object sender, EventArgs e)
        {

        }

        private void Button_Detail_Click(object sender, EventArgs e)
        {
            Form_AuthorInsert Author_Insert = null;
            int SelectedRow = Table_Authors.CurrentRow.Index;

            if (SelectedRow < List_Authors.Count)
            {
                Author a = List_Authors.Find(x => x.Author_Id.ToString() == Table_Authors.Rows[Table_Authors.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Author_Insert = new Form_AuthorInsert(this, a) { Visible = true };
            }
        }

        private void Button_Clean_Click(object sender, EventArgs e)
        {
            Text_AuthorName.Text = "";
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*** Closing events ***/
        private void Form_AuthorRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReturnGeneric != null)
            {
                ReturnGeneric.Visible = true;
            }

            Conn.CloseConn();
        }

        /*** Table operations ***/
        public void GetAuthorData()
        {
            List_Authors.Clear();
            List_Authors = DB_Author.ListAll(Conn.Connection);

            if (List_Authors.Count > 0)
            {
                SetAuthorTable(List_Authors);
                Button_Detail.Enabled = true;
            }
            else
            {
                Button_Detail.Enabled = false;
            }
        }

        private void SetAuthorTable(List<Author> List)
        {
            Table_Authors.Rows.Clear();
            foreach (Author a in List)
            {
                Table_Authors.Rows.Add(a.Author_Id, a.AuthorName, a.AuthorCountry.CountryName, a.AuthorCategory.CategoryName);
            }
        }

        /*** Comboboxes Setup ***/
        public void GetCountryData()
        {
            List_Countries.Clear();
            List_Countries = DB_Country.ListAll(Conn.Connection);
            SetCountryBox();
        }

        private void SetCountryBox()
        {
            Box_Country.DataSource = null;
            Box_Country.DataSource = List_Countries;
            Box_Country.DisplayMember = "CountryName";
            Box_Country.ValueMember = "Country_Id";
        }

        public void GetCategoryData()
        {
            List_Categories.Clear();
            List_Categories = DB_Category.ListAll(Conn.Connection);
            SetCategoryBox();
        }

        private void SetCategoryBox()
        {
            Box_Category.DataSource = null;
            Box_Category.DataSource = List_Categories;
            Box_Category.DisplayMember = "CategoryName";
            Box_Category.ValueMember = "Category_Id";
        }
    }
}
