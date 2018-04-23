///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////

namespace ProMan_BusinessLayer.Models
{
    public class UserAnfrageDto
    {
        public int userId { get; set; }
        public string userGrund { get; set; }
        public string userNachricht { get; set; }
        public string userAnfrageStatus { get; set; }
    }
}
