using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models.Maschinenfuehrer
{
    public class MFAbteilungOverviewDto
    {
        public string Abteilungsname { get; set; }
        public List<MFFertigungDto> Fertigungen { get; set; }
    }
}
