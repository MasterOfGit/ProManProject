using System;

namespace ProMan_BusinessLayer.Models
{
    public class MaschineDto
    {
        public int maschinenID { get; set; }
        public string maschinenInventarNummer { get; set; }
        public string technologie { get; set; }
        public string hersteller { get; set; }
        public string status { get; set; }
        public int abteilungsId { get; set; }
        public string standort { get; set; }

        public string Version { get; set; }
        public string Zeichnungsnummer { get; set; }
        
        public DateTime? Anschaffungsdatum { get; set; }
        public DateTime? Garantie { get; set; }



        //additional Data
        public string AbteilungsName { get; set; }
        public string FertigungsName { get; set; }
        public string FertigungslinienName { get; set; }
        public string Arbeitsfolge { get; set; }

    }
}