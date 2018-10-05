using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    class Book
    {
        public int Book_Id { set; get; }
        public Category Category { set; get; }
        public string Title { set; get; }
        public string SubTitle { set; get; }
        public string OriginalTitle { set; get; }
        public string OriginalSubTitle { set; get; }
        public string Isbn { set; get; }
        public Author Authors { set; get; }
        public Genre Genres { set; get; }
        public int Volume { set; get; }
        public Serie Serie { set; get; }
        public int Pages { set; get; }
        public Language Language { set; get; }
        public string ReleaseDate { set; get; } //ver se usar date é melhor
        public double CoverPrice { set; get; }
        public string Format { set; get; }
        public string Status { set; get; }
        public int Edition { set; get; }
        public string ReadingStatus { set; get; }
        public Publisher Publisher { set; get; }
        public String Currency { set; get; }
        public byte[] Cover { set; get; }
        public string Synopsis { set; get; }
        public string Observations { set; get; }
        public DateTime BookDateInsert { set; get; }
        public DateTime BookDateUpdate { set; get; }
    }
}
