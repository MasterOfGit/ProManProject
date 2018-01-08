using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Ruesten
    {
        public int RuestenID { get; set; }
        public DateTime? Standzeit { get; set; }

        public ICollection<Hilfsmittel> Hilfsmittel { get; set; }
        public ICollection<Werkzeug> Werkzeuge { get; set; }

        public int MaschineID { get; set; }
    }
}
