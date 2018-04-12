using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class InstandhaltungsAuftragDto
    {
        public int instandhaltungID { get; set; }
        public int abteilung { get; set; }
        public string fachrichtung { get; set; }
        public string fachbereich { get; set; }
        public string machinenIventarnummer { get; set; }
        public string thema { get; set; }
        public string fehlertext { get; set; }
        public string auftragsstatus { get; set; }
    }
}
