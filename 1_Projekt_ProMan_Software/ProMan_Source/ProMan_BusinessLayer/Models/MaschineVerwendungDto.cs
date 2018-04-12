using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class MaschineVerwendungDto
    {
        public int maschinenID { get; set; }
        public int bauteileID { get; set; }
        public int abteilungID { get; set; }
        public int fertigungID { get; set; }
        public int fertigungslinieID { get; set; }
        public int arbeitsfolge { get; set; }
    }
}
