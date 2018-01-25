using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Connection;
using library.DB_Manager;
using library.Entities;
using library.Forms_Insert;

namespace library.Forms_Retrieve
{
    public partial class Form_CountryRetrieve : Form
    {
        DB_Countries db_country = new DB_Countries();
        Conn conn = new Conn();

        private List<Countries> countryList = new List<Countries>();

        public Form_CountryRetrieve()
        {
            InitializeComponent();
            conn.OpenConn();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void button_retrieveAll_Click(object sender, EventArgs e)
        {
            table_countries.Rows.Clear();

            countryList.Clear();
            countryList = db_country.SearchAllCountries(conn.Connection);

            foreach(Countries c in countryList)
            {
                table_countries.Rows.Add(c.Country_id, c.CountryName, c.ShowCountry);
            }

            if (countryList.Count != 0)
            {
                button_edit.Enabled = true;
                button_delete.Enabled = true;
            }
        }

        private void Form_CountryRetrieve_Load(object sender, EventArgs e)
        {
            int count = db_country.Count(conn.Connection);
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

        private void button_edit_Click(object sender, EventArgs e)
        {
            Form_CountryInsert countryInsert = null;
            int selectedRow = table_countries.CurrentRow.Index;

            if(selectedRow < countryList.Count)
            {
                countryInsert = new Form_CountryInsert(countryList[selectedRow], this) { Visible = true };
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Select a Country to Edit", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_CountryRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }
    }
}
