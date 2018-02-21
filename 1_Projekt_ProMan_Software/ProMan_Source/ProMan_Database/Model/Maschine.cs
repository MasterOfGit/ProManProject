using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Maschine
    {
        public int MaschineID { get; set; }
        public ICollection<Technologie> Technologien { get; set; }
        public string Hersteller { get; set; }
        public string Version { get; set; }
        public DateTime? Anschaffungsdatum { get; set; }
        public DateTime? Garantie { get; set; }
        public string Zeichnungsnummer { get; set; }
        public string Standort { get; set; }

        public EFImage Bild { get; set; }
    }
}
