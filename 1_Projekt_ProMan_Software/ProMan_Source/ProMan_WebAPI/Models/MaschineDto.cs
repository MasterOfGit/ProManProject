using ProMan_Database.Enums;
using System;

namespace ProMan_WebAPI.Models
{
    public class MaschineDto
    {
        public int InventarNummer { get; set; }
        public string Zeichnungsnummer { get; set; }
        public MaschinenStatus MaschinenStatus { get; set; }
        public string Type { get; set; }
        public string Hersteller { get; set; }
        public DateTime Baujahr { get; set; }
        public DateTime Garantie { get; set; }
    }
}