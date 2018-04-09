﻿using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.AdminPages;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;
using ProMan_Database;
using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseGetSingle : IGetSingleProvider
    {
        ProManContext dbcontext = new ProManContext();

        #region gets

        public AbteilungDto GetAbteilungDto(int id)
        {
            var item = dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == id);

            AbteilungDto abteilung = new AbteilungDto()
            {
                ID = item.AbteilungID,
                Name = item.Bezeichnung,
                WerkName = item.Werk,
                Fertigungen = item.Fertigungen.Select(x => GetFertigungsDto(x.FertigungID)).ToList(),
            };

            return abteilung;
        }

        public FertigungDto GetFertigungsDto(int id)
        {
            var item = dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == id);

            FertigungDto fertigung = new FertigungDto()
            {
                ID = item.FertigungID,
                Name = item.Bezeichnung,
                Fertigungslinien = item.Fertigungslinien.Select(x => new FertigungslinieDto()
                {
                    Arbeitsfolgen = x.Arbeitsfolgen.Select(y => new ArbeitsfolgeDto()
                    {
                        ID = y.ArbeitsfolgeID,
                        ArbeitsfolgeName = y.ArbeitsfolgeName,
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
                ID = item.FertigungslinieID,
                Name = item.Bezeichnung,
                Arbeitsfolgen = item.Arbeitsfolgen.Select(y => new ArbeitsfolgeDto()
                {
                    ID = y.ArbeitsfolgeID,
                    ArbeitsfolgeName = y.ArbeitsfolgeName,
                }).ToList()
            };

            return fertigungslinie;
        }

        public MaschineDto GetMaschineDto(int id)
        {
            var item = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == id);

            MaschineDto maschine = new MaschineDto()
            {
                ID = item.MaschineID,
                Zeichnungsnummer = item.Zeichnungsnummer,
                Inventarnummer = item.Inventarnummer,
                Anschaffungsdatum = item.Anschaffungsdatum,
                Garantie = item.Garantie,
                Standort = item.Standort,
                Hersteller = item.Hersteller,
                Technologie = item.Technologie.ToString(),
                Status = item.Status.ToString(),
                Version = item.Version

            };

            return maschine;
        }

        public ReparaturDto GetReparaturDto(int id)
        {
            var item = dbcontext.Reparaturen.FirstOrDefault(x => x.Maschinen.FirstOrDefault().MaschineID == id);

            ReparaturDto reparatur = new ReparaturDto()
            {
            };
            return reparatur;
        }

        public UserDto GetUserDto(int id)
        {
            var item = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == id);
            UserDto user = new UserDto()
            {
                ID = item.MitarbeiterID,
                Vorname = item.Vorname,
                Active = item.Active,
                Bemerkung = item.Bemerkung,
                eMail = item.eMail,
                Festnetz = item.Festnetz,
                Mobil = item.Mobil,
                Nachname = item.Nachname,
                Namenszusatz = item.Namenszusatz
            };

            return user;
        }

        public WartungDto GetWartungDto(int id)
        {
            var item = dbcontext.Wartungen.FirstOrDefault(x => x.Maschine.MaschineID == id);
            var itemmaschine = dbcontext.Maschinen.FirstOrDefault(x => item.Maschine.MaschineID == x.MaschineID);

            WartungDto wartung = new WartungDto()
            {
                ID = item.WartungID,
                Bereich = item.Bereich,
                Beginntermin = item.Beginntermin,
                Endtermin = item.Endtermin,
                Aufgabe = item.Aufgabe
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
                Gelesen = item.Gelesen,
                SendDate = item.SendDate.Value,
                Text = item.Text,
                Type = item.Type,
                From = new UserDto()
                {
                    Vorname = item.From.Vorname,
                    Nachname = item.From.Nachname,
                    eMail = item.From.eMail
                },
                To = new UserDto()
                {
                    Vorname = item.To.Vorname,
                    Nachname = item.To.Nachname,
                    eMail = item.To.eMail
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
                //AnzeigeName = $"{mitarbeiter.Namenszusatz} {mitarbeiter.Nachname}",
                AnzeigeName = item.Username,
                LoginName = item.Username,
                Password = item.Password,
                LoginType = item.LoginType.ToString()
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
                //AnzeigeName = $"{mitarbeiter.Namenszusatz} {mitarbeiter.Nachname}",
                AnzeigeName = item.Username,
                LoginName = item.Username,
                Password = item.Password,
                LoginType = item.LoginType.ToString()
            };
        }

        #endregion

        #region ViewModels

        public AdminPageUserDto GetAdminPageUserDto()
        {
            var item = new AdminPageUserDto();
            item.User = dbcontext.Mitarbeiter.Select(x => new UserDto()
            {
                Active = x.Active,
                Bemerkung = x.Bemerkung,
                eMail = x.eMail,
                Festnetz = x.Festnetz,
                ID = x.MitarbeiterID,
                Mobil = x.Mobil,
                Nachname = x.Nachname,
                Namenszusatz = x.Namenszusatz,
                Vorname = x.Vorname
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
                ID = x.AbteilungID,
                Fertigungen = x.Fertigungen.Select(y => new FertigungDto()
                {
                    ID = y.FertigungID,
                    Name = y.Bezeichnung,
                    FertigungslinienAnzahl = y.Fertigungslinien.Count,
                }).ToList(),
                WerkName = x.Werk,
                Name = x.Bezeichnung,
            }).ToList();

            return item;
        }

        public AdminPageBauteilDto GetAdminPageBauteilDto()
        {
            var item = new AdminPageBauteilDto();

            item.Bauteile = dbcontext.Bauteile.Select(x => new BauteilDto()
            {
                ID = x.BauteilID,
                Teilart = x.Teilart,
                Version = x.Version,
                Verwendungsort = x.Verwendungsort,
                Abhaengigkeiten = dbcontext.Bauteile.Select(y => new BauteilDto()
                {
                    ID = y.BauteilID,
                    Teilart = y.Teilart,
                    Version = y.Version,
                    Verwendungsort = y.Verwendungsort,
                }).ToList()
            }).ToList();

            return item;
        }

        public AdminPageFertigungDto GetAdminPageFertigungDto()
        {
            var item = new AdminPageFertigungDto();
            item.Fertigungen = dbcontext.Fertigungen.Select(x => new ExtendedAdminFertigungDto()
            {
                ID = x.FertigungID,
                Name = x.Bezeichnung,
                Fertigungslinien = x.Fertigungslinien.Select(y => new FertigungslinieDto()
                {
                    ID = y.FertigungslinieID,
                    FertigungName = y.Bezeichnung,
                    Name = y.Bezeichnung,
                    Arbeitsfolgen = y.Arbeitsfolgen.Select(z => new ArbeitsfolgeDto()
                    {
                        ID = z.ArbeitsfolgeID,
                        //ArbeitsfolgeName = z.ArbeitsfolgeName,
                        //Arbeitsplaene = z.Arbeitsplaene,
                        //Status = z.Status,
                        Maschinen = z.Maschinen.Select(m => new MaschineDto()
                        {
                            ID = m.MaschineID,
                            //Anschaffungsdatum = m.Anschaffungsdatum,
                            //Garantie = m.Garantie,
                            //Hersteller = m.Hersteller,
                            //Standort = m.Standort,
                            //Technologie = m.Technologie.ToString(),
                            //Status = m.Status.ToString(),
                            //Inventarnummer = m.Inventarnummer,
                            //Version = m.Version,
                            //Zeichnungsnummer = m.Zeichnungsnummer
                        }).ToList(),
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
                ID = y.FertigungslinieID,
                FertigungName = y.Bezeichnung,
                Arbeitsfolgen = y.Arbeitsfolgen.Select(z => new ArbeitsfolgeDto()
                {
                    ID = z.ArbeitsfolgeID,
                    ArbeitsfolgeName = z.ArbeitsfolgeName,
                    Arbeitsplaene = z.Arbeitsplaene,
                    Status = z.Status,
                    Maschinen = z.Maschinen.Select(m => new MaschineDto()
                    {
                        ID = m.MaschineID,
                        Anschaffungsdatum = m.Anschaffungsdatum,
                        Garantie = m.Garantie,
                        Hersteller = m.Hersteller,
                        Standort = m.Standort,
                        Technologie = m.Technologie.ToString(),
                        Inventarnummer = m.Inventarnummer,
                        Status = m.Status.ToString(),
                        Version = m.Version,
                        Zeichnungsnummer = m.Zeichnungsnummer
                    }).ToList(),
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
                ID = m.MaschineID,
                Anschaffungsdatum = m.Anschaffungsdatum,
                Garantie = m.Garantie,
                Hersteller = m.Hersteller,
                Standort = m.Standort,
                Technologie = m.Technologie.ToString(),
                Status = m.Status.ToString(),
                Inventarnummer = m.Inventarnummer,
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
                Werk = x.Abteilung.Werk,
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
                Werk = x.Abteilung.Werk,
                AuditsCount = x.Fertigungslinien.Select(s => s.Sonderaufgaben.Select(a => a.Audits)).Count(),
                WartungenCount = x.Fertigungslinien.Select(s => s.Sonderaufgaben.Select(w => w.Wartungen)).Count(),
                ReparaturenCount = x.Fertigungslinien.Select(r => r.Reparaturen).Count(),
                BauteileCount = x.Fertigungslinien.Select(u => u.Lager.Select(b => b.Iststueckzahl)).Count(),
            }).ToList();



            return item;
        }

        #endregion

        #endregion
    }
}