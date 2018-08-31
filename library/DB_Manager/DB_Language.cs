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
    class DB_Language
    {
        /*----- Strings that defines the queries -----*/
        private string insert;
        private string update;
        private string removeByName;
        private string retrieveAll;
        private string countString;


        /*----- Others Variables -----*/
        private int count = -1;

        List<Language> languageList = new List<Language>();
        Language language;

        public int Count(MySqlConnection conn)
        {
            countString = "SELECT COUNT(*) FROM languages";
            MySqlCommand cmd = new MySqlCommand(countString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;

        }

        /*----- Insert Query -----*/
        public bool InsertLanguage(string languageName, string showLanguage, MySqlConnection conn)
        {
            insert = "INSERT INTO languages (languageName, showLanguage, languageDateInsert) " +
                "VALUES (@languageName, @showLanguage, current_timestamp())";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(insert, conn);

                cmd.Parameters.Add("@languageName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@showLanguage", MySqlDbType.Enum);

                cmd.Parameters["@languageName"].Value = languageName;
                cmd.Parameters["@showLanguage"].Value = showLanguage;

                if(cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Language Inserted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Inserting Language!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }catch(MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
        }

        /*----- Insert Query -----*/
        public bool UpdateLanguage(int language_id, string languageName, string showLanguage, MySqlConnection conn)
        {
            update = "UPDATE languages SET " +
                "languageName = @newLanguageName " +
                "showLanguage = @newShowLanguage " +
                "languageDateUpdate = current_timestamp() " +
                "WHERE language_id = @language_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(update, conn);

                cmd.Parameters.Add("@language_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@newLanguageName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@newShowLanguage", MySqlDbType.Enum);

                cmd.Parameters["@language_id"].Value = language_id;
                cmd.Parameters["@newLanguageName"].Value = languageName;
                cmd.Parameters["@newShowLanguage"].Value = showLanguage;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Language Updated Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Updating Language!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool RemoveLanguageById(string language_id, MySqlConnection conn)
        {

            removeByName = "DELETE FROM languages WHERE language_id = @language_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(removeByName, conn);
                cmd.Parameters.Add("@language_id", MySqlDbType.Int32);
                cmd.Parameters["@language_id"].Value = language_id;


                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Language Deleted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Deleting Language!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
        }

        /*----- Search Queries -----*/
        public List<Language> SearchAllLanguages(MySqlConnection conn)
        {
            retrieveAll = "SELECT * FROM languages ORDER BY languageName";

            MySqlCommand Cmd = new MySqlCommand(retrieveAll, conn);
            SetLanguageData(Cmd);
            return languageList;
        }

        private void SetLanguageData(MySqlCommand cmd)
        {
            MySqlDataReader dataRead = cmd.ExecuteReader();

            while (dataRead.Read())
            {
                language = new Language
                {
                    Language_id = Convert.IsDBNull(dataRead["language_id"]) ? -1 : Convert.ToInt32(dataRead["language_id"]),
                    LanguageName = Convert.IsDBNull(dataRead["languageName"]) ? "" : dataRead["languageName"].ToString(),
                    ShowLanguage = Convert.IsDBNull(dataRead["showLanguage"]) ? "" : dataRead["showLanguage"].ToString()
                };

                languageList.Add(language);
            }

            dataRead.Close();
        }
    }
}
