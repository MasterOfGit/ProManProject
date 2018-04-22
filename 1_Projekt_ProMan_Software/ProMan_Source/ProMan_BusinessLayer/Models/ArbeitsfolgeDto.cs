using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class ArbeitsfolgeDto
    {
        public int ID { get; set; }
        public string ArbeitsfolgeName { get; set; }
        public List<MaschineDto> Maschinen { get; set; }
        public List<BauteilDto> Bauteile { get; set; }
        public string Arbeitsplaene { get; set; }
        public StatusArt Status { get; set; }
    }
}
