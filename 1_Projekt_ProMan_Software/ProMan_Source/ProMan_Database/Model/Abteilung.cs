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
        public Werk Werk { get; set; }
        public string Fachbereich { get; set; }

    }
}
