using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entities
{
    public class Languages
    {
        public int Language_id { set; get; }
        public string LanguageName { set; get; }
        public string ShowLanguage { set; get; }
        public DateTime LanguageDateInsert { set; get; }
        public DateTime LanguageDateUpdate{ set; get; }
    }
}
