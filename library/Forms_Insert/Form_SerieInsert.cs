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

namespace Library.Forms_Insert
{
    public partial class Form_SerieInsert : Form
    {
        Conn Conn = new Conn();

        DB_Serie db_serie = new DB_Serie();
        DB_Category DB_Category = new DB_Category();

        List<Category> CategoryList = new List<Category>();

        Form ReturnForm;

        private bool insertOk = false;

        public Form_SerieInsert()
        {
            InitializeComponent();

            Conn.OpenConn();
        }

        /*----- Constructor From Main Form ------*/
        public Form_SerieInsert(Form ReturnForm)
        {
            InitializeComponent();

            this.ReturnForm = ReturnForm;       //the form who invoked this form

            Conn.OpenConn();
        }

        private void Form_SerieInsert_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 35; i++)
            {
                box_volumes.Items.Add(i);
            }

            UpdateCategoryBox();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (text_serieName.Text.Equals(""))
            {
                MessageBox.Show("You Must Enter a Name!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (box_volumes.SelectedIndex < 0)
            {
                MessageBox.Show("You Must Enter the Number of Volumes!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                insertOk = db_serie.InsertPublisher(text_serieName.Text, 
                    Convert.ToInt32(box_volumes.SelectedItem.ToString()), 
                    (int)Box_Category.SelectedValue,
                    text_serieSynopsis.Text, Conn.Connection);

                if (insertOk)
                {
                    text_serieName.Clear();
                    box_volumes.SelectedIndex = -1;
                    box_volumes.Text = "Volumes";
                    text_serieSynopsis.Clear();
                    Box_Category.SelectedIndex = 0;
                }
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_SerieInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReturnForm != null)
            {
                ReturnForm.Visible = true;
            }
            Conn.CloseConn();
        }

        /*** ***/
        public void UpdateCategoryBox()
        {
            CategoryList.Clear();
            CategoryList = DB_Category.ListAllCategories(Conn.Connection);

            Box_Category.DataSource = null;
            Box_Category.DataSource = CategoryList;
            Box_Category.ValueMember = "Category_Id";
            Box_Category.DisplayMember = "CategoryName";

            Box_Category.SelectedIndex = 0;
        }

    }
}
