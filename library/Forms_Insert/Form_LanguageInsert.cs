using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.DB_Manager;
using library.Connection;
using library.Entities;
using library.Forms_Retrieve;

namespace library.Forms_Insert
{
    public partial class Form_LanguageInsert : Form
    {
        Conn conn = new Conn();
        DB_Languages dbl = new DB_Languages();
        Form_LanguageRetrieve returnForm = null;

        private bool insertOk = false;

        /*----- Constructor Default ------*/
        public Form_LanguageInsert()
        {
            InitializeComponent();
            box_showLanguage.SelectedIndex = 0;

            conn.OpenConn();
        }

        /*----- Constructor to Edit Language ------*/
        public Form_LanguageInsert(Languages language, Form_LanguageRetrieve returnForm)
        {
            InitializeComponent();
            conn.OpenConn();

            this.returnForm = returnForm;

            text_languageName.Text = language.LanguageName;
            box_showLanguage.SelectedItem = language.ShowLanguage;
        }

        private void button_saveLanguage_Click(object sender, EventArgs e)
        {
            if (text_languageName.Text != "") {
                insertOk = dbl.InsertLanguage(text_languageName.Text, box_showLanguage.SelectedItem.ToString(), conn.Connection);

                if (insertOk)
                {
                    text_languageName.Text = "";
                    box_showLanguage.SelectedIndex = 0;
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Name Field Must Be Filled In", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Form_LanguageInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            //return to the form who called this form, if there is
            if (returnForm != null)
            {
                returnForm.Visible = true;
            }
            conn.CloseConn();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            //return to the form who called this form, if there is
            if (returnForm != null)
            {
                returnForm.Visible = true;
            }
            this.Close();
        }
    }
}
