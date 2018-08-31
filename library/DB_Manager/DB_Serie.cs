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
        private string update;
        private string removeByName;
        private string Retrieve;
        private string countString;

        /*----- Others Variables -----*/
        private int count = -1;

        private List<Serie> SerieList = new List<Serie>();
        private Serie serie;

        public int Count(MySqlConnection conn)
        {
            countString = "SELECT COUNT(*) FROM series";
            MySqlCommand cmd = new MySqlCommand(countString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;
        }

        /*----- Insert Query -----*/
        public bool InsertPublisher(string serieName, int serieVolumes, string serieType, string serieSynopsis, MySqlConnection Conn)
        {
            Insert = "INSERT INTO series (serieName, serieVolumes, serieType, serieSynopsis, serieDateInsert) " +
                "VALUES (@serieName, @serieVolumes, @serieType, @serieSynopsis, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(Insert, Conn);

                cmd.Parameters.Add("@serieName", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@serieVolumes", MySqlDbType.Int32);
                cmd.Parameters.Add("@serieType", MySqlDbType.Enum);
                cmd.Parameters.Add("@serieSynopsis", MySqlDbType.MediumText);

                cmd.Parameters["@serieName"].Value = serieName;
                cmd.Parameters["@serieVolumes"].Value = serieVolumes;
                cmd.Parameters["@serieType"].Value = serieType;
                cmd.Parameters["@serieSynopsis"].Value = serieSynopsis;

                if (cmd.ExecuteNonQuery() > 0)
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

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);
            SetSerieData(Cmd);
            return SerieList;
        }

        public List<Serie> ListSeriesByType(String SerieType, MySqlConnection Conn)
        {
            Retrieve = "SELECT * FROM series " +
                "WHERE serieType = @SerieType" +
                "   or serieType = 'All'";

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);
            Cmd.Parameters.Add("@SerieType", MySqlDbType.Enum);
   
            Cmd.Parameters["@SerieType"].Value = SerieType;

            SetSerieData(Cmd);
            return SerieList;
        }


        private void SetSerieData(MySqlCommand Cmd)
        {
            MySqlDataReader dataRead = Cmd.ExecuteReader();

            SerieList.Clear();
            while (dataRead.Read())
            {
                serie = new Serie
                {
                    Serie_id = Convert.IsDBNull(dataRead["serie_id"]) ? -1 : Convert.ToInt32(dataRead["serie_id"]),
                    SerieName = Convert.IsDBNull(dataRead["serieName"]) ? "" : (dataRead["serieName"]).ToString(),
                    SerieVolumes = Convert.IsDBNull(dataRead["serieVolumes"]) ? -1 : Convert.ToInt32(dataRead["serieVolumes"]),
                    SerieType = Convert.IsDBNull(dataRead["serieType"]) ? "" : dataRead["serieType"].ToString(),
                    SerieSynopsis = Convert.IsDBNull(dataRead["serieSynopsis"]) ? "" : dataRead["serieSynopsis"].ToString()
                };

                SerieList.Add(serie);
            }

            dataRead.Close();
        }

    }
}
