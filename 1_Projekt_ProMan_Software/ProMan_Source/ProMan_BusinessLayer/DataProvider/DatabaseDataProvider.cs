using ProMan_Database;
using System.Collections.Generic;
using System.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.AdminPages;
using System;

namespace ProMan_BusinessLayer.DataProvider
{
    public class DatabaseDataProvider : IDataProvider
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
                Anschaffungsdatum = item.Anschaffungsdatum.GetValueOrDefault(),
                Garantie = item.Garantie.GetValueOrDefault(),
                Standort = item.Standort,
                Hersteller = item.Hersteller,
                Technologien = item.Technologien.ToList(),
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
                Beginntermin = item.Beginntermin.GetValueOrDefault(),
                Endtermin = item.Endtermin.GetValueOrDefault(),
                Aufgabe = item.Aufgabe
            };
            return wartung;
        }

        #endregion

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
            dbcontext.Maschinen.Add(new ProMan_Database.Model.Maschine()
            {
                Anschaffungsdatum = data.Anschaffungsdatum,
                Garantie = data.Garantie,
                Hersteller = data.Hersteller,
                Technologien = data.Technologien,
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
            dbcontext.Mitarbeiter.Add(new ProMan_Database.Model.Mitarbeiter()
            {
                Vorname = data.Vorname,
                Nachname = data.Nachname,
                eMail = data.eMail,
                Festnetz = data.Festnetz,
                Mobil = data.Mobil,
                Bemerkung = data.Bemerkung,
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

        #endregion

        #region updates

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

        public AdminPageUserDto GetAdminPageUserDto()
        {
            throw new NotImplementedException();
        }

        public AdminPageAbteilungDto GetAdminPageAbteilungDto()
        {
            throw new NotImplementedException();
        }

        public AdminPageBauteilDto GetAdminPageBauteilDto()
        {
            throw new NotImplementedException();
        }

        public AdminPageFertigungDto GetAdminPageFertigungDto()
        {
            throw new NotImplementedException();
        }

        public AdminPageFertigungslinieDto GetAdminPageFertigungslinieDto()
        {
            throw new NotImplementedException();
        }

        public AdminPageMaschineDto GetAdminPageMaschineDto()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}