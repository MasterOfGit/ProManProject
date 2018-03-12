using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Audit
    {
        public int AuditID { get; set; }
        public DateTime? Beginntermin { get; set; }
        public DateTime? Endtermin { get; set; }
        [StringLength(100)]
        public string Aufgabe { get; set; }
        [StringLength(100)]
        public int Abschlussnote { get; set; }
        [StringLength(100)]
        public string Bereich { get; set; }
        public ICollection<Mitarbeiter> Zuständigkeit { get; set; }
    }
}
