using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Produktionsprogramm
    {
        public int ProduktionsprogrammID { get; set; }
        public Bauteil Bauteil { get; set; }
        public int Sollstueckzahl { get; set; }
        public ProduktionStatus Status { get; set; }
    }
}
