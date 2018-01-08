using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Wartung
    {
        public int WartungID { get; set; }
        public DateTime? WartungsInterval { get; set; }
        public string Status { get; set; }
        public string Beschreibung { get; set; }
        public User User { get; set; }
        public int MaschineID { get; set; }
    }
}
