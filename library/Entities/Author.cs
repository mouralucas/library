using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Author
    {
        public int Author_id { set; get; }
        public string AuthorName { set; get; }
        public string AuthorAbout { set; get; }
        public Country AuthorCountry { set; get; }
        public Language AuthorLanguage { set; get; }
        public Category AuthorCategory { set; get; }
        public byte[] AuthorPhoto { set; get; }
        public DateTime AuthorDateInsert { set; get; }
        public DateTime AuthorDateUpdate{ set; get; }

    }
}
