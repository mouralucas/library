﻿using System;
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
        private string insert;
        private string removeById;
        private string retrieveAll;
        private string countString;

        /*----- Others Variables -----*/
        private int count = -1;

        List<Genre> GenreList = new List<Genre>();
        Genre genre;

        public int Count(MySqlConnection conn)
        {
            countString = "SELECT COUNT(*) FROM genres";
            MySqlCommand cmd = new MySqlCommand(countString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;

        }

        /*----- Insert Query -----*/
        public bool InsertGenre(string genreName, MySqlConnection conn)
        {
            insert = "INSERT INTO genres (genreName, genreDateInsert) VALUES (@genreName, current_timestamp())";

            try
            {
                MySqlCommand cmd = new MySqlCommand(insert, conn);
                cmd.Parameters.Add("@genreName", MySqlDbType.VarChar, 30);

                cmd.Parameters["@genreName"].Value = genreName;

                if (cmd.ExecuteNonQuery() > 0)
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
        public bool RemoveGenreByName(string genre_id, MySqlConnection conn)
        {

            removeById = "DELETE FROM genres WHERE genre_id = @genre_id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(removeById, conn);

                cmd.Parameters.Add("@genre_id", MySqlDbType.Int16, 11);
                cmd.Parameters["@genre_id"].Value = genre_id;

                if (cmd.ExecuteNonQuery() > 0)
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
            retrieveAll = "SELECT * FROM genres ORDER BY genreName";

            MySqlCommand Cmd = new MySqlCommand(retrieveAll, conn);
            SetGenreData(Cmd);
            return GenreList;
        }

        private void SetGenreData(MySqlCommand Cmd)
        {
            MySqlDataReader dataRead = Cmd.ExecuteReader();
            while (dataRead.Read())
            {

                genre = new Genre()
                {
                    Genre_id = Convert.IsDBNull(dataRead["genre_id"]) ? -1 : Convert.ToInt32(dataRead["genre_id"]),
                    GenreName = Convert.IsDBNull(dataRead["genreName"]) ? "" : dataRead["genreName"].ToString()
                };

                GenreList.Add(genre);
            }

            dataRead.Close();
        }
    }
}
