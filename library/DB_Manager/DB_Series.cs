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
    class DB_Series
    {
        /*----- Strings that defines the queries -----*/
        private string insert;
        private string update;
        private string removeByName;
        private string retrieve;
        private string countString;

        /*----- Others Variables -----*/
        private int count = -1;

        private List<Series> serieList = new List<Series>();
        private Series serie;

        public int Count(MySqlConnection conn)
        {
            countString = "SELECT COUNT(*) FROM series";
            MySqlCommand cmd = new MySqlCommand(countString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;
        }

        /*----- Insert Query -----*/
        public bool InsertPublisher(string serieName, int serieVolumes, string serieType, string serieSynopsis, MySqlConnection conn)
        {
            insert = "INSERT INTO series (serieName, serieVolumes, serieType, serieSynopsis, serieDateInsert) " +
                "VALUES (@serieName, @serieVolumes, @serieType, @serieSynopsis, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(insert, conn);

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
        public List<Series> SearchSeries(int id, string serieName, string serieType, int searchType, MySqlConnection conn)
        {
            if(searchType == 0)
            {
                //a principio esta pesquisa não tras os livros relacionados a esta serie
                retrieve = "SELECT * FROM series";
            }
            else
            {

            }

            MySqlCommand cmd = new MySqlCommand(retrieve, conn);
            //parametros da pesquisa por campo
            MySqlDataReader dataRead = cmd.ExecuteReader();

            while (dataRead.Read())
            {
                serie = new Series
                {
                    Serie_id = Convert.IsDBNull(dataRead["serie_id"]) ? -1 : Convert.ToInt32(dataRead["serie_id"]),
                    SerieName = Convert.IsDBNull(dataRead["serieName"]) ? "" : (dataRead["serieName"]).ToString(),
                    SerieVolumes = Convert.IsDBNull(dataRead["serieVolumes"]) ? -1 : Convert.ToInt32(dataRead["serieVolumes"]),
                    SerieType = Convert.IsDBNull(dataRead["serieType"]) ? "" : dataRead["serieType"].ToString(),
                    SerieSynopsis = Convert.IsDBNull(dataRead["serieSynopsis"]) ? "" : dataRead["serieSynopsis"].ToString()
                };

                serieList.Add(serie);
            }

            dataRead.Close();

            return serieList;
        }
    }
}
