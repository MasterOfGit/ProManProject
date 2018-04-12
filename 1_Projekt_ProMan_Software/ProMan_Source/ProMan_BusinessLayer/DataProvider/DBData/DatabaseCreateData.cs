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


        public bool SetAbteilungDto(AbteilungDto data)
        {
            var werk = dbcontext.Werk.FirstOrDefault(x => x.Name == data.WerkName);
            dbcontext.Abteilungen.Add(new ProMan_Database.Model.Abteilung()
            {
                Bezeichnung = data.abteilungsname,
                Werk = werk,

            });
            dbcontext.SaveChanges();

            return true;
        }

        public bool SetFertigungsDto(FertigungDto data)
        {
            dbcontext.Fertigungen.Add(new ProMan_Database.Model.Fertigung()
            {
                Bezeichnung = data.fertigungsname,
            });

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetFertigungslinieDto(FertigungslinieDto data)
        {
            dbcontext.Fertigungslinien.Add(new ProMan_Database.Model.Fertigungslinie()
            {
                Bezeichnung = data.fertigunglinenname,
            }
            )
            ;

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetMaschineDto(MaschineDto data)
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

            return true;

        }

        public bool SetReparaturDto(ReparaturDto data)
        {
            dbcontext.Reparaturen.Add(new ProMan_Database.Model.Reparatur()
            {
                BeginnTermin = data.Start,
            });

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetUserDto(UserDto data)
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

            return true;
        }

        public bool SetWartungDto(WartungDto data)
        {
            dbcontext.Wartungen.Add(new ProMan_Database.Model.Wartung()
            {
            });

            dbcontext.SaveChanges();

            return true;
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

        public bool SetNachrichtDto(NachrichtDto data)
        {
            var userfrom = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.From.userID);
            var userto = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.To.userID);

            dbcontext.Nachrichten.Add(new ProMan_Database.Model.Nachricht()
            {
                Betreff = data.Betreff,
                Gelesen = false,
                Text = data.Text,
                SendDate = data.SendDate,
                Type = data.Type,
                From = userfrom,
                To = userto,

            });

            dbcontext.SaveChanges();

            return true;
        }

        int ICreateDataProvider.SetFertigungsDto(FertigungDto data)
        {
            throw new NotImplementedException();
        }

        int ICreateDataProvider.SetFertigungslinieDto(FertigungslinieDto data)
        {
            throw new NotImplementedException();
        }

        int ICreateDataProvider.SetMaschineDto(MaschineDto data)
        {
            throw new NotImplementedException();
        }

        int ICreateDataProvider.SetReparaturDto(ReparaturDto data)
        {
            throw new NotImplementedException();
        }

        int ICreateDataProvider.SetUserDto(UserDto data)
        {
            throw new NotImplementedException();
        }

        int ICreateDataProvider.SetWartungDto(WartungDto data)
        {
            throw new NotImplementedException();
        }

        int ICreateDataProvider.SetAbteilungDto(AbteilungDto data)
        {
            throw new NotImplementedException();
        }

        int ICreateDataProvider.SetNachrichtDto(NachrichtDto data)
        {
            throw new NotImplementedException();
        }

        public int SetAuditDto(AuditDto data)
        {
            throw new NotImplementedException();
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

        public int SetUserAnfrageDto(UserAnfrageDto data)
        {
            throw new NotImplementedException();
        }



        #endregion



    }
}
