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

namespace library.Forms_Retrieve
{
    public partial class Form_SerieRetrieve : Form
    {
        Conn conn = new Conn();
        DB_Series db_serie = new DB_Series();

        private List<Series> serieList = new List<Series>();

        public Form_SerieRetrieve()
        {
            InitializeComponent();

            /*---- Open the connection with the database ----*/
            conn.OpenConn();
        }

        private void Form_SerieRetrieve_Load(object sender, EventArgs e)
        {
            int count = db_serie.Count(conn.Connection);
            if (count > 1)
            {
                label_serieCount.Text = "There are " + count + " series registered.";
            }
            else if (count == 1)
            {
                label_serieCount.Text = "There is " + count + " serie registered.";
            }
            else
            {
                label_serieCount.Text = "There are no registered series.";
            }
        }

        private void button_retrieveAll_Click(object sender, EventArgs e)
        {
            table_serie.Rows.Clear();
            serieList.Clear();
            serieList = db_serie.SearchSeries(-1, "", "", 0, conn.Connection);

            foreach(Series s in serieList)
            {
                table_serie.Rows.Add(s.Serie_id, s.SerieName, s.SerieVolumes, s.SerieType);
            }

            //Enables the button to view and delete an author
            if (serieList.Count != 0)
            {
                button_detail.Enabled = true;
                button_delete.Enabled = true;
            }

        }

        private void Form_SerieRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }
    }
}
