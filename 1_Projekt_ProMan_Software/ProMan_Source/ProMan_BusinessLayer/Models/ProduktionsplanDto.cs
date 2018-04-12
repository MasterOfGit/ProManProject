using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class ProduktionsplanDto
    {
        public int folgenummer { get; set; }
        public string bauteilname { get; set; }
        public string bauteilindex { get; set; }
        public string bauteilverwendung { get; set; }
        public int prodMenge { get; set; }
        public string status { get; set; }
    }
}
