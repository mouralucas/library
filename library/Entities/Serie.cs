using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    class Serie
    {
        public int Serie_Id { set; get; }
        public string SerieName { set; get; }
        public int SerieVolumes { set; get; }
        public string SerieCategory { set; get; }
        public int SerieCategory_id { set; get; }
        public string SerieSynopsis { set; get; }
    }
}
