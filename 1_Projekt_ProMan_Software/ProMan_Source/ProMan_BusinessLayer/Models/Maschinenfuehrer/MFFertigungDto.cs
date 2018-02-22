using ProMan_Database.Enums;

namespace ProMan_BusinessLayer.Models.Maschinenfuehrer
{
    public class MFFertigungDto
    {
        public string Name { get; set; }
        public string Bereich { get; set; }
        public Fertigungstype Type { get; set; }

        public string Ort { get; set; }
        public string Abteilung { get; set; }
        public string Werk { get; set; }

        public int BauteileCount { get; set; }
        public int ReparaturenCount { get; set; }
        public int WartungenCount { get; set; }
        public int AuditsCount { get; set; }
    }
}
