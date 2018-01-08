using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Werkzeug
    {
        public int WerkzeugID { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public string Technologie { get; set; }
    }
}
