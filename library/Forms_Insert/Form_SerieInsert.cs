using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Forms_Retrieve;
using Library.Connection;
using Library.DB_Manager;
using Library.Entities;

namespace Library.Forms_Insert
{
    public partial class Form_SerieInsert : Form
    {
        Conn Conn = new Conn();

        DB_Serie DB_Serie = new DB_Serie();
        DB_Category DB_Category = new DB_Category();

        List<Category> List_Category = new List<Category>();

        Form ReturnGeneric = null;
        Form_BookInsert ReturnBookInsert = null;
        Form_SerieRetrieve ReturnSerieRetrieve = null;

        /*** Update variables ***/
        private int Serie_Id;
        private String OldSerieName;
        private int OldSerieVolumes;
        private int OldSerieCategory_Id;
        private String OldSerieSynopsis;

        /*
        O = insert
        1 = update
        */
        private int TransactionType = 0;
        private bool InsertOk = false;


        public Form_SerieInsert()
        {
            InitializeComponent();

            Conn.OpenConn();
        }

        /*** Constructor from main form ***/
        public Form_SerieInsert(Form ReturnForm)
        {
            InitializeComponent();
            Conn.OpenConn();
            LoadData();

            this.ReturnGeneric = ReturnForm;               
        }

        /*** Constructor from book insert ***/
        public Form_SerieInsert(Form_BookInsert ReturnBookInsert)
        {
            InitializeComponent();
            Conn.OpenConn();
            LoadData();

            this.ReturnBookInsert = ReturnBookInsert;       
        }

        /*** Constructor for update ***/
        public Form_SerieInsert(Form_SerieRetrieve ReturnSerieRetrieve, Serie EditSerie)
        {
            InitializeComponent();
            Conn.OpenConn();
            LoadData();

            this.TransactionType = 1;
            this.ReturnSerieRetrieve = ReturnSerieRetrieve;
            Button_Transaction.Text = "Atualizar";

            this.Serie_Id = EditSerie.Serie_Id;
            this.OldSerieName = EditSerie.SerieName;
            this.OldSerieVolumes = EditSerie.SerieVolumes;
            this.OldSerieCategory_Id = EditSerie.SerieCategory_id;
            this.OldSerieSynopsis = EditSerie.SerieSynopsis;

            Text_SerieName.Text = OldSerieName;
            Text_Volumes.Text = OldSerieVolumes.ToString();
            Box_Category.SelectedValue = OldSerieCategory_Id;
            Text_SerieSynopsis.Text = OldSerieSynopsis;
        }

        private void Form_SerieInsert_Load(object sender, EventArgs e)
        {
        }

        public void LoadData()
        {
            GetCategoryData();
        }

        /*** Buttons ***/
        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Text_SerieName.Text.Equals(""))
            {
                MessageBox.Show("You Must Enter a Name!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (Text_Volumes.Text.Length == 0)
            {
                MessageBox.Show("You Must Enter the Number of Volumes!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsertOk = DB_Serie.InsertSerie(Text_SerieName.Text, 
                    Convert.ToInt32(Text_Volumes.Text), 
                    (int)Box_Category.SelectedValue,
                    Text_SerieSynopsis.Text, Conn.Connection);

                if (InsertOk)
                {
                    Text_SerieName.Clear();
                    Text_Volumes.Clear();
                    Text_SerieSynopsis.Clear();
                    Box_Category.SelectedIndex = 0;
                }
            }
        }

        /*** Closing event ***/
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Form_SerieInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReturnGeneric != null)
            {
                ReturnGeneric.Visible = true;
            }

            if(ReturnBookInsert != null)
            {
                ReturnBookInsert.GetSerieInfo();
            }

            if(ReturnSerieRetrieve != null)
            {
                ReturnSerieRetrieve.GetSerieData();
            }

            Conn.CloseConn();
        }

        /*** Combobox setup ***/
        public void GetCategoryData()
        {
            List_Category.Clear();
            List_Category = DB_Category.ListAll(Conn.Connection);
            SetCategoryBox();
        }

        private void SetCategoryBox()
        {
            Box_Category.DataSource = null;
            Box_Category.DataSource = List_Category;
            Box_Category.ValueMember = "Category_Id";
            Box_Category.DisplayMember = "CategoryName";
        }

    }
}
