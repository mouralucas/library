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

namespace Library.Forms_Retrieve
{
    public partial class Form_SerieRetrieve : Form
    {
        Conn conn = new Conn();
        DB_Serie db_serie = new DB_Serie();

        private List<Serie> serieList = new List<Serie>();

        public Form_SerieRetrieve()
        {
            InitializeComponent();
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

        private void Button_retrieveAll_Click(object sender, EventArgs e)
        {
            table_serie.Rows.Clear();
            serieList.Clear();
            serieList = db_serie.ListAllSeries(conn.Connection);

            foreach(Serie s in serieList)
            {
                table_serie.Rows.Add(s.Serie_id, s.SerieName, s.SerieVolumes, s.SerieCategory);
            }

            //Enables the button to view and delete an author
            if (serieList.Count != 0)
            {
                button_detail.Enabled = true;
                button_delete.Enabled = true;
            }

        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            table_serie.Rows.Clear();
            serieList.Clear();
            serieList = db_serie.ListSeriesByCategory(1, conn.Connection);

            foreach (Serie s in serieList)
            {
                table_serie.Rows.Add(s.Serie_id, s.SerieName, s.SerieVolumes, s.SerieCategory);
            }
        }

        private void Form_SerieRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }
    }
}
