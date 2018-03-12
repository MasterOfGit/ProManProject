using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Maschine
    {
        public int MaschineID { get; set; }
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string Inventarnummer { get; set; }
        public Technologie Technologie { get; set; }
        [StringLength(100)]
        public string Hersteller { get; set; }
        public MaschinenStatus Status { get; set; }
        [StringLength(100)]
        public string Version { get; set; }
        [StringLength(100)]
        public string Zeichnungsnummer { get; set; }
        [StringLength(100)]
        public string Standort { get; set; }
        public DateTime? Anschaffungsdatum { get; set; }
        public DateTime? Garantie { get; set; }     
        public EFImage Bild { get; set; }
        public virtual Arbeitsfolge Arbeitsfolge { get; set; }

    }
}
