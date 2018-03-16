using System.Collections.Generic;
using System.Linq;

namespace ProMan_BusinessLayer.Models.AdminPages
{
    public class AdminPageFertigungDto
    {
        public List<ExtendedAdminFertigungDto> Fertigungen { get; set; }

        public List<string> FertigungsBezeichnungen
        {
            get
            {
                return Fertigungen.Select(x => x.Name).Distinct().ToList();
            }
            set
            {
            }
        }

    }

    public class ExtendedAdminFertigungDto : FertigungDto
    {
        public List<string> Fertigungslinienbezeichnung
        {
            get
            {
                return Fertigungslinien.Select(x => x.Name).Distinct().ToList();
            }
            set
            {
            }
        }
    }

}
