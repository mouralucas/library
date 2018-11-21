using System;
using System.Collections.Generic;
using System.IO;
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
using Library.Forms_Retrieve;


namespace Library.Forms_Insert
{
    public partial class Form_CountryInsert : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CountryInsert));
        Conn conn = new Conn();
        DB_Country dbc = new DB_Country();
        Form ReturnForm = null;

        private bool insertOk = false;
        private bool updateOk = false;
        private byte[] flagBytes;

        /*----- Variables to check if the values was change to edit -----*/
        private int currentCountry_id;
        private string oldName;
        private string oldShowCountry;
        private Byte[] flag;

        public Form_CountryInsert()
        {
            InitializeComponent();

            box_showCountry.SelectedIndex = 0;
            button_edit.Visible = false;
            button_delete.Visible = false;

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_flag.Image.Save(ms, picture_flag.Image.RawFormat);
            flagBytes = ms.ToArray();
            ms.Close();

            /*---- Open the connection with the database ----*/
            conn.OpenConn();
        }

        /*----- Constructor to Edit Countries ------*/
        public Form_CountryInsert(Country country, Form returnForm)
        {
            InitializeComponent();

            button_save.Visible = false;        //
            label_title.Text = "Edit Country";  //indicates that this form is editing.

            this.ReturnForm = returnForm;       //the form who invoked the edition

            /*---- Old values to check if a change was made ----*/
            currentCountry_id = country.Country_Id;
            oldName = country.CountryName;
            oldShowCountry = country.ShowCountry;
            flag = country.CountryFlag;

            /*---- Set the fields with the values of the selected genre ----*/
            text_id.Text = currentCountry_id.ToString();
            text_countryName.Text = oldName;
            box_showCountry.SelectedItem = oldShowCountry;

            picture_flag.Image = Image.FromStream(new MemoryStream(flag));

            /*---- Open the connection with the database ----*/
            conn.OpenConn();
        }

        /*----- Constructor From Main Form ------*/
        public Form_CountryInsert(Form ReturnForm)
        {
            InitializeComponent();

            this.ReturnForm = ReturnForm;       //the form who invoked this form

            box_showCountry.SelectedIndex = 0;
            button_edit.Visible = false;
            button_delete.Visible = false;

            /*---- Get the default image ----*/
            MemoryStream ms = new MemoryStream();
            picture_flag.Image.Save(ms, picture_flag.Image.RawFormat);
            flagBytes = ms.ToArray();
            ms.Close();

            /*---- Open the connection with the database ----*/
            conn.OpenConn();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (text_countryName.Text.Equals(""))
            {

                DialogResult dr = MessageBox.Show("Name Field Must Be Filled In", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                insertOk = dbc.InsertCountry(text_countryName.Text, box_showCountry.SelectedItem.ToString(), flagBytes, conn.Connection);

                if (insertOk)
                {
                    text_countryName.Text = "";
                    box_showCountry.SelectedIndex = 0;
                    picture_flag.Image = ((System.Drawing.Image)(resources.GetObject("picture_flag.Image")));
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (flagBytes == null && text_countryName.Text.Equals(oldName) && box_showCountry.SelectedItem.ToString().Equals(oldShowCountry))
            {
                MessageBox.Show("No Change Made");
            }
            else
            {
                if(flagBytes != null)
                {
                    flag = flagBytes;
                }

                dbc.UpdateCountry(currentCountry_id, text_countryName.Text, box_showCountry.SelectedItem.ToString(), flag, conn.Connection);
            }
        }

        private void picture_flag_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"; // image filters  

            if (open.ShowDialog() == DialogResult.OK)
            {
                picture_flag.Image = Image.FromFile(open.FileName);                // display image in picture box 

                /*---- Convert the image to a byte array ----*/
                MemoryStream ms = new MemoryStream();
                picture_flag.Image.Save(ms, picture_flag.Image.RawFormat);
                flagBytes = ms.ToArray();
                ms.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            //return to the form who called this form, if there is
            if (ReturnForm != null)
            {
                ReturnForm.Visible = true;
            }
            this.Close();
        }

        private void Form_CountryInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReturnForm != null)
            {
                ReturnForm.Visible = true;
            }
            conn.CloseConn();
        }
    }
}
