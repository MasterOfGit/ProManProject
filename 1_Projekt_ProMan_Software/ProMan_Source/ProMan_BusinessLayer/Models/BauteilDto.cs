using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
     public class BauteilDto
    {
        public int bauteileID { get; set; }
        public string bauteilNummer { get; set; }
        public string bauteilIndex { get; set; }
        public string bauteilArt { get; set; }
        public string bauteilVersion { get; set; }
        public string bauteilStatus { get; set; }
        
        public int bauteilIDNachfolger { get; set; }

    }
}
