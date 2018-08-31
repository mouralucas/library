using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Library.DB_Manager
{
    class DB_Book
    {
        /*----- Strings that defines the queries -----*/
        private string Insert;
        private string RemoveById;
        private string Retrieve;
        private string CountString;

        /*----- Others Variables -----*/
        private int count = -1;

        public int Count(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM books";
            MySqlCommand cmd = new MySqlCommand(CountString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;

        }

        public bool InsertBook(string Category, string Title, string SubTitle, string OriginalTitle, string OriginalSubTitle, string Isbn, 
            int Pages, int Publisher, int Language, string Format, int Serie ,int Volume, string ReleaseDate, string Currency, double CoverPrice, 
            int Edition, string Status, string ReadingStatus, string Observations, string Synopsis, byte[] Cover, List<int> authors, List<int> genres,
            MySqlConnection Conn)
        {
            Insert = "INSERT INTO books " +
                "(category, bookTitle, bookSubTitle, bookOriginalTitle, bookOriginalSubTitle, isbn, pages, publisher, language, format, " +
                "serie, volume, releaseDate, currency,coverPrice, edition, status, readingStatus, observations, synopsis, cover, " +
                "bookDateInsert) " +
                "VALUES " +
                "(@category, @bookTitle, @bookSubTitle, @bookOriginalTitle, @bookOriginalSubTitle, @isbn, @pages, @publisher, @language, @format, " +
                "@Serie, @volume, @releaseDate, @currency, @coverPrice, @edition, @status, @readingStatus, @observations, @synopsis, @cover, " +
                "current_timestamp())";


            /*== Como inserir um uma tabela MxN se não sei o id em que o livro será inserido? ==*/

            try
            {
                MySqlCommand cmd = new MySqlCommand(Insert, Conn);

                cmd.Parameters.Add("@category", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@bookTitle", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@bookSubTitle", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@bookOriginalTitle", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@bookOriginalSubTitle", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@isbn", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@pages", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@publisher", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@language", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@format", MySqlDbType.Enum);
                cmd.Parameters.Add("@Serie", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@volume", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@releaseDate", MySqlDbType.Date);
                cmd.Parameters.Add("@currency", MySqlDbType.VarChar, 5);
                cmd.Parameters.Add("@coverPrice", MySqlDbType.Double);
                cmd.Parameters.Add("@edition", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@status", MySqlDbType.Enum);
                cmd.Parameters.Add("@readingStatus", MySqlDbType.Enum);
                cmd.Parameters.Add("@observations", MySqlDbType.MediumText);
                cmd.Parameters.Add("@synopsis", MySqlDbType.MediumText);
                cmd.Parameters.Add("@cover", MySqlDbType.MediumBlob);

                cmd.Parameters["@category"].Value = Category;
                cmd.Parameters["@bookTitle"].Value = Title;
                cmd.Parameters["@bookSubTitle"].Value = SubTitle;
                cmd.Parameters["@bookOriginalTitle"].Value = OriginalTitle;
                cmd.Parameters["@bookOriginalSubTitle"].Value = OriginalSubTitle;
                cmd.Parameters["@isbn"].Value = Isbn;
                cmd.Parameters["@pages"].Value = Pages;
                cmd.Parameters["@publisher"].Value = Publisher;
                cmd.Parameters["@language"].Value = Language;
                cmd.Parameters["@format"].Value = Format;
                cmd.Parameters["@Serie"].Value = Serie;
                cmd.Parameters["@volume"].Value = Volume;
                cmd.Parameters["@releaseDate"].Value = ReleaseDate;
                cmd.Parameters["@currency"].Value = Currency;
                cmd.Parameters["@coverPrice"].Value = CoverPrice;
                cmd.Parameters["@edition"].Value = Edition;
                cmd.Parameters["@status"].Value = Status;
                cmd.Parameters["@readingStatus"].Value = ReadingStatus;
                cmd.Parameters["@observations"].Value = Observations;
                cmd.Parameters["@synopsis"].Value = Synopsis;
                cmd.Parameters["@cover"].Value = Cover;

                if(cmd.ExecuteNonQuery() > 0)
                {
                    long lastId = cmd.LastInsertedId;
                    foreach (int a in authors)
                    {
                        String addBookAuthor = "INSERT INTO book_author (book_id, author_id) VALUES (" + lastId + "," + a + ")";
                        cmd = new MySqlCommand(addBookAuthor, Conn);
                        cmd.ExecuteNonQuery();
                    }

                    foreach(int g in genres)
                    {
                        String addBookGenre = "INSERT INTO book_genre (book_id, genre_id) VALUES (" + lastId + "," + g + ")";
                        cmd = new MySqlCommand(addBookGenre, Conn);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book inseted sucessfully!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
        }
    }
}
