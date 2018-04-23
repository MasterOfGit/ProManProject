///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using System.Collections.Generic;


namespace ProMan_BusinessLayer.Models
{
    public class FertigungslinieDto
    {
        public int fertigungslinieID { get; set; }
        public string fertigungslinienname { get; set; }
        public string fertigungstyp { get; set; }
        public int maschinenanzahl { get; set; } = 0;

        public List<ArbeitsfolgeDto> arbeitsfolgen { get; set; }
            
    }
}