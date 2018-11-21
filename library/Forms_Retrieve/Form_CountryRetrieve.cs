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
using Library.Forms_Insert;

namespace Library.Forms_Retrieve
{
    public partial class Form_CountryRetrieve : Form
    {
        DB_Country db_country = new DB_Country();
        Conn conn = new Conn();

        private List<Country> List_Countries = new List<Country>();

        public Form_CountryRetrieve()
        {
            InitializeComponent();
            conn.OpenConn();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void Button_ListAll_Click(object sender, EventArgs e)
        {
            Table_Countries.Rows.Clear();

            List_Countries.Clear();
            List_Countries = db_country.ListAll(conn.Connection);

            foreach(Country c in List_Countries)
            {
                Table_Countries.Rows.Add(c.Country_Id, c.CountryName, c.ShowCountry);
            }

            if (List_Countries.Count != 0)
            {
                button_edit.Enabled = true;
                button_delete.Enabled = true;
            }
        }

        private void Form_CountryRetrieve_Load(object sender, EventArgs e)
        {
            int count = db_country.CountRows(conn.Connection);
            if (count > 1)
            {
                label_countriesCount.Text = "There are " + count + " countries registered.";
            }
            else if (count == 1)
            {
                label_countriesCount.Text = "There is " + count + " country registered.";
            }
            else
            {
                label_countriesCount.Text = "There are no registered country.";
            }
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Form_CountryInsert countryInsert = null;
            int SelectedRow = Table_Countries.CurrentRow.Index;

            if(SelectedRow < List_Countries.Count)
            {
                Country c = List_Countries.Find(x => x.Country_Id.ToString() == Table_Countries.Rows[Table_Countries.CurrentCell.RowIndex].Cells[0].Value.ToString());
                countryInsert = new Form_CountryInsert(c, this) { Visible = true };
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Select a Country to Edit", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_CountryRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }
    }
}
