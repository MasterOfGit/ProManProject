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
    public class Supermarkt
    {
        public int SupermarktID { get; set; }
        public Bauteil Bauteil { get; set; }
        public int Iststueckzahl { get; set; }
    }
}
