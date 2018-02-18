using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Abteilung
    {
        public int AbteilungID { get; set; }
        public string Bezeichnung { get; set; }
        public string Werk { get; set; }
        public string Ort { get; set; }
        public ICollection<Fertigung> Fertigungen { get; set; }
    }
}
