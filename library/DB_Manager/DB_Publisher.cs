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
        private int Count = -1;

        private List<Publisher> PublisherList = new List<Publisher>();

        private Publisher Publisher;
        private Country Country;
        private Category Category;

        public int CountRows(MySqlConnection Conn)
        {
            CountString = "SELECT COUNT(*) FROM publishers";
            MySqlCommand Command = new MySqlCommand(CountString, Conn);

            Count = Convert.ToInt32(Command.ExecuteScalar());

            return Count;
        }

        /*----- Insert Query -----*/
        public bool InsertPublisher(String PublisherName, String PublisherAbout, int Country_Id, byte[] PublisherLogo, MySqlConnection Conn)
        {
            Insert = "INSERT INTO publishers (publisherName, publisherAbout, country_id, publisherLogo, publisherDateInsert) " +
                "VALUES (@publisherName, @publisherAbout, @country_id, @publisherLogo, current_timestamp())";

            try
            {
                MySqlCommand Command = new MySqlCommand(Insert, Conn);

                Command.Parameters.Add("@publisherName", MySqlDbType.VarChar, 45);
                Command.Parameters.Add("@publisherAbout", MySqlDbType.MediumText);
                Command.Parameters.Add("@country_id", MySqlDbType.Int32);
                Command.Parameters.Add("@publisherLogo", MySqlDbType.MediumBlob);

                Command.Parameters["@publisherName"].Value = PublisherName;
                Command.Parameters["@publisherAbout"].Value = PublisherAbout;
                Command.Parameters["@country_id"].Value = Country_Id;
                Command.Parameters["@publisherLogo"].Value = PublisherLogo;

                if (Command.ExecuteNonQuery() > 0)
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

            MySqlCommand Command = new MySqlCommand(Retrieve, Conn);
            SetPublisherData(Command);
            return PublisherList;
        }

        public List<Publisher> ListPublisherByCategory(int Category_Id, MySqlConnection Conn)
        {
            Retrieve = "SELECT p.*, c.* FROM publishers p "
                + "LEFT JOIN countries c ON p.country_id = c.country_id "
                + "WHERE category_id = @category_id "
                + "ORDER BY publisherName";

            MySqlCommand Command = new MySqlCommand(Retrieve, Conn);

            Command.Parameters.Add("@category_id", MySqlDbType.Int32, 11);
            Command.Parameters["@category_id"].Value = Category_Id;

            SetPublisherData(Command);
            return PublisherList;
        }

        private void SetPublisherData(MySqlCommand Command)
        {
            MySqlDataReader DataReader = Command.ExecuteReader();

            PublisherList.Clear();
            while (DataReader.Read())
            {

                Country = new Country()
                {
                    Country_Id = Convert.IsDBNull(DataReader["country_id"]) ? -1 : Convert.ToInt32(DataReader["country_id"]),
                    CountryName = Convert.IsDBNull(DataReader["countryName"]) ? "" : DataReader["countryName"].ToString(),
                    ShowCountry = Convert.IsDBNull(DataReader["showCountry"]) ? "" : DataReader["showCountry"].ToString()
                };

                Category = new Category()
                {
                    Category_Id = Convert.IsDBNull(DataReader["category_id"]) ? -1 : Convert.ToInt32(DataReader["category_id"]),
                    CategoryName = Convert.IsDBNull(DataReader["category"]) ? "" : DataReader["category"].ToString(),
                    Description = Convert.IsDBNull(DataReader["description"]) ? "" : DataReader["description"].ToString()
                };

                Publisher = new Publisher()
                {
                    Publisher_Id = Convert.IsDBNull(DataReader["publisher_id"]) ? -1 : Convert.ToInt32(DataReader["publisher_id"]),
                    PublisherName = Convert.IsDBNull(DataReader["publisherName"]) ? "" : DataReader["publisherName"].ToString(),
                    PublisherAbout = Convert.IsDBNull(DataReader["publisherAbout"]) ? "" : DataReader["publisherAbout"].ToString(),
                    PublisherCountry = Country,
                    PublisherCategory = Category,
                    PublisherLogo = Convert.IsDBNull(DataReader["publisherLogo"]) ? null : (byte[])DataReader["publisherLogo"],
                };

                PublisherList.Add(Publisher);
            }

            DataReader.Close();
        }
    }
}
