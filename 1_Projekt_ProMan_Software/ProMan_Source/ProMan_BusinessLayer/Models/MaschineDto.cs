using System;

namespace ProMan_BusinessLayer.Models
{
    public class MaschineDto
    {
        public int ID { get; set; }
        public string Inventarnummer { get; set; }
        public string Technologie { get; set; }
        public string Hersteller { get; set; }
        public string Status { get; set; }
        public string Version { get; set; }
        public string Zeichnungsnummer { get; set; }
        public string Standort { get; set; }
        public DateTime? Anschaffungsdatum { get; set; }
        public DateTime? Garantie { get; set; }
    }
}