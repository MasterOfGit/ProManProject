using System.Collections.Generic;


namespace ProMan_WebAPI.Models
{
    public class FertigungslinieDto
    {
        public List<string> Werkstücktraeger { get; set; }
        public List<MaschineDto> Maschinen { get; set; }
            
    }
}