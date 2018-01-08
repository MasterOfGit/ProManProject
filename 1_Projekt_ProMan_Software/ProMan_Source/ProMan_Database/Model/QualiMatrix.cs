using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class QualiMatrix
    {
        public int QualiMatrixID { get; set; }
        public int Wissenstand { get; set; }

        public virtual User User { get; set; }
        public virtual Maschine Maschine { get; set; }
    }
}
