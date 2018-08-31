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
        private string RemoveById;
        private string Retrieve;
        private string CountString;

        /*----- Others Variables -----*/
        private int count = -1;

        private List<Author> AuthorList = new List<Author>();
        private Author author;
        private Country country;
        private Language language;

        public int Count(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM authors";
            MySqlCommand Command = new MySqlCommand(CountString, conn);

            count = Convert.ToInt32(Command.ExecuteScalar());

            return count;

        }

        /*----- Insert Query -----*/
        public bool InsertAuthor(string AuthorName, string AuthorAbout, int Country_id, int Language_id, byte[] AuthorPhoto, MySqlConnection Conn)
        {

            Insert = "INSERT INTO authors (authorName, authorAbout, country_id, language_id, authorPhoto, authorDateInsert) " +
                "VALUES (@name, @about, @country, @language, @photo, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(Insert, Conn);

                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@about", MySqlDbType.MediumText);
                cmd.Parameters.Add("@country", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@language", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@photo", MySqlDbType.MediumBlob);

                cmd.Parameters["@name"].Value = AuthorName;
                cmd.Parameters["@about"].Value = AuthorAbout;
                cmd.Parameters["@country"].Value = Country_id;
                cmd.Parameters["@language"].Value = Language_id;
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

        public List<Author> ListAuthorByAnyField(int id, string name, int country_id, int language_id, MySqlConnection Conn)
        {

            Retrieve = "SELECT a.*, c.*, l.* FROM authors a " +
                "LEFT JOIN countries c " +
                "   on a.country_id = c.country_id " +
                "LEFT JOIN languages l" +
                "    on a.language_id = l.language_id " +
                "WHERE a.author_id = @author_id " +
                "   OR a.authorName = @authorName " +
                "   OR a.country_id = @country_id " +
                "   OR a.language_id = @language_id " +
                "ORDER BY authorName";

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);
            Cmd.Parameters.Add("@author_id", MySqlDbType.Int16);
            Cmd.Parameters.Add("@authorName", MySqlDbType.VarChar, 45);
            Cmd.Parameters.Add("@country_id", MySqlDbType.Int16);
            Cmd.Parameters.Add("@language_id", MySqlDbType.Int16);

            Cmd.Parameters["@author_id"].Value = id;
            Cmd.Parameters["@authorName"].Value = name;
            Cmd.Parameters["@country_id"].Value = country_id;
            Cmd.Parameters["@language_id"].Value = language_id;

            SetAuthorData(Cmd);
            return AuthorList;
        }

        public List<Author> ListAllAuthors(MySqlConnection Conn)
        {
            Retrieve = "SELECT a.*, c.*, l.* FROM authors a " +
                   "LEFT JOIN countries c on a.country_id = c.country_id " +
                   "LEFT JOIN languages l on a.language_id = l.language_id " +
                   "ORDER BY authorName";

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
                /*----- Retrieve the country from the author -----*/
                country = new Country
                {
                    Country_id = Convert.IsDBNull(DataRead["country_id"]) ? -1 : Convert.ToInt32(DataRead["country_id"]),
                    CountryName = Convert.IsDBNull(DataRead["countryName"]) ? "" : DataRead["countryName"].ToString(),
                    ShowCountry = Convert.IsDBNull(DataRead["showCountry"]) ? "" : DataRead["showCountry"].ToString()
                };

                /*----- Retrieve the language from the author -----*/
                language = new Language
                {
                    Language_id = Convert.IsDBNull(DataRead["language_id"]) ? -1 : Convert.ToInt32(DataRead["language_id"]),
                    LanguageName = Convert.IsDBNull(DataRead["languageName"]) ? "" : DataRead["languageName"].ToString(),
                    ShowLanguage = Convert.IsDBNull(DataRead["showLanguage"]) ? "" : DataRead["showLanguage"].ToString()
                };

                /*----- Retrieve the author itself-----*/
                author = new Author
                {
                    Author_id = Convert.IsDBNull(DataRead["author_id"]) ? -1 : Convert.ToInt32(DataRead["author_id"]),
                    AuthorName = Convert.IsDBNull(DataRead["authorName"]) ? "" : DataRead["authorName"].ToString(),
                    AuthorAbout = Convert.IsDBNull(DataRead["authorAbout"]) ? "" : DataRead["authorAbout"].ToString(),
                    AuthorCountry = country,
                    AuthorLanguage = language,
                    AuthorPhoto = Convert.IsDBNull(DataRead["authorPhoto"]) ? null : (byte[])DataRead["authorPhoto"]
                };

                AuthorList.Add(author);
            }

            DataRead.Close();
        }

    }
}
