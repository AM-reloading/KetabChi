using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1K.ViewModels
{
    class TrustViewModel
    {
        public int trust_id { get; set; }
        public string trust_moshtarekin { get; set; }
        public string trust_books { get; set; }
        public string trust_timestart { get; set; }
        public string trust_timeend { get; set; }
        public int trust_later { get; set; }
    }
}
