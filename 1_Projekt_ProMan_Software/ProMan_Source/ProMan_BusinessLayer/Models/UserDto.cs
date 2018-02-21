using ProMan_Database.Enums;

namespace ProMan_BusinessLayer.Models
{
    public class UserDto
    {
        public int ID { get; set; }
        public bool Active { get; set; }
        public Anrede Namenszusatz { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Festnetz { get; set; }
        public string Mobil { get; set; }
        public string eMail { get; set; }
        public string Bemerkung { get; set; }
    }
}