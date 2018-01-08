using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Hilfsmittel
    {
        public int HilfsmittelID { get; set; }
        public string Art { get; set; }
        public string Beschreibung { get; set; }
        public bool Gefahrgut { get; set; }
    }
}
