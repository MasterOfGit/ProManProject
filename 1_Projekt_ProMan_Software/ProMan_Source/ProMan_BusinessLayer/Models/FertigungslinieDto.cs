using System.Collections.Generic;


namespace ProMan_BusinessLayer.Models
{
    public class FertigungslinieDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> Werkstücktraeger { get; set; }
        public List<MaschineDto> Maschinen { get; set; }
            
    }
}