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
    public class Werk
    {
        public int WerkID { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public int Postleitzahl { get; set; }
        public string Ort { get; set; }
    }
}
