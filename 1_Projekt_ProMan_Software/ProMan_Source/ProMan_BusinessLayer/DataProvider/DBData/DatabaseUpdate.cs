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
            var item = dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == id);

            item.Bezeichnung = data.abteilungsname;
            item.Werk = dbcontext.Werk.FirstOrDefault(x => x.Name == data.WerkName);

            dbcontext.SaveChanges();

            return true;
        }


        public bool UpdateReparaturDto(ReparaturDto data, int id)
        {
            ReparaturStatus tmp1;
            Enum.TryParse(data.Status, out tmp1);
            var item = dbcontext.Reparaturen.FirstOrDefault(x => x.ReparaturID == id);

            item.Auftragstext = data.Dauer.ToString();
            item.Status = tmp1;
            

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateFertigungsDto(FertigungDto data, int id)
        {
            var item = dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == id);

            item.Bezeichnung = data.fertigungsname;
            item.Abteilung = dbcontext.Abteilungen.FirstOrDefault(x => x.Bezeichnung == data.abteilungName);


            //TODO Fertigungslinien hinzufügen

            //item.Fertigungslinien = dbcontext.Fertigungslinien.Where(


            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateFertigungslinieDto(FertigungslinieDto data, int id)
        {
            Fertigungstype tmpFertigungstype;
            Enum.TryParse(data.fertigungstyp, out tmpFertigungstype);

            var item = dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == id);

            item.Bezeichnung = data.fertigungslinienname;
            item.Fertigungstype = tmpFertigungstype;

            //TODO arbeitsfolgen

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateMaschineDto(MaschineDto data, int id)
        {
            MaschinenStatus tmp1;
            Technologie tmp2;
            Enum.TryParse(data.status, out tmp1);
            Enum.TryParse(data.technologie, out tmp2);

            var item = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == id);

            item.Hersteller = data.hersteller;
            item.Inventarnummer = data.maschinenInventarNummer;
            item.Standort = data.standort;
            item.Status = tmp1;
            item.Technologie = tmp2;


            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateUserDto(UserDto data, int id)
        {
            var item = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == id);

            item.Vorname = data.userVorname;
            item.Nachname = data.userNachname;
            item.eMail = data.userEmail;
            item.Festnetz = data.userFestnetzNr;
            item.Mobil = data.userMobilNr;
            item.Bemerkung = data.userBemerkung;
            item.Active = data.userActive;
            item.Namenszusatz = data.userAnrede;

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateWartungDto(WartungDto data, int id)
        {
            StatusArt tmp1;
            Turnus tmp2;
            Enum.TryParse(data.status, out tmp1);
            Enum.TryParse(data.terminturnus, out tmp2);

            var item = dbcontext.Wartungen.FirstOrDefault(x => x.WartungID == id);
            item.Status = tmp1;
            item.Maschine = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == data.maschine);
            item.Turnus = tmp2;

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateNachrichtDto(NachrichtDto data, int id)
        {

            var userfrom = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.From.userID);
            var userto = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.To.userID);
            NachrichtenStatus tmp;

            Enum.TryParse(data.NachrichtenStatus, out tmp);

            var item = dbcontext.Nachrichten.FirstOrDefault(x => x.NachrichtID == id);

            item.Betreff = data.Betreff;
            item.NachrichtenStatus = tmp;
            item.Text = data.Text;
            item.SendDate = data.SendDate;
            item.Type = data.Type;
            item.From = userfrom;
            item.To = userto;

            dbcontext.SaveChanges();

            return true;
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

        public void MoveObject(string type, int oldparent, int newparent, int id)
        {
            switch (type)
            {
                //remove Fertigung from Abteilung
                case "Abteilung":
                    {
                        var fertigung = dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == id);
                        dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == oldparent).Fertigungen.Remove(fertigung);
                        dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == newparent).Fertigungen.Add(fertigung);
                        dbcontext.SaveChanges();
                    }
                    break;
                //remove Fertigungslinie from Fertigung
                case "Fertigung":
                    {
                        var Fertigungslinien = dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == id);
                        dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == oldparent).Fertigungslinien.Remove(Fertigungslinien);
                        dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == newparent).Fertigungslinien.Add(Fertigungslinien);
                        dbcontext.SaveChanges();
                    }
                    break;
                //remove Arbeitsfolge from Fertigungslinie
                case "Fertigungslinie":
                    {
                        var Arbeitsfolgen = dbcontext.Arbeitsfolgen.FirstOrDefault(x => x.ArbeitsfolgeID == id);
                        dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == oldparent).Arbeitsfolgen.Remove(Arbeitsfolgen);
                        dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == newparent).Arbeitsfolgen.Add(Arbeitsfolgen);
                        dbcontext.SaveChanges();
                    }
                    break;
                default:
                    break;
            }
        }



        #endregion
    }
}
