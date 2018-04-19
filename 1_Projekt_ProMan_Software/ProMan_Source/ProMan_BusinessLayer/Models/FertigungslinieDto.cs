﻿using System.Collections.Generic;


namespace ProMan_BusinessLayer.Models
{
    public class FertigungslinieDto
    {
        public int fertigungslinieID { get; set; }
        public string fertigungslinienname { get; set; }
        public int maschinenanzahl { get; set; }

        public List<ArbeitsfolgeDto> arbeitsfolgen { get; set; }
            
    }
}