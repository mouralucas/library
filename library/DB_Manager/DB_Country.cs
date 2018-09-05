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
    class DB_Country
    {

        /*----- Strings that defines the queries -----*/
        private string insert;
        private string removeById;
        private string retrieveAll;
        private string countString;
        private string update;

        /*----- Others Variables -----*/
        private int count = -1;

        private List<Country> countryList = new List<Country>();
        private Country country;

        public int Count(MySqlConnection conn)
        {
            countString = "SELECT COUNT(*) FROM countries";
            MySqlCommand cmd = new MySqlCommand(countString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;

        }

        /*----- Insert Query -----*/
        public bool InsertCountry(string countryName, string showCountry, byte[] countryFlag, MySqlConnection conn)
        {
            insert = "INSERT INTO countries (countryName, showCountry, countryFlag, countryDateInsert) " +
                "VALUES (@countryName, @showCountry, @countryFlag, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(insert, conn);

                cmd.Parameters.Add("@countryName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@showCountry", MySqlDbType.Enum);
                cmd.Parameters.Add("@countryFlag", MySqlDbType.MediumBlob);

                cmd.Parameters["@countryName"].Value = countryName;
                cmd.Parameters["@showCountry"].Value = showCountry;
                cmd.Parameters["@countryFlag"].Value = countryFlag;
                

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Country Inserted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Inserting Country!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
        }

        /*----- Update Query -----*/
        public bool UpdateCountry(int country_id, string newCountryName, string newShowCountry, byte[] newCountryFlag, MySqlConnection conn)
        {
            update = "UPDATE countries SET " +
                    "countryName = @newCountryName, " +
                    "showCountry = @newShowCountry, " +
                    "countryFlag = @newCountryFlag, " +
                    "countryDateUpdate = current_timestamp() " +
                    "WHERE country_id = @country_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(update, conn);

                cmd.Parameters.Add("@country_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@newCountryName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@newShowCountry", MySqlDbType.Enum);
                cmd.Parameters.Add("@newCountryFlag", MySqlDbType.MediumBlob);

                cmd.Parameters["@country_id"].Value = country_id;
                cmd.Parameters["@newCountryName"].Value = newCountryName;
                cmd.Parameters["@newShowCountry"].Value = newShowCountry;
                cmd.Parameters["@newCountryFlag"].Value = newCountryFlag;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Country Updated Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Updating Country!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
        }

        /*----- Delete Queries -----*/
        public bool RemoveCountryById(string country_id, MySqlConnection conn)
        {

            removeById = "DELETE FROM countries WHERE country_id = @country_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(removeById, conn);

                cmd.Parameters.Add("@country_id", MySqlDbType.Int16, 11);
                cmd.Parameters["@country_id"].Value = country_id;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Country Deleted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Deleting Country!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public List<Country> SearchAllCountries(MySqlConnection conn)
        {
            retrieveAll = "SELECT * FROM countries ORDER BY countryName";

            MySqlCommand cmd = new MySqlCommand(retrieveAll, conn);
            MySqlDataReader dataRead = cmd.ExecuteReader();

            while (dataRead.Read())
            {
                country = new Country()
                {
                    Country_Id = Convert.IsDBNull(dataRead["country_id"]) ? -1 : Convert.ToInt32(dataRead["country_id"]),
                    CountryName = Convert.IsDBNull(dataRead["countryName"]) ? "" : dataRead["countryName"].ToString(),
                    ShowCountry = Convert.IsDBNull(dataRead["showCountry"]) ? "" : dataRead["showCountry"].ToString(),
                    CountryFlag = Convert.IsDBNull(dataRead["countryFlag"]) ? null : (byte[])dataRead["countryFlag"]
                };

                countryList.Add(country);
            }

            dataRead.Close();

            return countryList;
        }
    }
}
