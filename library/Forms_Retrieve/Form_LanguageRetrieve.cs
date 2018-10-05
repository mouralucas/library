using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DB_Manager;
using Library.Entities;
using Library.Connection;
using Library.Forms_Insert;

namespace Library.Forms_Retrieve
{
    public partial class Form_LanguageRetrieve : Form
    {
        DB_Language db_language = new DB_Language();
        Conn conn = new Conn();

        List<Language> languageList = new List<Language>();


        public Form_LanguageRetrieve()
        {
            InitializeComponent();
            conn.OpenConn();
        }


        private void button_retrieveAll_Click(object sender, EventArgs e)
        {
            table_languages.Rows.Clear();

            languageList.Clear();
            languageList = db_language.SearchAllLanguages(conn.Connection);

            foreach(Language l in languageList)
            {
                table_languages.Rows.Add(l.Language_Id, l.LanguageName, l.ShowLanguage);
            }

            if(languageList.Count != 0)
            {
                button_edit.Enabled = true;
            }
        }

        private void Form_LanguageRetrieve_Load(object sender, EventArgs e)
        {
            int count = db_language.Count(conn.Connection);
            if (count > 1)
            {
                label_languageCount.Text = "There are " + count + " db_language registered.";
            }
            else if (count == 1)
            {
                label_languageCount.Text = "There is " + count + " AuthorLanguage registered.";
            }
            else
            {
                label_languageCount.Text = "There are no registered AuthorLanguage.";
            }
        }

        private void Form_LanguageRetrieve_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.CloseConn();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Form_LanguageInsert languageInsert = null;
            int  selectedRow = table_languages.CurrentRow.Index;

            if (selectedRow < languageList.Count())
            {
                languageInsert = new Form_LanguageInsert(languageList[selectedRow], this) { Visible = true };
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Select a Language to Edit", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
