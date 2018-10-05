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
    class DB_Serie
    {
        /*----- Strings that defines the queries -----*/
        private string Insert;
        private string Update;
        private string RemoveByName;
        private string Retrieve;
        private string CountString;

        /*----- Others Variables -----*/
        private int Count = -1;

        private List<Serie> SerieList = new List<Serie>();
        private Serie Serie;

        public int CountRows(MySqlConnection Conn)
        {
            CountString = "SELECT COUNT(*) FROM series";
            MySqlCommand Command = new MySqlCommand(CountString, Conn);

            Count = Convert.ToInt32(Command.ExecuteScalar());

            return Count;
        }

        /*----- Insert Query -----*/
        public bool InsertPublisher(string serieName, int serieVolumes, int category_id, string serieSynopsis, MySqlConnection Conn)
        {
            Insert = "INSERT INTO series (serieName, serieVolumes, category_id, serieSynopsis, serieDateInsert) " +
                "VALUES (@serieName, @serieVolumes, @category_id, @serieSynopsis, current_timestamp())";

            try
            {
                MySqlCommand Command = new MySqlCommand(Insert, Conn);

                Command.Parameters.Add("@serieName", MySqlDbType.VarChar, 45);
                Command.Parameters.Add("@serieVolumes", MySqlDbType.Int32);
                Command.Parameters.Add("@category_id", MySqlDbType.Int32, 11);
                Command.Parameters.Add("@serieSynopsis", MySqlDbType.MediumText);

                Command.Parameters["@serieName"].Value = serieName;
                Command.Parameters["@serieVolumes"].Value = serieVolumes;
                Command.Parameters["@category_id"].Value = category_id;
                Command.Parameters["@serieSynopsis"].Value = serieSynopsis;

                if (Command.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Serie Inserted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Inserting Serie!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*
         *Search type:
         0 - Search All
         1 - Search for any parameter
        */
        public List<Serie> ListAllSeries(MySqlConnection Conn)
        {
            Retrieve = "SELECT * FROM series ORDER BY serieName";

            MySqlCommand Command = new MySqlCommand(Retrieve, Conn);
            SetSerieData(Command);
            return SerieList;
        }

        public List<Serie> ListSeriesByCategory(int Category_Id, MySqlConnection Conn)
        {
            Retrieve = "SELECT * FROM series " +
                "WHERE category_id = @category_id" +
                "   or category_id = 1";

            MySqlCommand Command = new MySqlCommand(Retrieve, Conn);
            Command.Parameters.Add("@category_id", MySqlDbType.Int32, 11);
   
            Command.Parameters["@category_id"].Value = Category_Id;

            SetSerieData(Command);
            return SerieList;
        }


        private void SetSerieData(MySqlCommand Command)
        {
            MySqlDataReader DataReader = Command.ExecuteReader();

            SerieList.Clear();
            while (DataReader.Read())
            {
                Serie = new Serie
                {
                    Serie_Id = Convert.IsDBNull(DataReader["serie_id"]) ? -1 : Convert.ToInt32(DataReader["serie_id"]),
                    SerieName = Convert.IsDBNull(DataReader["serieName"]) ? "" : (DataReader["serieName"]).ToString(),
                    SerieVolumes = Convert.IsDBNull(DataReader["serieVolumes"]) ? -1 : Convert.ToInt32(DataReader["serieVolumes"]),
                    SerieCategory = Convert.IsDBNull(DataReader["serieCategory"]) ? "" : DataReader["serieCategory"].ToString(),
                    SerieCategory_id = Convert.IsDBNull(DataReader["category_id"]) ? -1 : Convert.ToInt32(DataReader["category_id"]),
                    SerieSynopsis = Convert.IsDBNull(DataReader["serieSynopsis"]) ? "" : DataReader["serieSynopsis"].ToString()
                };

                SerieList.Add(Serie);
            }

            DataReader.Close();
        }

    }
}
