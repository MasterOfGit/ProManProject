using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Abteilung
    {
        public int AbteilungID { get; set; }
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string Bezeichnung { get; set; }
        [StringLength(100)]
        public string Ort { get; set; }
        public ICollection<Fertigung> Fertigungen { get; set; }

        public Werk Werk { get; set; }
    }
}
