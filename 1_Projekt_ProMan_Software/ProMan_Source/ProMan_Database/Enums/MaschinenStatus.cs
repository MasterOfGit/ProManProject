using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Enums
{
    public enum MaschinenStatus
    {
        Produktion,
        Umbau,
        Reparatur,
        Wartung, 
        Ersatz,
        NullSerie,
        Optimierung,
        Defekt,
        Sonstige
    }
}
