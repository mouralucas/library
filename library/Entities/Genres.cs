using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entities
{
    public class Genres
    {
        public int Genre_id { set; get; }
        public string GenreName { set; get; }
        public DateTime GenreDateInsert { set; get; }
        public DateTime GenreDateUpdate { set; get; }

        public Genres() { }
    }
}
