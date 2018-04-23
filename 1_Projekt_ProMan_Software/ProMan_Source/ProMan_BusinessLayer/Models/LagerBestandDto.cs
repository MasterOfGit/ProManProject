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
    public class LagerBestandDto
    {
        public int bauteilID { get; set; }
        public string bauteilname { get; set; }
        public string bauteilindex { get; set; }
        public string bauteilverwendung { get; set; }
        public int minBestand { get; set; }
        public int istBestand { get; set; }
        public string lagerplatz { get; set; }

    }
}
