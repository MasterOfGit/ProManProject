///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_Database.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProMan_Database.Model
{
    public class Login
    {
        public int LoginID { get; set; }
        public DateTime? LastLogin { get; set; }

        //[ForeignKey("Mitarbeiter")]
        //public int MitarbeiterID { get; set; }
        //public virtual Mitarbeiter Mitarbeiter { get; set; }

        [Index(IsUnique = true)]
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        public AufgabenGruppe LoginType { get; set; }

        public UserStatus UserStatus { get; set; }


        

    }
}
