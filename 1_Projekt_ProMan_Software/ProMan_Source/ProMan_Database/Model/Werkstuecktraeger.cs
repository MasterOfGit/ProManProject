using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Werkstuecktraeger
    {
        public int WerkstuecktraegerID { get; set; }
        public Bauteil CurBauteil { get; set; }
        public Bauteilstatus BauteilStatus { get; set; }
    }
}
