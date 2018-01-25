using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entities
{
    public class Countries
    {
        public int Country_id { set; get; }
        public string CountryName { set; get; }
        public string ShowCountry { set; get; }
        public byte[] CountryFlag { set; get; }
        public DateTime CountryDateInsert { set; get; }
        public DateTime CountryDateUpdate { set; get; }
    }
}
