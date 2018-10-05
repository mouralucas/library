using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Genre
    {
        public int Genre_Id { set; get; }
        public string GenreName { set; get; }
        public DateTime GenreDateInsert { set; get; }
        public DateTime GenreDateUpdate { set; get; }

        public Genre() { }
    }
}
