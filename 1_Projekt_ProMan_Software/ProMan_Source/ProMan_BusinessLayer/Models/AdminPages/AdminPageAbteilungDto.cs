using System.Collections.Generic;


namespace ProMan_BusinessLayer.Models.AdminPages
{
    public class AdminPageAbteilungDto
    {
        public List<AbteilungDto> Abteilungen { get; set; }

        public List<string> Abteilungsnamen { get; set; }
        public List<string> Fertigungsnamen { get; set; }

    }
}
