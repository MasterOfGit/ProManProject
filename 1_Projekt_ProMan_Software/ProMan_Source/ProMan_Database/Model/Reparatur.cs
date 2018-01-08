using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Reparatur
    {
        public int ReparaturID { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Dauer { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
        public virtual Maschine Maschine { get; set; }
    }
}
