///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////


namespace ProMan_BusinessLayer.Models
{
    public class ProduktionsplanDto
    {
        public int folgenummer { get; set; }
        public string bauteilname { get; set; }
        public string bauteilindex { get; set; }
        public string bauteilverwendung { get; set; }
        public int prodMenge { get; set; }
        public string status { get; set; }
    }
}
