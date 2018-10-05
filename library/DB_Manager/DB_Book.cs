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

        private Book Book;
        private Author Author;
        private Category Category;
        private Serie Serie;
        private Publisher Publisher;
        private Genre Genre;
        private Language Language;



        /*----- Others Variables -----*/
        private int Count = -1;

        public int CountRows(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM books";
            MySqlCommand cmd = new MySqlCommand(CountString, conn);

            Count = Convert.ToInt32(cmd.ExecuteScalar());

            return Count;

        }

        public bool InsertBook(int Category_Id, string Title, string SubTitle, string OriginalTitle, string OriginalSubTitle, string Isbn,
            int Pages, int Publisher, int Language_Id, string Format, int Serie_Id, int Volume, string ReleaseDate, string Currency, double CoverPrice,
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

                if (Cmd.ExecuteNonQuery() > 0)
                {
                    long lastId = Cmd.LastInsertedId;
                    foreach (int a in authors)
                    {
                        String addBookAuthor = "INSERT INTO book_author (book_id, author_id) VALUES (" + lastId + "," + a + ")";
                        Cmd = new MySqlCommand(addBookAuthor, Conn);
                        Cmd.ExecuteNonQuery();
                    }

                    foreach (int g in genres)
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

        public List<Book> ListAll(MySqlConnection Conn)
        {
            Retrieve = "SELECT " +
                "   b.*, " +
                "   a.author_id, " +
                "   a.authorName, " +
                "   c.category_id, " +
                "   c.description, " +
                "   s.serie_id, " +
                "   s.serieName, " +
                "   p.publisher_id, " +
                "   p.publisherName, " +
                "   g.genre_id, " +
                "   g.genreName, " +
                "   l.language_id, " +
                "   l.languageName " +
                "FROM books b " +
                "INNER JOIN book_author ba " +
                "   ON b.book_id = ba.book_id " +
                "INNER JOIN authors a " +
                "   ON a.author_id = ba.author_id " +
                "INNER JOIN category c " +
                "   ON b.category_id = c.category_id " +
                "INNER JOIN series s " +
                "   ON b.serie = s.serie_id " +
                "INNER JOIN publishers p " +
                "   ON b.publisher = p.publisher_id " +
                "INNER JOIN book_genre bg " +
                "   ON b.book_id = bg.book_id " +
                "INNER JOIN genres g " +
                "   ON g.genre_id = bg.genre_id " +
                "INNER JOIN languages l " +
                "   ON b.language = l.language_id";

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);
            return SetBooks(Cmd);


        }

        private List<Book> SetBooks(MySqlCommand Cmd)
        {
            List<Book> BookList = new List<Book>();
            MySqlDataReader DataRead = Cmd.ExecuteReader();
            BookList.Clear();

            while (DataRead.Read())
            {
                Author = new Author
                {
                    Author_Id = Convert.IsDBNull(DataRead["author_id"]) ? -1 : Convert.ToInt32(DataRead["author_id"]),
                    AuthorName = Convert.IsDBNull(DataRead["authorName"]) ? "" : DataRead["authorName"].ToString()
                };

                Category = new Category()
                {
                    Category_Id = Convert.IsDBNull(DataRead["category_id"]) ? -1 : Convert.ToInt32(DataRead["category_id"]),
                    CategoryName = Convert.IsDBNull(DataRead["category"]) ? "" : DataRead["category"].ToString()
                };

                Serie = new Serie
                {
                    Serie_Id = Convert.IsDBNull(DataRead["serie_id"]) ? -1 : Convert.ToInt32(DataRead["serie_id"]),
                    SerieName = Convert.IsDBNull(DataRead["serieName"]) ? "" : (DataRead["serieName"]).ToString()
                };

                Publisher = new Publisher()
                {
                    Publisher_Id = Convert.IsDBNull(DataRead["publisher_id"]) ? -1 : Convert.ToInt32(DataRead["publisher_id"]),
                    PublisherName = Convert.IsDBNull(DataRead["publisherName"]) ? "" : DataRead["publisherName"].ToString()
                };

                Genre = new Genre()
                {
                    Genre_Id = Convert.IsDBNull(DataRead["genre_id"]) ? -1 : Convert.ToInt32(DataRead["genre_id"]),
                    GenreName = Convert.IsDBNull(DataRead["genreName"]) ? "" : DataRead["genreName"].ToString()
                };

                Language = new Language()
                {
                    Language_Id = Convert.IsDBNull(DataRead["language_id"]) ? -1 : Convert.ToInt32(DataRead["language_id"]),
                    LanguageName = Convert.IsDBNull(DataRead["languageName"]) ? "" : DataRead["languageName"].ToString()
                };

                Book = new Book()
                {
                    Book_Id = Convert.IsDBNull(DataRead["book_id"]) ? -1 : Convert.ToInt32(DataRead["book_id"]),
                    Category = Category,
                    Authors = Author,
                    Title = Convert.IsDBNull(DataRead["bookTitle"]) ? "" : DataRead["bookTitle"].ToString(),
                    SubTitle = Convert.IsDBNull(DataRead["bookSubTitle"]) ? "" : DataRead["bookSubTitle"].ToString(),
                    OriginalTitle = Convert.IsDBNull(DataRead["bookOriginalTitle"]) ? "" : DataRead["bookOriginalTitle"].ToString(),
                    OriginalSubTitle = Convert.IsDBNull(DataRead["bookOriginalSubTitle"]) ? "" : DataRead["bookOriginalSubTitle"].ToString(),
                    Serie = Serie,
                    Volume = Convert.IsDBNull(DataRead["volume"]) ? -1 : Convert.ToInt32(DataRead["volume"]),
                    Pages = Convert.IsDBNull(DataRead["pages"]) ? -1 : Convert.ToInt32(DataRead["pages"]),
                    ReleaseDate = Convert.IsDBNull(DataRead["releaseDate"]) ? "" : DataRead["releaseDate"].ToString(),
                    Language = Language,
                    Isbn = Convert.IsDBNull(DataRead["isbn"]) ? "" : DataRead["isbn"].ToString(),
                    Publisher = Publisher,
                    Currency = Convert.IsDBNull(DataRead["currency"]) ? "" : DataRead["currency"].ToString(),
                    CoverPrice = Convert.IsDBNull(DataRead["coverPrice"]) ? -1 : Convert.ToDouble(DataRead["coverPrice"]),
                    Synopsis = Convert.IsDBNull(DataRead["synopsis"]) ? "" : DataRead["synopsis"].ToString(),
                    Observations = Convert.IsDBNull(DataRead["observations"]) ? "" : DataRead["observations"].ToString(),
                    Cover = Convert.IsDBNull(DataRead["cover"]) ? null : (byte[])DataRead["cover"],
                    Edition = Convert.IsDBNull(DataRead["edition"]) ? -1 : Convert.ToInt32(DataRead["edition"]),
                    Format = Convert.IsDBNull(DataRead["format"]) ? "" : DataRead["format"].ToString(),
                    Status = Convert.IsDBNull(DataRead["status"]) ? "" : DataRead["status"].ToString(),
                    Genres = Genre,
                    ReadingStatus = Convert.IsDBNull(DataRead["readingStatus"]) ? "" : DataRead["readingStatus"].ToString()
                };

                BookList.Add(Book);
            }

            DataRead.Close();
            return BookList;
        }

    }
}
