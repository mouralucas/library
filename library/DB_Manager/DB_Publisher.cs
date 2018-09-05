using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Library.Entities;

namespace Library.DB_Manager
{
    class DB_Publisher
    {
        /*----- Strings that defines the queries -----*/
        private string Insert;
        private string Update;
        private string RemoveByName;
        private string Retrieve;
        private string CountString;


        /*----- Others Variables -----*/
        private int count = -1;

        private List<Publisher> PublisherList = new List<Publisher>();

        private Publisher Publisher;
        private Country Country;
        private Category Category;

        public int Count(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM publishers";
            MySqlCommand cmd = new MySqlCommand(CountString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;
        }

        /*----- Insert Query -----*/
        public bool InsertPublisher(string publisherName, string publisherAbout, int country_id, byte[] publisherLogo, MySqlConnection conn)
        {
            Insert = "INSERT INTO publishers (publisherName, publisherAbout, country_id, publisherLogo, publisherDateInsert) " +
                "VALUES (@publisherName, @publisherAbout, @country_id, @publisherLogo, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(Insert, conn);

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

        public List<Publisher> ListAllPublishers(MySqlConnection Conn)
        {
            Retrieve = "SELECT p.*, c.*, cat.* FROM publishers p " 
                + "LEFT JOIN countries c "
                + "   ON p.country_id = c.country_id "
                + "LEFT JOIN category cat "
                + "   ON p.category_id = cat.category_id "
                + "ORDER BY publisherName";

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);
            SetPublisherData(Cmd);
            return PublisherList;
        }

        public List<Publisher> ListPublisherByCategory(int Category_Id, MySqlConnection Conn)
        {
            Retrieve = "SELECT p.*, c.* FROM publishers p "
                + "LEFT JOIN countries c ON p.country_id = c.country_id "
                + "WHERE category_id = @category_id "
                + "ORDER BY publisherName";

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);

            Cmd.Parameters.Add("@category_id", MySqlDbType.Int32, 11);
            Cmd.Parameters["@category_id"].Value = Category_Id;

            SetPublisherData(Cmd);
            return PublisherList;
        }

        private void SetPublisherData(MySqlCommand Cmd)
        {
            MySqlDataReader DataRead = Cmd.ExecuteReader();

            PublisherList.Clear();
            while (DataRead.Read())
            {

                Country = new Country()
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

                Publisher = new Publisher()
                {
                    Publisher_id = Convert.IsDBNull(DataRead["publisher_id"]) ? -1 : Convert.ToInt32(DataRead["publisher_id"]),
                    PublisherName = Convert.IsDBNull(DataRead["publisherName"]) ? "" : DataRead["publisherName"].ToString(),
                    PublisherAbout = Convert.IsDBNull(DataRead["publisherAbout"]) ? "" : DataRead["publisherAbout"].ToString(),
                    PublisherCountry = Country,
                    PublisherCategory = Category,
                    PublisherLogo = Convert.IsDBNull(DataRead["publisherLogo"]) ? null : (byte[])DataRead["publisherLogo"],
                };

                PublisherList.Add(Publisher);
            }

            DataRead.Close();
        }
    }
}
