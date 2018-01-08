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

        public int InventarNummer { get; set; }
        public string Zeichnungsnummer { get; set; }
        public virtual MaschineType Type { get; set; }
        public virtual MaschineHersteller Hersteller { get; set; }
        public DateTime? Baujahr { get; set; }
        public DateTime? Garantie { get; set; }
        public MaschinenStatus MaschinenStatus { get; set; }
        public Ruesten Ruesten { get; set; }

        public virtual Wartung Wartung { get; set; }
        public virtual ICollection<Reparatur> Reparaturen { get; set; }

    }
}
