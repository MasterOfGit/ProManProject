using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Mitarbeiter
    {
        public int MitarbeiterID { get; set; }
        public bool Active { get; set; }
        public Anrede Namenszusatz { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set;}
        public string Festnetz { get; set; }
        public string Mobil { get; set; }
        public string eMail { get; set; }
        public string Bemerkung { get; set; }

        public EFImage Passbild { get; set; }
        public Login Login { get; set; }

        
    }
}
