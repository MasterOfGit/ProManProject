using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProMan_BusinessLayer.Models
{
    public class WartungDto
    {
        public int ID { get; set; }
        public DateTime? WartungsInterval { get; set; }
        public string Status { get; set; }
        public string Beschreibung { get; set; }
        public UserDto User { get; set; }
        public int InventarNummer { get; set; }
        public string Zeichnungsnummer { get; set; }
    }
}