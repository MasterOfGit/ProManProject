using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
     public class BauteilDto
    {
        public int ID { get; set; }
        public string Teilart { get; set; }
        public string Version { get; set; }
        public string Verwendungsort { get; set; }
        public List<BauteilDto> Abhaengigkeiten { get; set; }
    }
}
