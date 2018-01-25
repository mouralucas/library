using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library.DB_Manager
{
    class DB_Series
    {
        /*----- Strings that defines the queries -----*/
        private string insert;
        private string update;
        private string removeByName;
        private string retrieveAll;
        private string countString;

        /*----- Others Variables -----*/
        private int count = -1;

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
    }
}
