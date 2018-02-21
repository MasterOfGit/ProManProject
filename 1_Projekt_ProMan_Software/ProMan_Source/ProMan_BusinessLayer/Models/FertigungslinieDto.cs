using System.Collections.Generic;


namespace ProMan_BusinessLayer.Models
{
    public class FertigungslinieDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FertigungName { get; set; }
        public List<ArbeitsfolgeDto> Arbeitsfolgen { get; set; }
            
    }
}