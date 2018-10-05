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
        private string Insert;
        private string Update;
        private string RemoveById;
        private string RetrieveAll;
        private string CountString;


        /*----- Others Variables -----*/
        private int count = -1;

        List<Language> LanguageList = new List<Language>();
        Language Language;

        public int Count(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM languages";
            MySqlCommand Cmd = new MySqlCommand(CountString, conn);

            count = Convert.ToInt32(Cmd.ExecuteScalar());

            return count;

        }

        /*----- Insert Query -----*/
        public bool InsertLanguage(string languageName, string showLanguage, MySqlConnection conn)
        {
            Insert = "INSERT INTO languages (languageName, showLanguage, languageDateInsert) " +
                "VALUES (@languageName, @showLanguage, current_timestamp())";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(Insert, conn);

                cmd.Parameters.Add("@languageName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@showLanguage", MySqlDbType.Enum);

                cmd.Parameters["@languageName"].Value = languageName;
                cmd.Parameters["@showLanguage"].Value = showLanguage;

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Language Inserted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Inserting Language!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Update = "UPDATE languages SET " +
                "languageName = @newLanguageName " +
                "showLanguage = @newShowLanguage " +
                "languageDateUpdate = current_timestamp() " +
                "WHERE language_id = @language_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(Update, conn);

                cmd.Parameters.Add("@language_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@newLanguageName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@newShowLanguage", MySqlDbType.Enum);

                cmd.Parameters["@language_id"].Value = language_id;
                cmd.Parameters["@newLanguageName"].Value = languageName;
                cmd.Parameters["@newShowLanguage"].Value = showLanguage;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Language Updated Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Updating Language!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool RemoveLanguageById(string Language_Id, MySqlConnection Conn)
        {

            RemoveById = "DELETE FROM languages WHERE language_id = @language_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(RemoveById, Conn);
                cmd.Parameters.Add("@language_id", MySqlDbType.Int32);
                cmd.Parameters["@language_id"].Value = Language_Id;


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
            RetrieveAll = "SELECT * FROM languages ORDER BY languageName";

            MySqlCommand Cmd = new MySqlCommand(RetrieveAll, conn);
            SetLanguageData(Cmd);
            return LanguageList;
        }

        private void SetLanguageData(MySqlCommand cmd)
        {
            MySqlDataReader DataReader = cmd.ExecuteReader();

            while (DataReader.Read())
            {
                Language = new Language
                {
                    Language_Id = Convert.IsDBNull(DataReader["language_id"]) ? -1 : Convert.ToInt32(DataReader["language_id"]),
                    LanguageName = Convert.IsDBNull(DataReader["languageName"]) ? "" : DataReader["languageName"].ToString(),
                    ShowLanguage = Convert.IsDBNull(DataReader["showLanguage"]) ? "" : DataReader["showLanguage"].ToString()
                };

                LanguageList.Add(Language);
            }

            DataReader.Close();
        }
    }
}
