using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Library.Entities;
using System.Windows.Forms;

namespace Library.DB_Manager
{
    class DB_Author
    {
        /*----- Strings that defines the queries -----*/
        private string Insert;
        private string Update;
        private string RemoveById;
        private string Retrieve;
        private string CountString;

        /*----- Others Variables -----*/
        private int Count = -1;

        private List<Author> AuthorList = new List<Author>();
        private Author Author;
        private Country Country;
        private Category Category;

        public int CountRows(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM authors";
            MySqlCommand Command = new MySqlCommand(CountString, conn);

            Count = Convert.ToInt32(Command.ExecuteScalar());

            return Count;

        }

        /*----- Insert Query -----*/
        public bool InsertAuthor(string AuthorName, string AuthorAbout, int Country_id, int Category_Id, byte[] AuthorPhoto, MySqlConnection Conn)
        {

            Insert = "INSERT INTO authors (authorName, authorAbout, country_id, category_id, authorPhoto, authorDateInsert) " +
                "VALUES (@name, @about, @country, @category, @photo, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(Insert, Conn);

                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@about", MySqlDbType.MediumText);
                cmd.Parameters.Add("@country", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@category", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@photo", MySqlDbType.MediumBlob);

                cmd.Parameters["@name"].Value = AuthorName;
                cmd.Parameters["@about"].Value = AuthorAbout;
                cmd.Parameters["@country"].Value = Country_id;
                cmd.Parameters["@category"].Value = Category_Id;
                cmd.Parameters["@photo"].Value = AuthorPhoto;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Auhtor Inserted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    long LastIdInserted = cmd.LastInsertedId;
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Inserting Author!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
        }

        public bool UpdateAuthor(int Auhtor_Id, string NewAuthorName, string NewAuthorAbout, int NewCountry_id, int NewCategory_Id, 
            byte[] NewAuthorPhoto, MySqlConnection Conn)
        {
            Update = "UPDATE authors SET " +
                "authorName = @newAuthorName, " +
                "authorAbout = @newAuthorAbout, " +
                "country_Id = @newCountry, " +
                "category_id = @newCategory, " +
                "authorPhoto = @newAuthorPhoto, " +
                "authorDateUpdate = current_timestamp() " +
                "WHERE author_id = @author_id";


            try
            {
                MySqlCommand cmd = new MySqlCommand(Update, Conn);

                cmd.Parameters.Add("@author_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@newAuthorName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@newAuthorAbout", MySqlDbType.MediumText);
                cmd.Parameters.Add("@newCountry", MySqlDbType.Int32);
                cmd.Parameters.Add("@newCategory", MySqlDbType.Int32);
                cmd.Parameters.Add("@newAuthorPhoto", MySqlDbType.MediumBlob);

                cmd.Parameters["@author_id"].Value = Auhtor_Id;
                cmd.Parameters["@newAuthorName"].Value = NewAuthorName;
                cmd.Parameters["@newAuthorAbout"].Value = NewAuthorAbout;
                cmd.Parameters["@newCountry"].Value = NewCountry_id;
                cmd.Parameters["@newCategory"].Value = NewCategory_Id;
                cmd.Parameters["@newAuthorPhoto"].Value = NewAuthorPhoto;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Autor Atualizado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Erro ao atualizar cadastro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }


        }

        /*----- Delete Queries -----*/
        public bool RemoveAuthorById(int author_id, MySqlConnection conn)
        {

            RemoveById = "DELETE FROM authors WHERE author_id = @author_id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(RemoveById, conn);

                cmd.Parameters.Add("@author_id", MySqlDbType.Int16, 11);
                cmd.Parameters["@author_id"].Value = author_id;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Auhtor Deleted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Deleting Author!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
        }

        public List<Author> ListAll(MySqlConnection Conn)
        {
            Retrieve = "SELECT a.*, c.*, l.*, cat.* FROM authors a "
                    + "LEFT JOIN countries c "
                    + "    on a.country_id = c.country_id "
                    + "LEFT JOIN languages l "
                    + "    on a.language_id = l.language_id "
                    + "LEFT JOIN category cat "
                    + "     ON a.category_id = cat.category_id "    
                    + "ORDER BY authorName";

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);
            SetAuthorData(Cmd);
            return AuthorList;
        }

        private void SetAuthorData(MySqlCommand Cmd)
        {
            MySqlDataReader DataRead = Cmd.ExecuteReader();
            AuthorList.Clear();

            while (DataRead.Read())
            {
                Country = new Country
                {
                    Country_Id = Convert.IsDBNull(DataRead["country_id"]) ? -1 : Convert.ToInt32(DataRead["country_id"]),
                    CountryName = Convert.IsDBNull(DataRead["countryName"]) ? "" : DataRead["countryName"].ToString(),
                    ShowCountry = Convert.IsDBNull(DataRead["showCountry"]) ? "" : DataRead["showCountry"].ToString()
                };

                Category = new Category()
                {
                    Category_Id = Convert.IsDBNull(DataRead["category_id"]) ? -1 : Convert.ToInt32(DataRead["category_id"]),
                    CategoryName = Convert.IsDBNull(DataRead["category"]) ? "" : DataRead["category"].ToString(),
                    Description = Convert.IsDBNull(DataRead["description"]) ? "" : DataRead["description"].ToString()
                };

                Author = new Author
                {
                    Author_Id = Convert.IsDBNull(DataRead["author_id"]) ? -1 : Convert.ToInt32(DataRead["author_id"]),
                    AuthorName = Convert.IsDBNull(DataRead["authorName"]) ? "" : DataRead["authorName"].ToString(),
                    AuthorAbout = Convert.IsDBNull(DataRead["authorAbout"]) ? "" : DataRead["authorAbout"].ToString(),
                    AuthorCountry = Country,
                    AuthorCategory = Category,
                    AuthorPhoto = Convert.IsDBNull(DataRead["authorPhoto"]) ? null : (byte[])DataRead["authorPhoto"]
                };

                AuthorList.Add(Author);
            }

            DataRead.Close();
        }

    }
}
