using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class WerkDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Ort { get; set; }
        public List<AbteilungDto> Abteilungen { get; set; }
    }
}
