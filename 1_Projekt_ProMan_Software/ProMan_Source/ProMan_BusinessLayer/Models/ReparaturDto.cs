using System;

namespace ProMan_BusinessLayer.Models
{
    public class ReparaturDto
    {
        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime Dauer { get; set; }
        public string Status { get; set; }
        public UserDto User { get; set; }
        public int InventarNummer { get; set; }
        public string Zeichnungsnummer { get; set; }
    }
}