///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Sonderaufgabe
    {
        public int SonderaufgabeID { get; set; }
        public ICollection<Wartung> Wartungen { get; set; }
        public ICollection<Audit> Audits { get; set; }
    }
}
