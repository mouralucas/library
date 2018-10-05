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
    class DB_Genre
    {
        
        /*----- Strings that defines the queries -----*/
        private string Insert;
        private string RemoveById;
        private string RetrieveAll;
        private string CountString;

        /*----- Others Variables -----*/
        private int Count = -1;

        List<Genre> GenreList = new List<Genre>();
        Genre Genre;

        public int CountRows(MySqlConnection Conn)
        {
            CountString = "SELECT COUNT(*) FROM genres";
            MySqlCommand Cmd = new MySqlCommand(CountString, Conn);

            Count = Convert.ToInt32(Cmd.ExecuteScalar());

            return Count;

        }

        /*----- Insert Query -----*/
        public bool InsertGenre(string genreName, MySqlConnection Conn)
        {
            Insert = "INSERT INTO genres (genreName, genreDateInsert) VALUES (@genreName, current_timestamp())";

            try
            {
                MySqlCommand Cmd = new MySqlCommand(Insert, Conn);
                Cmd.Parameters.Add("@genreName", MySqlDbType.VarChar, 30);

                Cmd.Parameters["@genreName"].Value = genreName;

                if (Cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Genre Inserted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Inserting Genre!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        /*----- Delete Queries -----*/
        public bool RemoveGenreByName(String Genre_Id, MySqlConnection Conn)
        {

            RemoveById = "DELETE FROM genres WHERE genre_id = @genre_id";
            try
            {
                MySqlCommand Cmd = new MySqlCommand(RemoveById, Conn);

                Cmd.Parameters.Add("@genre_id", MySqlDbType.Int16, 11);
                Cmd.Parameters["@genre_id"].Value = Genre_Id;

                if (Cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("Genre Deleted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Error Deleting Genre!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public List<Genre> ListAllGenres(MySqlConnection conn)
        {
            RetrieveAll = "SELECT * FROM genres ORDER BY genreName";

            MySqlCommand Cmd = new MySqlCommand(RetrieveAll, conn);
            SetGenreData(Cmd);
            return GenreList;
        }

        private void SetGenreData(MySqlCommand Cmd)
        {
            MySqlDataReader DataReader = Cmd.ExecuteReader();
            while (DataReader.Read())
            {

                Genre = new Genre()
                {
                    Genre_Id = Convert.IsDBNull(DataReader["genre_id"]) ? -1 : Convert.ToInt32(DataReader["genre_id"]),
                    GenreName = Convert.IsDBNull(DataReader["genreName"]) ? "" : DataReader["genreName"].ToString()
                };

                GenreList.Add(Genre);
            }

            DataReader.Close();
        }
    }
}
