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
        public int arbeitsfolgeID { get; set; }
        public string arbeitplan { get; set; }
        public int maschineID { get; set; }
        public string technologie { get; set; }
        public int bauteilID { get; set; }
        public int Order { get; set; }
        public string Arbeitsplaene { get; set; }
        public StatusArt Status { get; set; }
        public int fertigungslinieID { get; set; }
        public string fertigunglinenname { get; set; }
        public string fertigungstyp { get; set; }
    }
}
