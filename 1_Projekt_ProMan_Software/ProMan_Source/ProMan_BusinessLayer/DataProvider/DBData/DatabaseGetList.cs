﻿using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;
using ProMan_Database.Model;
using System.Data.Entity;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseGetList : IGetListDataProvider
    {
        private DatabaseGetSingle singleget = new DatabaseGetSingle();
        private ProManContext dbcontext = new ProManContext();

        public List<BauteilDto> GetBauteilDto()
        {
            var items = dbcontext.Bauteile;
            List<BauteilDto> returnlist = new List<BauteilDto>();

            foreach (var item in items)
            {
                returnlist.Add(
                    new BauteilDto()
                    {
                        bauteileID = item.BauteilID,
                        bauteilIDNachfolger = item.NachfolderId,
                        bauteilStatus = item.Status,
                        bauteilIndex = item.Index,
                        bauteilVersion = item.Version,
                        bauteilNummer = item.Nummer,
                        bauteilArt = item.Teilart
                    });
            }
            return returnlist;
        }

        public List<AbteilungDto> GetAbteilungDto()
        {
            var items = dbcontext.Abteilungen.Include(x => x.Fertigungen).Include(x => x.Werk);
            List<AbteilungDto> returnlist = new List<AbteilungDto>();

            foreach (var item in items)
            {

                returnlist.Add(
                    new AbteilungDto()
                    {
                        abteilungsID = item.AbteilungID,
                        abteilungsname = item.Bezeichnung,
                        WerkName = item.Werk?.Name,
                        Fertigungen = item.Fertigungen.Select(x => new FertigungDto()
                        {
                            fertigungsname = x.Bezeichnung,
                            fertigungsID = x.FertigungID,
                        }).ToList()
                    });
            }

            return returnlist;
        }

        public List<FertigungDto> GetFertigungsDto()
        {
            var items = dbcontext.Fertigungen.Include(x => x.Fertigungslinien).Include(x => x.Fertigungslinien.Select(y => y.Arbeitsfolgen));
            List<FertigungDto> returnlist = new List<FertigungDto>();

            foreach (var item in items)
            {
                returnlist.Add(new FertigungDto()
                {
                    fertigungsID = item.FertigungID,
                    fertigungsname = item.Bezeichnung,
                    fertigungslinien = item.Fertigungslinien.Select(x => new FertigungslinieDto()
                    {
                        fertigungslinieID = x.FertigungslinieID,
                        fertigungslinienname = x.Bezeichnung,
                        maschinenanzahl = x.Arbeitsfolgen.Count,
                        arbeitsfolgen = x.Arbeitsfolgen.Select(y => new ArbeitsfolgeDto()
                        {
                            ID = y.ArbeitsfolgeID,
                            ArbeitsfolgeName = y.ArbeitsfolgeName,
                        }).ToList()
                    }).ToList()
                });
            }

            return returnlist;
        }

        public List<FertigungslinieDto> GetFertigungslinieDto()
        {
            var items = dbcontext.Fertigungslinien.Include(x => x.Arbeitsfolgen).Include(x => x.Arbeitsfolgen.Select(y => y.Maschinen)); ;
            List<FertigungslinieDto> returnlist = new List<FertigungslinieDto>();

            foreach (var item in items)
            {
                returnlist.Add(new FertigungslinieDto()
                {
                    fertigungslinieID = item.FertigungslinieID,
                    fertigungslinienname = item.Bezeichnung,
                    maschinenanzahl = item.Arbeitsfolgen.Count,
                    arbeitsfolgen = item.Arbeitsfolgen.Select(y => new ArbeitsfolgeDto()
                    {
                        ID = y.ArbeitsfolgeID,
                        ArbeitsfolgeName = y.ArbeitsfolgeName,
                        Maschinen = new List<MaschineDto>() { new MaschineDto()
                        {
                            maschinenID = y.Maschinen.FirstOrDefault().MaschineID,
                            maschinenInventarNummer = y.Maschinen.FirstOrDefault().Inventarnummer,
                        } }
                    }).ToList()
                });
            }

            return returnlist;
        }

        public List<LoginDto> GetLoginDto()
        {
            var items = dbcontext.Logins;
            List<LoginDto> returnlist = new List<LoginDto>();

            foreach (var item in items)
            {
                returnlist.Add(new LoginDto()
                {
                    //AnzeigeName = $"{mitarbeiter.Namenszusatz} {mitarbeiter.Nachname}",
                    userKennung = item.Username,
                    userpasswort = item.Password,
                    userbereich = item.LoginType.ToString(),
                    userLastLogin = item.LastLogin.Value,
                    userID = item.LoginID,
                    userStatus = item.UserStatus.ToString()              
                });
            }

            return returnlist;
        }

        public List<MaschineDto> GetMaschineDto()
        {
            var items = dbcontext.Maschinen;
            List<MaschineDto> returnlist = new List<MaschineDto>();

            foreach (var item in items)
            {
                returnlist.Add(new MaschineDto()
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
                });
            }

            return returnlist;
        }

        public List<NachrichtDto> GetNarichtenFromUser()
        {
            var items = dbcontext.Nachrichten;
            List<NachrichtDto> returnlist = new List<NachrichtDto>();

            foreach (var item in items)
            {
                returnlist.Add(new NachrichtDto()
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

                });
            }

            return returnlist;
        }

        public List<NachrichtDto> GetNarichtenFromUser(int UserID, DateTime fromDate)
        {
            var items = dbcontext.Nachrichten.Where(x => x.From.MitarbeiterID == UserID);

            List<NachrichtDto> nachrichten = new List<NachrichtDto>();

            foreach (var item in items)
            {
                nachrichten.Add(new NachrichtDto()
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

                });
            }
            return nachrichten;
        }

        public List<ReparaturDto> GetReparaturDto()
        {
            var items = dbcontext.Reparaturen;
            List<ReparaturDto> returnlist = new List<ReparaturDto>();

            foreach (var item in items)
            {
                returnlist.Add(new ReparaturDto()
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
                        userMobilNr  = item.Bearbeiter.FirstOrDefault().Mobil,
                        userNachname = item.Bearbeiter.FirstOrDefault().Nachname,
                        userAnrede = item.Bearbeiter.FirstOrDefault().Namenszusatz
                    },
                    Status = item.Status.ToString(),
                    InventarNummer = item.Maschinen.FirstOrDefault().Inventarnummer,
                    Zeichnungsnummer = item.Maschinen.FirstOrDefault().Zeichnungsnummer,

                });
            }

            return returnlist;
        }

        public List<UserDto> GetUserDto()
        {
            var items = dbcontext.Mitarbeiter;
            List<UserDto> returnlist = new List<UserDto>();

            foreach (var item in items)
            {
                returnlist.Add(new UserDto()
                {
                    userID = item.MitarbeiterID,
                    userVorname = item.Vorname,
                    userActive = item.Active,
                    userBemerkung = item.Bemerkung,
                    userEmail = item.eMail,
                    userFestnetzNr = item.Festnetz,
                    userMobilNr = item.Mobil,
                    userNachname = item.Nachname,
                    userAnrede = item.Namenszusatz
                });
            }

            return returnlist;
        }

        public List<WartungDto> GetWartungDto()
        {
            var items = dbcontext.Wartungen;
            List<WartungDto> returnlist = new List<WartungDto>();

            foreach (var item in items)
            {
                returnlist.Add(new WartungDto()
                {
                    wartungsID = item.WartungID,
                    terminturnus = item.Turnus.ToString(),
                    status = item.Status.ToString(),
                    maschine = item.Maschine?.MaschineID,
                    fertigungslinie = item.Maschine.Arbeitsfolge?.Fertigungslinie?.FertigungslinieID,
                    fertigung = item.Maschine.Arbeitsfolge?.Fertigungslinie?.Fertigung?.FertigungID,
                    abteilung = item.Maschine.Arbeitsfolge?.Fertigungslinie?.Fertigung?.Abteilung?.AbteilungID,
                });
            }

            return returnlist;
        }

        public List<AuditDto> GetAuditDto()
        {
            var items = dbcontext.Audits;
            List<AuditDto> returnlist = new List<AuditDto>();

            foreach (var item in items)
            {
                returnlist.Add(new AuditDto()
                {
                    auditID = item.AuditID,
                    terminturnus = item.Turnus.ToString(),
                    auditart = item.AuditArt,
                    status = item.Status.ToString(),
                    termin = item.Endtermin.Value,
                    beurteilung = item.Bewertung,
                    abteilung = item.Abteilung.AbteilungID,
                    nacharbeiten = item.Aufgabe,
                    
                });
            }

            return returnlist;
        }

        public List<UserAnfrageDto> GetUserAnfrageDto()
        {
            var items = dbcontext.Nachrichten;
            List<UserAnfrageDto> returnlist = new List<UserAnfrageDto>();

            foreach (var item in items)
            {
                returnlist.Add(new UserAnfrageDto()
                {
                    userId = item.From.MitarbeiterID,
                    userAnfrageStatus = item.NachrichtenStatus.ToString(),
                    userGrund = item.Betreff,
                    userNachricht = item.Text

                });
            };

            return returnlist;

        }

        public List<BauteilVerwendungDto> GetBauteilVerwendungDto()
        {
            throw new NotImplementedException();
        }

        public List<InstandhaltungsAuftragDto> GetInstandhaltungsAuftragDto()
        {
            throw new NotImplementedException();
        }

        public List<LagerBestandDto> GetLagerBestandDto()
        {
            throw new NotImplementedException();
        }

        public List<MaschineVerwendungDto> GetMaschineVerwendungDto()
        {
            throw new NotImplementedException();
        }

        public List<ProduktionsplanDto> GetProduktionsplanDto()
        {
            throw new NotImplementedException();
        }

        public List<KeyValueHelper> GetTypeObjects(string type)
        {
            List<KeyValueHelper> values = new List<KeyValueHelper>();
            switch (type)
            {
                //remove Fertigung from Abteilung
                case "Abteilung":
                    {
                        values = dbcontext.Fertigungen.Where(x => x.Abteilung == null).Select(x => new KeyValueHelper() {Key = x.FertigungID.ToString(), Value =x.Bezeichnung}).ToList(); 
                    }
                    break;
                //remove Fertigungslinie from Fertigung
                case "Fertigung":
                    {
                        values = dbcontext.Fertigungslinien.Where(x => x.Fertigung == null).Select(x => new KeyValueHelper() { Key = x.FertigungslinieID.ToString(), Value = x.Bezeichnung}).ToList();
                    }
                    break;
                //remove Arbeitsfolge from Fertigungslinie
                case "Fertigungslinie":
                    { 
                        values = dbcontext.Arbeitsfolgen.Where(x => x.Fertigungslinie == null).Select(x => new KeyValueHelper() { Key = x.ArbeitsfolgeID.ToString(), Value = x.ArbeitsfolgeName }).ToList();
                    }
                    break;
                default:
                    break;
            }
            return values;
        }
    }
}
