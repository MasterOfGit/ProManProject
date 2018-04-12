using System.Collections.Generic;


namespace ProMan_BusinessLayer.Models
{
    public class FertigungslinieDto
    {
        public int fertigungslinieID { get; set; }
        public string fertigunglinenname { get; set; }
        
        public List<ArbeitsfolgeDto> arbeitsfolgen { get; set; }
            
    }
}