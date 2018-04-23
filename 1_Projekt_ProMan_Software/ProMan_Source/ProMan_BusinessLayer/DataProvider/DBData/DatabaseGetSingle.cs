///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.AdminPages;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;
using ProMan_Database;
using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseGetSingle : IGetSingleProvider
    {
        ProManContext dbcontext = new ProManContext();

        #region gets



        public BauteilDto GetBauteilDto(int id)
        {
            var item = dbcontext.Bauteile.FirstOrDefault(x => x.BauteilID == id);

            return new BauteilDto()
            {
                bauteileID = item.BauteilID,
                bauteilIDNachfolger = item.NachfolderId,
                bauteilStatus = item.Status,
                bauteilIndex = item.Index,
                bauteilVersion = item.Version,
                bauteilNummer = item.Nummer,
                bauteilArt = item.Teilart
            };

        }

        public AbteilungDto GetAbteilungDto(int id)
        {
            var item = dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == id);

            AbteilungDto abteilung = new AbteilungDto()
            {
                abteilungsID = item.AbteilungID,
                abteilungsname = item.Bezeichnung,
                WerkName = item.Werk.Name,
                Fertigungen = item.Fertigungen.Select(x => GetFertigungsDto(x.FertigungID)).ToList(),
            };

            return abteilung;
        }

        public FertigungDto GetFertigungsDto(int id)
        {
            var item = dbcontext.Fertigungen.Include("Fertigungslinien").FirstOrDefault(x => x.FertigungID == id);
            
            FertigungDto fertigung = new FertigungDto()
            {
                fertigungsID = item.FertigungID,
                fertigungsname = item.Bezeichnung,
                fertigungslinien = item.Fertigungslinien?.Select(x => new FertigungslinieDto()
                {
                    fertigungslinieID = x.FertigungslinieID,
                    fertigungslinienname = x.Bezeichnung,
                    fertigungstyp = x.Fertigungstype.ToString(),
                    maschinenanzahl = x.Arbeitsfolgen.Count,
                    arbeitsfolgen = x.Arbeitsfolgen.Select(y => new ArbeitsfolgeDto()
                    {
                        arbeitsfolgeID = y.ArbeitsfolgeID,
                        arbeitplan = y.ArbeitsfolgeName,
                    }).ToList()
                }).ToList()
            };
            return fertigung;
        }

        public FertigungslinieDto GetFertigungslinieDto(int id)
        {
            var item = dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == id);

            FertigungslinieDto fertigungslinie = new FertigungslinieDto()
            {
                fertigungslinieID = item.FertigungslinieID,
                fertigungslinienname = item.Bezeichnung,
                fertigungstyp = item.Fertigungstype.ToString(),
                maschinenanzahl = item.Arbeitsfolgen.Count,
                arbeitsfolgen = item.Arbeitsfolgen.Select(y => new ArbeitsfolgeDto()
                {
                    arbeitsfolgeID = y.ArbeitsfolgeID,
                    arbeitplan = y.ArbeitsfolgeName,
                }).ToList()
            };

            return fertigungslinie;
        }

        public MaschineDto GetMaschineDto(int id)
        {
            var item = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == id);

            MaschineDto maschine = new MaschineDto()
            {
                maschinenID = item.MaschineID,
                Zeichnungsnummer = item.Zeichnungsnummer,
                maschinenInventarNummer = item.Inventarnummer,
                Anschaffungsdatum = item.Anschaffungsdatum,
                Garantie = item.Garantie,
                standort = item.Standort,
                hersteller = item.Hersteller,
                technologie = item.Technologie.ToString(),
                status = item.Status.ToString(),
                Version = item.Version

            };

            return maschine;
        }

        public ReparaturDto GetReparaturDto(int id)
        {
            var item = dbcontext.Reparaturen.FirstOrDefault(x => x.Maschinen.FirstOrDefault().MaschineID == id);

            ReparaturDto reparatur = new ReparaturDto()
            {
                ID = item.ReparaturID,
                Start = item.BeginnTermin.Value,
                User = new UserDto()
                {
                    userID = item.Bearbeiter.FirstOrDefault().MitarbeiterID,
                    userVorname = item.Bearbeiter.FirstOrDefault().Vorname,
                    userActive = item.Bearbeiter.FirstOrDefault().Active,
                    userBemerkung = item.Bearbeiter.FirstOrDefault().Bemerkung,
                    userEmail = item.Bearbeiter.FirstOrDefault().eMail,
                    userFestnetzNr = item.Bearbeiter.FirstOrDefault().Festnetz,
                    userMobilNr = item.Bearbeiter.FirstOrDefault().Mobil,
                    userNachname = item.Bearbeiter.FirstOrDefault().Nachname,
                    userAnrede = item.Bearbeiter.FirstOrDefault().Namenszusatz.ToString()
                },
                Status = item.Status.ToString(),
                InventarNummer = item.Maschinen.FirstOrDefault().Inventarnummer,
                Zeichnungsnummer = item.Maschinen.FirstOrDefault().Zeichnungsnummer,
            };
                

            return reparatur;
        }

        public UserDto GetUserDto(int id)
        {
            var item = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == id);
            UserDto user = new UserDto()
            {
                userID = item.MitarbeiterID,
                userVorname = item.Vorname,
                userActive = item.Active,
                userBemerkung = item.Bemerkung,
                userEmail = item.eMail,
                userFestnetzNr = item.Festnetz,
                userMobilNr = item.Mobil,
                userNachname = item.Nachname,
                userAnrede = item.Namenszusatz.ToString()
            };

            return user;
        }

        public WartungDto GetWartungDto(int id)
        {
            var item = dbcontext.Wartungen.FirstOrDefault(x => x.Maschine.MaschineID == id);
            var itemmaschine = dbcontext.Maschinen.FirstOrDefault(x => item.Maschine.MaschineID == x.MaschineID);

            WartungDto wartung = new WartungDto()
            {
                wartungsID = item.WartungID,
                terminturnus = item.Turnus.ToString(),
                status = item.Status.ToString(),
                maschine = item.Maschine.MaschineID,
                fertigungslinie = item.Maschine.Arbeitsfolge.Fertigungslinie.FertigungslinieID,
                fertigung = item.Maschine.Arbeitsfolge.Fertigungslinie.Fertigung.FertigungID,
                abteilung = item.Maschine.Arbeitsfolge.Fertigungslinie.Fertigung.Abteilung.AbteilungID,
            };
            return wartung;
        }

        public NachrichtDto GetNachrichtDto(int id)
        {
            var item = dbcontext.Nachrichten.FirstOrDefault(x => x.NachrichtID == id);

            NachrichtDto nachricht = new NachrichtDto()
            {
                ID = item.NachrichtID,
                Betreff = item.Betreff,
                NachrichtenStatus = item.NachrichtenStatus.ToString(),
                SendDate = item.SendDate.Value,
                Text = item.Text,
                Type = item.Type,
                From = new UserDto()
                {
                    userVorname = item.From.Vorname,
                    userNachname = item.From.Nachname,
                    userEmail = item.From.eMail
                },
                To = new UserDto()
                {
                    userVorname = item.To.Vorname,
                    userNachname = item.To.Nachname,
                    userEmail = item.To.eMail
                },

            };

            return nachricht;

        }

        public LoginDto GetLoginDto(int id)
        {
            var item = dbcontext.Logins.FirstOrDefault(x => x.LoginID == id);

            var mitarbeiter = dbcontext.Mitarbeiter.FirstOrDefault(x => x.Login.LoginID == id);

            return new LoginDto()
            {
                userKennung = item.Username,
                //userpasswort = item.Password,
                userbereich = item.LoginType.ToString(),
                userID = item.LoginID,
                userLastLogin = item.LastLogin.Value,
                userStatus = item.UserStatus.ToString()
            };
        }

        public LoginDto GetLoginDto(string username, string password)
        {
            var item = dbcontext.Logins.FirstOrDefault(x => x.Username == username && x.Password == password);
            var mitarbeiter = dbcontext.Mitarbeiter.FirstOrDefault(x => x.Login.LoginID == item.LoginID);
            item.LastLogin = DateTime.Now;

            dbcontext.SaveChanges();

            return new LoginDto()
            {
                userKennung = item.Username,
                userpasswort = item.Password,
                userbereich = item.LoginType.ToString(),
                userID = item.LoginID,
                userLastLogin = item.LastLogin.Value,
                userStatus = item.UserStatus.ToString()
            };
        }

        public bool ExecuteLoginDto(string username, string password)
        {
            var item = dbcontext.Logins.FirstOrDefault(x => x.Username == username && x.Password == password);

            return item != null ? true : false;

        }

        #endregion

        #region ViewModels

        public AdminPageUserDto GetAdminPageUserDto()
        {
            var item = new AdminPageUserDto();
            item.User = dbcontext.Mitarbeiter.Select(x => new UserDto()
            {
                userActive = x.Active,
                userBemerkung = x.Bemerkung,
                userEmail = x.eMail,
                userFestnetzNr = x.Festnetz,
                userID = x.MitarbeiterID,
                userMobilNr = x.Mobil,
                userNachname = x.Nachname,
                userAnrede = x.Namenszusatz.ToString(),
                userVorname = x.Vorname,
                
            }).ToList();

            return item;
        }

        /// <summary>
        /// Returns the admin page data for Abteilung
        /// </summary>
        /// <returns></returns>
        public AdminPageAbteilungDto GetAdminPageAbteilungDto()
        {
            var item = new AdminPageAbteilungDto();

            item.Abteilungen = dbcontext.Abteilungen.Select(x => new ExtendedAdminAbteilungenDto()
            {
                abteilungsID = x.AbteilungID,
                Fertigungen = x.Fertigungen.Select(y => new FertigungDto()
                { 
                    fertigungsID = y.FertigungID,
                    fertigungsname = y.Bezeichnung,
                    FertigungslinienAnzahl = y.Fertigungslinien.Count,
                }).ToList(),
                WerkName = x.Werk.Name,
            }).ToList();

            return item;
        }

        public AdminPageBauteilDto GetAdminPageBauteilDto()
        {
            var item = new AdminPageBauteilDto();

            item.Bauteile = dbcontext.Bauteile.Select(x => new BauteilDto()
            {
                bauteileID = x.BauteilID,
                bauteilArt = x.Teilart,
                bauteilVersion = x.Version,
                bauteilIDNachfolger = x.NachfolderId,
                bauteilIndex = x.Index,
                bauteilNummer = x.Nummer,
                bauteilStatus = x.Status,
            }).ToList();

            return item;
        }

        public AdminPageFertigungDto GetAdminPageFertigungDto()
        {
            var item = new AdminPageFertigungDto();
            item.Fertigungen = dbcontext.Fertigungen.Select(x => new ExtendedAdminFertigungDto()
            {
                fertigungsID = x.FertigungID,
                fertigungsname = x.Bezeichnung,
                fertigungslinien = x.Fertigungslinien.Select(y => new FertigungslinieDto()
                {
                    fertigungslinieID = y.FertigungslinieID,
                    fertigungslinienname = y.Bezeichnung,
                    fertigungstyp = y.Fertigungstype.ToString(),
                    arbeitsfolgen = y.Arbeitsfolgen.Select(z => new ArbeitsfolgeDto()
                    {
                        arbeitsfolgeID = z.ArbeitsfolgeID,
                        //ArbeitsfolgeName = z.ArbeitsfolgeName,
                        //Arbeitsplaene = z.Arbeitsplaene,
                        //Status = z.Status,
                        maschineID = z.Maschinen.FirstOrDefault().MaschineID,
                    }).ToList()
                }).ToList()
            }).ToList();



            return item;
        }

        public AdminPageFertigungslinieDto GetAdminPageFertigungslinieDto()
        {
            var item = new AdminPageFertigungslinieDto();

            item.Fertigungslinien = dbcontext.Fertigungslinien.Select(y => new FertigungslinieDto()
            {
                fertigungslinieID = y.FertigungslinieID,
                fertigungslinienname = y.Bezeichnung,
                fertigungstyp = y.Fertigungstype.ToString(),
                arbeitsfolgen = y.Arbeitsfolgen.Select(z => new ArbeitsfolgeDto()
                {
                    arbeitsfolgeID = z.ArbeitsfolgeID,
                    arbeitplan = z.ArbeitsfolgeName,
                    Arbeitsplaene = z.Arbeitsplaene,
                    Status = z.Status,
                    maschineID = z.Maschinen.FirstOrDefault().MaschineID,
                }).ToList()
            }).ToList();

            return item;
        }

        /// <summary>
        /// Gets the complete Data for the maschine admin page
        /// </summary>
        /// <returns></returns>
        public AdminPageMaschineDto GetAdminPageMaschineDto()
        {
            var item = new AdminPageMaschineDto();
            item.Maschinen = dbcontext.Maschinen.Select(m => new MaschineDto()
            {
                maschinenID = m.MaschineID,
                Anschaffungsdatum = m.Anschaffungsdatum,
                Garantie = m.Garantie,
                hersteller = m.Hersteller,
                standort = m.Standort,
                technologie = m.Technologie.ToString(),
                status = m.Status.ToString(),
                maschinenInventarNummer = m.Inventarnummer,
                Version = m.Version,
                Zeichnungsnummer = m.Zeichnungsnummer,
                AbteilungsName = m.Arbeitsfolge.Fertigungslinie.Fertigung.Abteilung.Bezeichnung,
                Arbeitsfolge = m.Arbeitsfolge.ArbeitsfolgeID.ToString(),
                FertigungslinienName = m.Arbeitsfolge.Fertigungslinie.Bezeichnung,
                FertigungsName = m.Arbeitsfolge.Fertigungslinie.Fertigung.Bezeichnung

            }).ToList();
            return item;
        }


        #region MF

        public MFAbteilungOverviewDto GetMFAbteilungOverviewDto(int id)
        {
            var item = new MFAbteilungOverviewDto();
            item.Abteilungsname = dbcontext.Abteilungen.First(x => x.AbteilungID == id).Bezeichnung;
            item.Fertigungen = dbcontext.Fertigungen.Select(x => new MFFertigungDto()
            {
                Abteilung = x.Abteilung.Bezeichnung,
                Name = x.Bezeichnung,
                Ort = x.Ort,
                Werk = x.Abteilung.Werk.Name,
                Bereich = "no database",
                AuditsCount = x.Fertigungslinien.Select(s => s.Sonderaufgaben.Select(a => a.Audits)).Count(),
                WartungenCount = x.Fertigungslinien.Select(s => s.Sonderaufgaben.Select(w => w.Wartungen)).Count(),
                ReparaturenCount = x.Fertigungslinien.Select(r => r.Reparaturen).Count(),
                BauteileCount = x.Fertigungslinien.Select(u => u.Lager.Select(b => b.Iststueckzahl)).Count(),
                Type = Fertigungstype.Gruenfertigung
            }
            ).ToList();

            return item;
        }

        public MFInstandhaltung GetMFInstandhaltung()
        {
            var item = new MFInstandhaltung();

            return item;
        }

        public MFLinieDto GetMFLinieDto(int id)
        {
            var item = new MFLinieDto();

            return item;
        }

        public List<MFFertigungDto> GetMFFertigungDto()
        {
            var item = dbcontext.Fertigungen.Select(x => new MFFertigungDto()
            {
                Abteilung = x.Abteilung.Bezeichnung,
                Name = x.Bezeichnung,
                Ort = x.Ort,
                Werk = x.Abteilung.Werk.Name,
                AuditsCount = x.Fertigungslinien.Select(s => s.Sonderaufgaben.Select(a => a.Audits)).Count(),
                WartungenCount = x.Fertigungslinien.Select(s => s.Sonderaufgaben.Select(w => w.Wartungen)).Count(),
                ReparaturenCount = x.Fertigungslinien.Select(r => r.Reparaturen).Count(),
                BauteileCount = x.Fertigungslinien.Select(u => u.Lager.Select(b => b.Iststueckzahl)).Count(),
            }).ToList();



            return item;
        }



        #endregion

        #endregion

        public AuditDto GetAuditDto(int id)
        {
            var item = dbcontext.Audits.FirstOrDefault(x => x.AuditID == id);

            return new AuditDto()
            {
                auditID = item.AuditID,
                terminturnus = item.Turnus.ToString(),
                auditart = item.AuditArt,
                status = item.Status.ToString(),
                termin = item.Endtermin.Value,
                beurteilung = item.Bewertung,
                abteilung = item.Abteilung.AbteilungID,
                nacharbeiten = item.Aufgabe,
            };
        }

        public BauteilVerwendungDto GetBauteilVerwendungDto(int id)
        {
            throw new NotImplementedException();
        }

        public InstandhaltungsAuftragDto GetInstandhaltungsAuftragDto(int id)
        {
            throw new NotImplementedException();
        }

        public LagerBestandDto GetLagerBestandDto(int id)
        {
            throw new NotImplementedException();
        }

        public MaschineVerwendungDto GetMaschineVerwendungDto(int id)
        {
            throw new NotImplementedException();
        }

        public ProduktionsplanDto GetProduktionsplanDto(int id)
        {
            throw new NotImplementedException();
        }

        public UserAnfrageDto GetUserAnfrageDto(int id)
        {
            var item = dbcontext.Nachrichten.FirstOrDefault(x => x.NachrichtID == id);

            return new UserAnfrageDto()
            {
                userId = item.From.MitarbeiterID,
                userAnfrageStatus = item.NachrichtenStatus.ToString(),
                userGrund = item.Betreff,
                userNachricht = item.Text
            };
        }

        public ArbeitsfolgeDto GetArbeitsfolgeDto(int id)
        {
            var item = dbcontext.Arbeitsfolgen.Include(x => x.Bauteile).Include(x => x.Maschinen).Include(x => x.Fertigungslinie).FirstOrDefault(x => x.ArbeitsfolgeID == id);

            return new ArbeitsfolgeDto()
            {
                arbeitplan = item.ArbeitsfolgeName,
                arbeitsfolgeID = item.ArbeitsfolgeID,
                Status = item.Status,
                Order = item.Order,
                bauteilID = item.Bauteile.FirstOrDefault().BauteilID,
                maschineID = item.Maschinen.FirstOrDefault().MaschineID,
                technologie = item.Maschinen.FirstOrDefault().Technologie.ToString(),
                fertigungslinieID = item.Fertigungslinie.FertigungslinieID,
                fertigunglinenname = item.Fertigungslinie.Bezeichnung,
                fertigungstyp = item.Fertigungslinie.Fertigungstype.ToString()
                
            };
        }
    }
}
