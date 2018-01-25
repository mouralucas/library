using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entities
{
    class Publishers
    {
        public int Publisher_id { set; get; }
        public string PublisherName { set; get; }
        public string PublisherAbout { set; get; }
        public Countries PublisherCountry { set; get; }
        public byte[] PublisherLogo { set; get; }
        public DateTime PublisherDateInsert { set; get; }
        public DateTime PublisherDateUpdate { set; get; }
    }
}
