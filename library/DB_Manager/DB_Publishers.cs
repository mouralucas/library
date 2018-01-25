using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using library.Entities;

namespace library.DB_Manager
{
    class DB_Publishers
    {
        /*----- Strings that defines the queries -----*/
        private string insert;
        private string update;
        private string removeByName;
        private string retrieveAll;
        private string countString;


        /*----- Others Variables -----*/
        private int count = -1;

        private List<Publishers> publisherList = new List<Publishers>();
        private Publishers publisher;
        private Countries country;

        public int Count(MySqlConnection conn)
        {
            countString = "SELECT COUNT(*) FROM publishers";
            MySqlCommand cmd = new MySqlCommand(countString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;
        }

        /*----- Insert Query -----*/
        public bool InsertPublisher(string publisherName, string publisherAbout, int country_id, byte[] publisherLogo, MySqlConnection conn)
        {
            insert = "INSERT INTO publishers (publisherName, publisherAbout, country_id, publisherLogo, publisherDateInsert) " +
                "VALUES (@publisherName, @publisherAbout, @country_id, @publisherLogo, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(insert, conn);

                cmd.Parameters.Add("@publisherName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@publisherAbout", MySqlDbType.MediumText);
                cmd.Parameters.Add("@country_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@publisherLogo", MySqlDbType.MediumBlob);

                cmd.Parameters["@publisherName"].Value = publisherName;
                cmd.Parameters["@publisherAbout"].Value = publisherAbout;
                cmd.Parameters["@country_id"].Value = country_id;
                cmd.Parameters["@publisherLogo"].Value = publisherLogo;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Publisher Inserted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Inserting Publisher!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Publishers> SearchAllPublishers(int publisher_id, string publisherName, int country_id, int searchType, MySqlConnection conn)
        {
            if (searchType == 0)
            {
                retrieveAll = "SELECT p.*, c.* FROM publishers p " +
                    "LEFT JOIN countries c ON p.country_id = c.country_id " +
                    "ORDER BY publisherName";
            }
            else
            {
                //query de busca por campo
            }


            MySqlCommand cmd = new MySqlCommand(retrieveAll, conn);
            //parametros do busca por campos
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

                /*----- Retrieve the publisher itself-----*/
                publisher = new Publishers()
                {
                    Publisher_id = Convert.IsDBNull(dataRead["publisher_id"]) ? -1 : Convert.ToInt32(dataRead["publisher_id"]),
                    PublisherName = Convert.IsDBNull(dataRead["publisherName"]) ? "" : dataRead["publisherName"].ToString(),
                    PublisherAbout = Convert.IsDBNull(dataRead["publisherAbout"]) ? "" : dataRead["publisherAbout"].ToString(),
                    PublisherCountry = country,
                    PublisherLogo = Convert.IsDBNull(dataRead["publisherLogo"]) ? null: (byte[])dataRead["publisherLogo"],
                    //PublisherDateInsert = Convert.IsDBNull(dataRead["publisherLogo"]) ? 0000 - 00 - 00 00:00:00 : (DateTime)dataRead["publisherLogo"]
                };

                publisherList.Add(publisher);
            }

            dataRead.Close();

            return publisherList;
        }
    }
}
