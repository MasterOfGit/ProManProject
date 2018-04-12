using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class AuditDto
    {
        public int auditID { get; set; }

        public int abteilung { get; set; }
        public string auditart { get; set; }
        public DateTime termin { get; set; }
        public string status { get; set; }
        public string nacharbeiten { get; set; }
        public string terminturnus { get; set; }
        public string beurteilung { get; set; }


        //public DateTime? WartungsInterval { get; set; }
        //public string Status { get; set; }
        //public string Beschreibung { get; set; }
        //public UserDto User { get; set; }
        //public int InventarNummer { get; set; }
        //public string Zeichnungsnummer { get; set; }
    }
}
