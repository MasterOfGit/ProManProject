using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_Database;
using ProMan_Database.Enums;
using System;
using System.Linq;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseCreateData : ICreateDataProvider
    {
        ProManContext dbcontext = new ProManContext();

        #region set/create


        public int SetAbteilungDto(AbteilungDto data)
        {
            var werk = dbcontext.Werk.FirstOrDefault(x => x.Name == data.WerkName);
            dbcontext.Abteilungen.Add(new ProMan_Database.Model.Abteilung()
            {
                Bezeichnung = data.abteilungsname,
                Werk = werk,

            });
            dbcontext.SaveChanges();

            return 1;
        }

        public int SetFertigungsDto(FertigungDto data)
        {
            dbcontext.Fertigungen.Add(new ProMan_Database.Model.Fertigung()
            {
                Bezeichnung = data.fertigungsname,
            });

            dbcontext.SaveChanges();

            return 1;
        }

        public int SetFertigungslinieDto(FertigungslinieDto data)
        {
            dbcontext.Fertigungslinien.Add(new ProMan_Database.Model.Fertigungslinie()
            {
                Bezeichnung = data.fertigunglinenname,
            }
            )
            ;

            dbcontext.SaveChanges();

            return 1;
        }

        public int SetMaschineDto(MaschineDto data)
        {
            MaschinenStatus tmpMaschinenStatus;
            Enum.TryParse(data.status, out tmpMaschinenStatus);

            Technologie tmpTechnologie;
            Enum.TryParse(data.technologie, out tmpTechnologie);

            dbcontext.Maschinen.Add(new ProMan_Database.Model.Maschine()
            {
                Anschaffungsdatum = data.Anschaffungsdatum,
                Garantie = data.Garantie,
                Hersteller = data.hersteller,
                Technologie = tmpTechnologie,
                Status = tmpMaschinenStatus,
                Inventarnummer = data.maschinenInventarNummer,
                Standort = data.standort,
                Version = data.Version,
                Zeichnungsnummer = data.Zeichnungsnummer,
            });

            dbcontext.SaveChanges();

            return 1;

        }

        public int SetReparaturDto(ReparaturDto data)
        {
            dbcontext.Reparaturen.Add(new ProMan_Database.Model.Reparatur()
            {
                BeginnTermin = data.Start,
            });

            dbcontext.SaveChanges();

            return 1;
        }

        public int SetUserDto(UserDto data)
        {
            var userlogin = dbcontext.Logins.FirstOrDefault(x => x.LoginID == data.LoginId);

            dbcontext.Mitarbeiter.Add(new ProMan_Database.Model.Mitarbeiter()
            {
                Vorname = data.userVorname,
                Nachname = data.userNachname,
                eMail = data.userEmail,
                Festnetz = data.userFestnetzNr,
                Mobil = data.userMobilNr,
                Bemerkung = data.userBemerkung,
                Active = data.userActive,
                Namenszusatz = data.userAnrede,
                Login = userlogin,
            }
                );

            dbcontext.SaveChanges();

            return 1;
        }

        public int SetWartungDto(WartungDto data)
        {
            dbcontext.Wartungen.Add(new ProMan_Database.Model.Wartung()
            {
            });

            dbcontext.SaveChanges();

            return 1;
        }

        public int SetLoginDto(LoginDto data)
        {
            AufgabenGruppe tmp;
            UserStatus tmp2;
            Enum.TryParse(data.userbereich, out tmp);
            Enum.TryParse(data.userStatus, out tmp2);

            dbcontext.Logins.Add(new ProMan_Database.Model.Login()
            {
                Username = data.userKennung,
                Password = data.userpasswort,
                LoginType = tmp,
                LastLogin = DateTime.Now,
                UserStatus = tmp2,
                
            });

            dbcontext.SaveChanges();


            return dbcontext.Logins.FirstOrDefault(x => x.Username == data.userKennung && x.LoginType == tmp).LoginID;

        }

        public int SetNachrichtDto(NachrichtDto data)
        {
            var userfrom = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.From.userID);
            var userto = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.To.userID);
            NachrichtenStatus tmp;

            Enum.TryParse(data.NachrichtenStatus, out tmp);

            dbcontext.Nachrichten.Add(new ProMan_Database.Model.Nachricht()
            {
                Betreff = data.Betreff,
                NachrichtenStatus = tmp,
                Text = data.Text,
                SendDate = data.SendDate,
                Type = data.Type,
                From = userfrom,
                To = userto,

            });

            dbcontext.SaveChanges();

            return 1;
        }
        

        public int SetAuditDto(AuditDto data)
        {
            var abteilung = dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == data.abteilung);
            StatusArt tmp1;
            Turnus tmp2;
            Enum.TryParse(data.status, out tmp1);
            

            Enum.TryParse(data.terminturnus, out tmp2);
            dbcontext.Audits.Add(new ProMan_Database.Model.Audit()
            {
                AuditArt = data.auditart,
                Bewertung = data.beurteilung,
                Status = tmp1,
                Turnus = tmp2,
                Abteilung = abteilung,
                Aufgabe = data.nacharbeiten,
                Beginntermin = data.termin
            });
            dbcontext.SaveChanges();

            return 1;
            
        }



        public int SetUserAnfrageDto(UserAnfrageDto data)
        {
            var user = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.userId);
            NachrichtenStatus tmp1;
            Enum.TryParse(data.userAnfrageStatus, out tmp1);

            dbcontext.Nachrichten.Add(new ProMan_Database.Model.Nachricht()
            {
                NachrichtenStatus = tmp1,
                From = user,
                Text = data.userNachricht,
                Betreff = data.userGrund
            });
            dbcontext.SaveChanges();

            return 1;
        }

        public int SetBauteilDto(BauteilDto data)
        {
            dbcontext.Bauteile.Add(new ProMan_Database.Model.Bauteil()
            {
                NachfolderId = data.bauteilIDNachfolger,
                Index = data.bauteilIndex,
                Nummer = data.bauteilNummer,
                Status = data.bauteilStatus,
                Version = data.bauteilVersion,
            });
            dbcontext.SaveChanges();

            return 1;
        }


        public int SetBauteilVerwendungDto(BauteilVerwendungDto data)
        {
            throw new NotImplementedException();
        }

        public int SetInstandhaltungsAuftragDto(InstandhaltungsAuftragDto data)
        {
            throw new NotImplementedException();
        }

        public int SetLagerBestandDto(LagerBestandDto data)
        {
            throw new NotImplementedException();
        }

        public int SetMaschineVerwendungDto(MaschineVerwendungDto data)
        {
            throw new NotImplementedException();
        }

        public int SetProduktionsplanDto(ProduktionsplanDto data)
        {
            throw new NotImplementedException();
        }

        #endregion



    }
}
