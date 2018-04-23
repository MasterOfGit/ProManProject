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

namespace ProMan_BusinessLayer.Models
{
    public class BauteilVerwendungDto
    {
        public int fertingungsLinienID { get; set; }
        public int bauteileID { get; set; }
        public string technologie { get; set; }
        public string bearbeitungen { get; set; }

        public int bearbeitungsschritt { get; set; }
        public string verwendungsZweck { get; set; }
    }
}
