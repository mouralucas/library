using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    class Publisher
    {
        public int Publisher_Id { set; get; }
        public string PublisherName { set; get; }
        public string PublisherAbout { set; get; }
        public Country PublisherCountry { set; get; }
        public Category PublisherCategory { set; get; }
        public byte[] PublisherLogo { set; get; }
        public DateTime PublisherDateInsert { set; get; }
        public DateTime PublisherDateUpdate { set; get; }
    }
}
