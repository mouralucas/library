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
        private string Insert;
        private string RemoveById;
        private string Retrieve;
        private string CountString;
        private string Update;

        /*----- Others Variables -----*/
        private int Count = -1;

        private List<Country> CountryList = new List<Country>();
        private Country Country;

        public int CountRows(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM countries";
            MySqlCommand cmd = new MySqlCommand(CountString, conn);

            Count = Convert.ToInt32(cmd.ExecuteScalar());

            return Count;

        }

        /*----- Insert Query -----*/
        public bool InsertCountry(string countryName, string showCountry, byte[] countryFlag, MySqlConnection conn)
        {
            Insert = "INSERT INTO countries (countryName, showCountry, countryFlag, countryDateInsert) " +
                "VALUES (@countryName, @showCountry, @countryFlag, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(Insert, conn);

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
            Update = "UPDATE countries SET " +
                    "countryName = @newCountryName, " +
                    "showCountry = @newShowCountry, " +
                    "countryFlag = @newCountryFlag, " +
                    "countryDateUpdate = current_timestamp() " +
                    "WHERE country_id = @country_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(Update, conn);

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

            RemoveById = "DELETE FROM countries WHERE country_id = @country_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(RemoveById, conn);

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
        public List<Country> ListAll(MySqlConnection Conn)
        {
            Retrieve = "SELECT * FROM countries ORDER BY countryName";

            MySqlCommand cmd = new MySqlCommand(Retrieve, Conn);
            MySqlDataReader DataReader = cmd.ExecuteReader();

            while (DataReader.Read())
            {
                Country = new Country()
                {
                    Country_Id = Convert.IsDBNull(DataReader["country_id"]) ? -1 : Convert.ToInt32(DataReader["country_id"]),
                    CountryName = Convert.IsDBNull(DataReader["countryName"]) ? "" : DataReader["countryName"].ToString(),
                    ShowCountry = Convert.IsDBNull(DataReader["showCountry"]) ? "" : DataReader["showCountry"].ToString(),
                    CountryFlag = Convert.IsDBNull(DataReader["countryFlag"]) ? null : (byte[])DataReader["countryFlag"]
                };

                CountryList.Add(Country);
            }

            DataReader.Close();

            return CountryList;
        }
    }
}
