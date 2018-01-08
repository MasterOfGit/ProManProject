using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Bauteil
    {
        public int BauteilID { get; set; }
        public int Zeichnungsnummer { get; set; }
        public string Version { get; set; }
        public DateTime? ProduktionsBeginn { get; set; }
    }
}
