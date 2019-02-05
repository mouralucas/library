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
    public partial class Form_SerieRetrieve : Form
    {
        Conn Conn = new Conn();
        DB_Serie DB_Serie = new DB_Serie();

        private List<Serie> List_Series = new List<Serie>();

        public Form_SerieRetrieve()
        {
            InitializeComponent();
            Conn.OpenConn();
        }

        private void Form_SerieRetrieve_Load(object sender, EventArgs e)
        {
            GetSerieData();

            int count = DB_Serie.CountRows(Conn.Connection);
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

        /*** Textboxes event ***/
        private void Text_SerieName_TextChanged(object sender, EventArgs e)
        {
            if (Text_SerieName.Text.Length == 0)
            {
                SetSerieTable(List_Series);
            }
            else
            {
                SetSerieTable(List_Series.FindAll(x => x.SerieName.ToLower().Contains(Text_SerieName.Text.ToLower())));
            }
        }

        /*** Buttons ***/
        private void Button_Detail_Click(object sender, EventArgs e)
        {
            Form_SerieInsert Serie_Insert = null;
            int SelectedRow = Table_Serie.CurrentRow.Index;

            if(SelectedRow > 0)
            {
                Serie s = List_Series.Find(x => x.Serie_Id.ToString() == Table_Serie.Rows[Table_Serie.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Serie_Insert = new Form_SerieInsert(this, s) { Visible = true};
            }
        }

        /*** Table operations ***/
        public void GetSerieData()
        {
            List_Series.Clear();
            List_Series = DB_Serie.ListAll(Conn.Connection);

            if (List_Series.Count > 0)
            {
                SetSerieTable(List_Series);
                Button_Detail.Enabled = true;
            }
            else
            {
                Button_Detail.Enabled = false;
            }
        }

        private void SetSerieTable(List<Serie> List)
        {
            Table_Serie.Rows.Clear();
            foreach (Serie s in List)
            {
                Table_Serie.Rows.Add(s.Serie_Id, s.SerieName, s.SerieVolumes, s.SerieCategory);
            }
        }

        /*** Closing events ***/
        private void Form_SerieRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conn.CloseConn();
        }

        /*** Comboboxes setup ***/
        public void GetCategory()
        {

        }
    }
}
