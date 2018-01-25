using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entities
{
    class Series
    {
        public int Serie_id { set; get; }
        public string SerieName { set; get; }
        public int SerieVolumes { set; get; }
        public string SerieType { set; get; }
        public string SerieSynopsis { set; get; }
    }
}
