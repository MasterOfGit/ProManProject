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
            dbcontext.Abteilungen.Add(new ProMan_Database.Model.Abteilung()
            {
                Bezeichnung = data.Name,
                Werk = data.WerkName,

            });
            dbcontext.SaveChanges();

            return true;
        }

        public bool SetFertigungsDto(FertigungDto data)
        {
            dbcontext.Fertigungen.Add(new ProMan_Database.Model.Fertigung()
            {
                Bezeichnung = data.Name,
            });

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetFertigungslinieDto(FertigungslinieDto data)
        {
            dbcontext.Fertigungslinien.Add(new ProMan_Database.Model.Fertigungslinie()
            {
                Bezeichnung = data.Name,
            }
            )
            ;

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetMaschineDto(MaschineDto data)
        {
            MaschinenStatus tmpMaschinenStatus;
            Enum.TryParse(data.Status, out tmpMaschinenStatus);

            Technologie tmpTechnologie;
            Enum.TryParse(data.Technologie, out tmpTechnologie);

            dbcontext.Maschinen.Add(new ProMan_Database.Model.Maschine()
            {
                Anschaffungsdatum = data.Anschaffungsdatum,
                Garantie = data.Garantie,
                Hersteller = data.Hersteller,
                Technologie = tmpTechnologie,
                Status = tmpMaschinenStatus,
                Inventarnummer = data.Inventarnummer,
                Standort = data.Standort,
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
                Vorname = data.Vorname,
                Nachname = data.Nachname,
                eMail = data.eMail,
                Festnetz = data.Festnetz,
                Mobil = data.Mobil,
                Bemerkung = data.Bemerkung,
                Active = data.Active,
                Namenszusatz = data.Namenszusatz,
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

            Enum.TryParse(data.LoginType, out tmp);

            dbcontext.Logins.Add(new ProMan_Database.Model.Login()
            {
                Username = data.LoginName,
                Password = data.Password,
                LoginType = tmp,
            });

            dbcontext.SaveChanges();


            return dbcontext.Logins.FirstOrDefault(x => x.Username == data.LoginName && x.LoginType == tmp).LoginID;

        }

        public bool SetNachrichtDto(NachrichtDto data)
        {
            var userfrom = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.From.ID);
            var userto = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == data.To.ID);

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



        #endregion



    }
}
