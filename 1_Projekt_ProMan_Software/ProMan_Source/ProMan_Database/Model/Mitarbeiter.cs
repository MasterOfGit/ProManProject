using ProMan_Database.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProMan_Database.Model
{
    public class Mitarbeiter
    {
        public int MitarbeiterID { get; set; }
        public bool Active { get; set; }
        public Anrede Namenszusatz { get; set; }
        [StringLength(50)]
        public string Vorname { get; set; }
        [StringLength(50)]
        public string Nachname { get; set;}
        [StringLength(50)]
        public string Festnetz { get; set; }
        [StringLength(50)]
        public string Mobil { get; set; }
        [StringLength(50)]
        public string eMail { get; set; }
        [StringLength(255)]
        public string Bemerkung { get; set; }

        public EFImage Passbild { get; set; }

        public Login Login { get; set; }

        public virtual ICollection<Nachricht> Nachrichten { get; set; }

        
    }
}
