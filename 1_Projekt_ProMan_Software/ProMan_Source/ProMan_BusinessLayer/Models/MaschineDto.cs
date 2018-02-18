using ProMan_Database.Enums;
using System;
using System.Collections.Generic;

namespace ProMan_BusinessLayer.Models
{
    public class MaschineDto
    {
        public int ID { get; set; }
        public List<Technologie> Technologien { get; set; }
        public string Hersteller { get; set; }
        public string Version { get; set; }
        public DateTime? Anschaffungsdatum { get; set; }
        public DateTime? Garantie { get; set; }
        public string Zeichnungsnummer { get; set; }
        public string Standort { get; set; }

    }
}