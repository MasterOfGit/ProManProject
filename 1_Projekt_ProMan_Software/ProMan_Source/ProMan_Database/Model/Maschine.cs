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
        public string Inventarnummer { get; set; }
        public Technologie Technologie { get; set; }
        public string Hersteller { get; set; }
        public MaschinenStatus Status { get; set; }
        public string Version { get; set; }
        public string Zeichnungsnummer { get; set; }
        public string Standort { get; set; }
        public DateTime? Anschaffungsdatum { get; set; }
        public DateTime? Garantie { get; set; }     
        public EFImage Bild { get; set; }
    }
}
