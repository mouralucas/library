using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    class Book
    {
        public int Book_id { set; get; }
        public string BookTitle { set; get; }
        public string BookSubTitle { set; get; }
        public string BookOriginalTitle { set; get; }
        public string BookOriginalSubTitle { set; get; }
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
        public byte[] Cover { set; get; }
        public string Synopsis { set; get; }
        public string Observations { set; get; }
        public DateTime BookDateInsert { set; get; }
        public DateTime BookDateUpdate { set; get; }
    }
}
