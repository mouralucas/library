using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using library.Entities;
using System.Windows.Forms;

namespace library.DB_Manager
{
    class DB_Authors
    {
        /*----- Strings that defines the queries -----*/
        private string insert;
        private string removeById;
        private string retrieve;
        private string countString;

        /*----- Others Variables -----*/
        private int count = -1;

        private List<Authors> authorList = new List<Authors>();
        private Authors author;
        private Countries country;
        private Languages language;

        public int Count(MySqlConnection conn)
        {
            countString = "SELECT COUNT(*) FROM authors";
            MySqlCommand cmd = new MySqlCommand(countString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;

        }

        /*----- Insert Query -----*/
        public bool InsertAuthor(string authorName, string authorAbout, int country_id, int language_id, byte[] authorPhoto, MySqlConnection conn)
        {

            insert = "INSERT INTO authors (authorName, authorAbout, country_id, language_id, authorPhoto, authorDateInsert) " +
                "VALUES (@name, @about, @country, @language, @photo, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(insert, conn);

                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@about", MySqlDbType.MediumText);
                cmd.Parameters.Add("@country", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@language", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@photo", MySqlDbType.MediumBlob);

                cmd.Parameters["@name"].Value = authorName;
                cmd.Parameters["@about"].Value = authorAbout;
                cmd.Parameters["@country"].Value = country_id;
                cmd.Parameters["@language"].Value = language_id;
                cmd.Parameters["@photo"].Value = authorPhoto;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Auhtor Inserted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            removeById = "DELETE FROM authors WHERE author_id = @author_id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(removeById, conn);

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
            }catch(MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
        }

        /*
         *Search type:
         0 - Search All
         1 - Search for any parameter
        */
        public List<Authors> SearchAllAuthors(int id, string name, int country_id, int language_id, int searchType, MySqlConnection conn)
        {
            if (searchType == 0)
            {
                retrieve = "SELECT a.*, c.*, l.* FROM authors a " +
                    "LEFT JOIN countries c on a.country_id = c.country_id " +
                    "LEFT JOIN languages l on a.language_id = l.language_id " +
                    "ORDER BY authorName";
            }
            else
            {

                retrieve = "SELECT a.*, c.*, l.* FROM authors a " +
                    "LEFT JOIN countries c on a.country_id = c.country_id " +
                    "LEFT JOIN languages l on a.language_id = l.language_id " +
                    "WHERE a.author_id = @author_id OR " +
                    "a.authorName = @authorName OR " +
                    "a.country_id = @country_id OR " +
                    "a.language_id = @language_id " +
                    "ORDER BY authorName";
            }

            MySqlCommand cmd = new MySqlCommand(retrieve, conn);
            cmd.Parameters.Add("@author_id", MySqlDbType.Int16);
            cmd.Parameters.Add("@authorName", MySqlDbType.VarChar, 45);
            cmd.Parameters.Add("@country_id", MySqlDbType.Int16);
            cmd.Parameters.Add("@language_id", MySqlDbType.Int16);

            cmd.Parameters["@author_id"].Value = id;
            cmd.Parameters["@authorName"].Value = name;
            cmd.Parameters["@country_id"].Value = country_id;
            cmd.Parameters["@language_id"].Value = language_id;

            MySqlDataReader dataRead = cmd.ExecuteReader();

            while (dataRead.Read())
            {
                /*----- Retrieve the country from the author -----*/
                country = new Countries
                {
                    Country_id = Convert.IsDBNull(dataRead["country_id"]) ? -1 : Convert.ToInt32(dataRead["country_id"]),
                    CountryName = Convert.IsDBNull(dataRead["countryName"]) ? "" : dataRead["countryName"].ToString(),
                    ShowCountry = Convert.IsDBNull(dataRead["showCountry"]) ? "" : dataRead["showCountry"].ToString()
                };

                /*----- Retrieve the language from the author -----*/
                language = new Languages
                {
                    Language_id = Convert.IsDBNull(dataRead["language_id"]) ? -1 : Convert.ToInt32(dataRead["language_id"]),
                    LanguageName = Convert.IsDBNull(dataRead["languageName"]) ? "" : dataRead["languageName"].ToString(),
                    ShowLanguage = Convert.IsDBNull(dataRead["showLanguage"]) ? "" : dataRead["showLanguage"].ToString()
                };

                /*----- Retrieve the author itself-----*/
                author = new Authors
                {
                    Author_id = Convert.IsDBNull(dataRead["author_id"]) ? -1 : Convert.ToInt32(dataRead["author_id"]),
                    AuthorName = Convert.IsDBNull(dataRead["authorName"]) ? "" : dataRead["authorName"].ToString(),
                    AuthorAbout = Convert.IsDBNull(dataRead["authorAbout"]) ? "" : dataRead["authorAbout"].ToString(),
                    AuthorCountry = country,
                    AuthorLanguage = language,
                    AuthorPhoto = Convert.IsDBNull(dataRead["authorPhoto"]) ? null : (byte[])dataRead["authorPhoto"]
                };

                authorList.Add(author);
            }

            dataRead.Close();

            return authorList;
        }

    }
}
