using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_Database;
using ProMan_Database.Enums;
using System;
using System.Linq;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseUpdate : IUpdateDataProvider
    {

        ProManContext dbcontext = new ProManContext();
        #region updates

        public bool UpdateBauteilDto(BauteilDto data, int id)
        {
            var bauteil = dbcontext.Bauteile.FirstOrDefault(x => x.BauteilID == id);

            bauteil.NachfolderId = data.bauteilIDNachfolger;
            bauteil.Index = data.bauteilIndex;
            bauteil.Nummer = data.bauteilNummer;
            bauteil.Status = data.bauteilStatus;
            bauteil.Version = data.bauteilVersion;

            dbcontext.SaveChanges();



            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateAbteilungDto(AbteilungDto data, int id)
        {




            dbcontext.SaveChanges();

            return true;
        }


        public bool UpdateReparaturDto(ReparaturDto data, int id)
        {
            var item = dbcontext.Reparaturen.FirstOrDefault(x => x.ReparaturID == id);

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateFertigungsDto(FertigungDto data, int id)
        {
            var item = dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == id);


            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateFertigungslinieDto(FertigungslinieDto data, int id)
        {
            var item = dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == id);

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateMaschineDto(MaschineDto data, int id)
        {
            var item = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == id);


            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateUserDto(UserDto data, int id)
        {
            var item = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == id);


            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateWartungDto(WartungDto data, int id)
        {
            var item = dbcontext.Wartungen.FirstOrDefault(x => x.WartungID == id);

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateNachrichtDto(NachrichtDto data, int id)
        {
            throw new NotImplementedException();
        }







        public bool UpdateLoginDto(LoginDto data, int id)
        {
            var item = dbcontext.Logins.FirstOrDefault(x => x.LoginID == id);

            AufgabenGruppe tmp;

            Enum.TryParse(data.userbereich, out tmp);

            dbcontext.Logins.Add(new ProMan_Database.Model.Login()
            {
                Username = data.userKennung,
                Password = data.userpasswort,
                LoginType = tmp,
            });

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateAuditDto(AuditDto data, int id)
        {
            var audit = dbcontext.Audits.FirstOrDefault(x => x.AuditID == id);
            var abteilung = dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == data.abteilung);
            StatusArt tmp1;
            Turnus tmp2;
            Enum.TryParse(data.status, out tmp1);


            Enum.TryParse(data.terminturnus, out tmp2);
            audit.AuditArt = data.auditart;
            audit.Bewertung = data.beurteilung;
            audit.Status = tmp1;
            audit.Turnus = tmp2;
            //audit.Abteilung = abteilung;
            audit.Aufgabe = data.nacharbeiten;
            audit.Beginntermin = data.termin;

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateBauteilVerwendungDto(BauteilVerwendungDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateInstandhaltungsAuftragDto(InstandhaltungsAuftragDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateLagerBestandDto(LagerBestandDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMaschineVerwendungDto(MaschineVerwendungDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduktionsplanDto(ProduktionsplanDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserAnfrageDto(UserAnfrageDto data, int id)
        {
            var useranfrage = dbcontext.Nachrichten.FirstOrDefault(x => x.NachrichtID == id);

            var user = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.userId);
            NachrichtenStatus tmp1;
            Enum.TryParse(data.userAnfrageStatus, out tmp1);

            useranfrage.NachrichtenStatus = tmp1;
            useranfrage.Text = data.userNachricht;
            useranfrage.Betreff = data.userGrund;

            dbcontext.SaveChanges();

            return true;
        }



        #endregion
    }
}
