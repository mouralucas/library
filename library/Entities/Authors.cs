using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entities
{
    public class Authors
    {
        public int Author_id { set; get; }
        public string AuthorName { set; get; }
        public string AuthorAbout { set; get; }
        public Countries AuthorCountry { set; get; }
        public Languages AuthorLanguage { set; get; }
        public byte[] AuthorPhoto { set; get; }
        public DateTime AuthorDateInsert { set; get; }
        public DateTime AuthorDateUpdate{ set; get; }

    }
}
