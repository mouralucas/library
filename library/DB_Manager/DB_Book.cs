using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Library.Entities;

namespace Library.DB_Manager
{
    class DB_Book
    {
        /*----- Strings that defines the queries -----*/
        private String Insert;
        private String RemoveById;
        private String Retrieve;
        private String CountString;

        /*----- Others Variables -----*/
        private int count = -1;

        public int Count(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM books";
            MySqlCommand cmd = new MySqlCommand(CountString, conn);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;

        }

        public bool InsertBook(int Category_Id, string Title, string SubTitle, string OriginalTitle, string OriginalSubTitle, string Isbn, 
            int Pages, int Publisher, int Language_Id, string Format, int Serie_Id ,int Volume, string ReleaseDate, string Currency, double CoverPrice, 
            int Edition, string Status, string ReadingStatus, string Observations, string Synopsis, byte[] Cover, List<int> authors, List<int> genres,
            MySqlConnection Conn)
        {
            Insert = "INSERT INTO books " +
                "(category_id, bookTitle, bookSubTitle, bookOriginalTitle, bookOriginalSubTitle, isbn, pages, publisher, language, format, " +
                "serie, volume, releaseDate, currency,coverPrice, edition, status, readingStatus, observations, synopsis, cover, " +
                "bookDateInsert) " +
                "VALUES " +
                "(@category_id, @bookTitle, @bookSubTitle, @bookOriginalTitle, @bookOriginalSubTitle, @isbn, @pages, @publisher, @language, @format, " +
                "@Serie, @volume, @releaseDate, @currency, @coverPrice, @edition, @status, @readingStatus, @observations, @synopsis, @cover, " +
                "current_timestamp())";

            try
            {
                MySqlCommand Cmd = new MySqlCommand(Insert, Conn);

                Cmd.Parameters.Add("@category_id", MySqlDbType.Int32, 11);
                Cmd.Parameters.Add("@bookTitle", MySqlDbType.VarChar, 45);
                Cmd.Parameters.Add("@bookSubTitle", MySqlDbType.VarChar, 45);
                Cmd.Parameters.Add("@bookOriginalTitle", MySqlDbType.VarChar, 45);
                Cmd.Parameters.Add("@bookOriginalSubTitle", MySqlDbType.VarChar, 45);
                Cmd.Parameters.Add("@isbn", MySqlDbType.VarChar, 45);
                Cmd.Parameters.Add("@pages", MySqlDbType.Int32, 11);
                Cmd.Parameters.Add("@publisher", MySqlDbType.Int32, 11);
                Cmd.Parameters.Add("@language", MySqlDbType.Int32, 11);
                Cmd.Parameters.Add("@format", MySqlDbType.Enum);
                Cmd.Parameters.Add("@Serie", MySqlDbType.Int32, 11);
                Cmd.Parameters.Add("@volume", MySqlDbType.Int32, 11);
                Cmd.Parameters.Add("@releaseDate", MySqlDbType.Date);
                Cmd.Parameters.Add("@currency", MySqlDbType.VarChar, 5);
                Cmd.Parameters.Add("@coverPrice", MySqlDbType.Double);
                Cmd.Parameters.Add("@edition", MySqlDbType.Int32, 11);
                Cmd.Parameters.Add("@status", MySqlDbType.Enum);
                Cmd.Parameters.Add("@readingStatus", MySqlDbType.Enum);
                Cmd.Parameters.Add("@observations", MySqlDbType.MediumText);
                Cmd.Parameters.Add("@synopsis", MySqlDbType.MediumText);
                Cmd.Parameters.Add("@cover", MySqlDbType.MediumBlob);

                Cmd.Parameters["@category_id"].Value = Category_Id;
                Cmd.Parameters["@bookTitle"].Value = Title;
                Cmd.Parameters["@bookSubTitle"].Value = SubTitle;
                Cmd.Parameters["@bookOriginalTitle"].Value = OriginalTitle;
                Cmd.Parameters["@bookOriginalSubTitle"].Value = OriginalSubTitle;
                Cmd.Parameters["@isbn"].Value = Isbn;
                Cmd.Parameters["@pages"].Value = Pages;
                Cmd.Parameters["@publisher"].Value = Publisher;
                Cmd.Parameters["@language"].Value = Language_Id;
                Cmd.Parameters["@format"].Value = Format;
                Cmd.Parameters["@Serie"].Value = Serie_Id;
                Cmd.Parameters["@volume"].Value = Volume;
                Cmd.Parameters["@releaseDate"].Value = ReleaseDate;
                Cmd.Parameters["@currency"].Value = Currency;
                Cmd.Parameters["@coverPrice"].Value = CoverPrice;
                Cmd.Parameters["@edition"].Value = Edition;
                Cmd.Parameters["@status"].Value = Status;
                Cmd.Parameters["@readingStatus"].Value = ReadingStatus;
                Cmd.Parameters["@observations"].Value = Observations;
                Cmd.Parameters["@synopsis"].Value = Synopsis;
                Cmd.Parameters["@cover"].Value = Cover;

                if(Cmd.ExecuteNonQuery() > 0)
                {
                    long lastId = Cmd.LastInsertedId;
                    foreach (int a in authors)
                    {
                        String addBookAuthor = "INSERT INTO book_author (book_id, author_id) VALUES (" + lastId + "," + a + ")";
                        Cmd = new MySqlCommand(addBookAuthor, Conn);
                        Cmd.ExecuteNonQuery();
                    }

                    foreach(int g in genres)
                    {
                        String addBookGenre = "INSERT INTO book_genre (book_id, genre_id) VALUES (" + lastId + "," + g + ")";
                        Cmd = new MySqlCommand(addBookGenre, Conn);
                        Cmd.ExecuteNonQuery();
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

        public List<Book> SearchAllBooks(MySqlConnection conn)
        {

        }
    }
}
