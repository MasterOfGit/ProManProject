using ProMan_Database;
using System.Collections.Generic;
using System.Linq;
using ProMan_BusinessLayer.Models;

namespace ProMan_BusinessLayer.DataProvider
{
    public class DatabaseDataProvider : IDataProvider
    {
        ProManContext dbcontext = new ProManContext();

        #region gets

        public WerkDto GetWerkDto(int id)
        {
            var item = dbcontext.Werke.FirstOrDefault(x => x.WerkID == id);

            WerkDto werk = new WerkDto()
            {
                ID = item.WerkID,
                Name = item.Name,
                Ort = item.Country,      
                Abteilungen = item.Abteilungen.Select(x => GetAbteilungDto(x.AbteilungID)).ToList()
            };
            return werk;

        }

        public AbteilungDto GetAbteilungDto(int id)
        {
            var item = dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == id);

            AbteilungDto abteilung = new AbteilungDto()
            {
                ID = item.AbteilungID,
                Name = item.Name,
                Fachbereich = item.Fachbereich,
                WerkName = item.Werk.Name,
                Fertigungen = item.Fertigungen.Select(x => GetFertigungsDto(x.FertigungID)).ToList(),
                User = item.Users.Select(x => GetUserDto(x.UserID)).ToList()
            };

            return abteilung;
        }

        public FertigungDto GetFertigungsDto(int id)
        {
            var item = dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == id);

            FertigungDto fertigung = new FertigungDto()
            {
                ID = item.FertigungID,
                Name = item.Name,
                Fertigungslinien = item.Fertigungslinien.Select(x => new FertigungslinieDto()
                {
                    Maschinen = x.Maschinen.Select(y => new MaschineDto()
                    {
                        InventarNummer = y.InventarNummer,
                        Zeichnungsnummer = y.Zeichnungsnummer,
                        MaschinenStatus = y.MaschinenStatus,
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
                Name = item.Name,
                Maschinen = item.Maschinen.Select(x => new MaschineDto()
                {
                    ID = x.MaschineID,
                    InventarNummer = x.InventarNummer,
                    Zeichnungsnummer = x.Zeichnungsnummer,
                    MaschinenStatus = x.MaschinenStatus,
                }).ToList(),
                Werkstuecktraeger = new List<string>()
                {
                    $"Stück_zur_Linie_{id}_1",
                    $"Stück_zur_Linie_{id}_2",
                    $"Stück_zur_Linie_{id}_3"
                }
            };

            return fertigungslinie;
        }

        public MaschineDto GetMaschineDto(int id)
        {
            var item = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == id);
            MaschineDto maschine = new MaschineDto()
            {
                ID = item.MaschineID,
                InventarNummer = item.InventarNummer,
                Zeichnungsnummer = item.Zeichnungsnummer,
                Baujahr = item.Baujahr.GetValueOrDefault(),
                Garantie = item.Garantie.GetValueOrDefault(),
                MaschinenStatus = item.MaschinenStatus,
                Hersteller = item.Hersteller.Name,
                Type = item.Type.Name

            };

            return maschine;
        }

        public ReparaturDto GetReparaturDto(int id)
        {
            var item = dbcontext.Reparaturen.FirstOrDefault(x => x.Maschine.MaschineID == id);

            ReparaturDto reparatur = new ReparaturDto()
            {
                ID = item.ReparaturID,
                InventarNummer = item.Maschine.InventarNummer,
                Zeichnungsnummer = item.Maschine.Zeichnungsnummer,
                Status = item.Status,
                User = new UserDto()
                {
                    Abteilung = item.User.Abteilung.Fachbereich,
                    FirstName = item.User.FirstName,
                    FamilyName = item.User.FamilyName,
                    eMail = item.User.eMail,
                    Phone = item.User.Phone,
                    Mobile = item.User.Mobile,
                    Title = item.User.Title,
                    Werk = item.User.Abteilung.Werk.Name
                },
                Start = item.Start.GetValueOrDefault(),
                Dauer = item.Dauer.GetValueOrDefault(),
            };
            return reparatur;
        }

        public UserDto GetUserDto(int id)
        {
            var item = dbcontext.User.FirstOrDefault(x => x.UserID == id);
            UserDto user = new UserDto()
            {
                ID = item.UserID,
                Abteilung = item.Abteilung.Fachbereich,
                FirstName = item.FirstName,
                FamilyName = item.FamilyName,
                eMail = item.eMail,
                Phone = item.Phone,
                Mobile = item.Mobile,
                Title = item.Title,
                Werk = item.Abteilung.Werk.Name
            };

            return user;
        }

        public WartungDto GetWartungDto(int id)
        {
            var item = dbcontext.Wartungen.FirstOrDefault(x => x.MaschineID == id);
            var itemmaschine = dbcontext.Maschinen.FirstOrDefault(x => item.MaschineID == x.MaschineID);

            WartungDto wartung = new WartungDto()
            {
                ID = item.WartungID,
                InventarNummer = itemmaschine.InventarNummer,
                Zeichnungsnummer = itemmaschine.Zeichnungsnummer,
                Beschreibung = item.Beschreibung,
                Status = item.Status,
                User = new UserDto()
                {
                    ID = item.User.UserID,
                    Abteilung = item.User.Abteilung.Fachbereich,
                    FirstName = item.User.FirstName,
                    FamilyName = item.User.FamilyName,
                    eMail = item.User.eMail,
                    Phone = item.User.Phone,
                    Mobile = item.User.Mobile,
                    Title = item.User.Title,
                    Werk = item.User.Abteilung.Werk.Name
                },
                WartungsInterval = item.WartungsInterval.GetValueOrDefault(),
            };
            return wartung;
        }

        #endregion

        #region set/create

        public bool SetWerkDto(WerkDto data)
        {
            dbcontext.Werke.Add(new ProMan_Database.Model.Werk()
            {
                Name = data.Name,
                Country = data.Ort,
            });

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetAbteilungDto(AbteilungDto data)
        {
            dbcontext.Abteilungen.Add(new ProMan_Database.Model.Abteilung()
            {
                Name = data.Name,
                Fachbereich = data.Fachbereich,
                Werk = dbcontext.Werke.FirstOrDefault(x => x.Name == data.WerkName),

            });
            dbcontext.SaveChanges();

            return true;
        }

        public bool SetFertigungsDto(FertigungDto data)
        {
            dbcontext.Fertigungen.Add(new ProMan_Database.Model.Fertigung()
            {
                Name = data.Name,
                Abteilung = dbcontext.Abteilungen.FirstOrDefault(x => x.Name == data.AbteilungName)
            });

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetFertigungslinieDto(FertigungslinieDto data)
        {
            dbcontext.Fertigungslinien.Add(new ProMan_Database.Model.Fertigungslinie()
            {
                Name = data.Name,
                Fertigung = dbcontext.Fertigungen.FirstOrDefault(x => x.Name == data.FertigungName)
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
                Baujahr = data.Baujahr,
                Garantie = data.Garantie,
                Hersteller = dbcontext.MaschineHersteller.FirstOrDefault(x => x.Name == data.Hersteller),
                MaschinenStatus = data.MaschinenStatus,
                Type = dbcontext.MaschineTypen.FirstOrDefault(x => x.Name == data.Type),
                Zeichnungsnummer = data.Zeichnungsnummer,
                InventarNummer = data.InventarNummer,
            });

            dbcontext.SaveChanges();

            return true;

        }

        public bool SetReparaturDto(ReparaturDto data)
        {
            dbcontext.Reparaturen.Add(new ProMan_Database.Model.Reparatur()
            {
                Dauer = data.Dauer,
                Maschine = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == data.InventarNummer),
                Start = data.Start,
                Status = data.Status,
                User = dbcontext.User.FirstOrDefault(x => x.FirstName == data.User.FirstName && x.FamilyName == data.User.FamilyName)
            });

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetUserDto(UserDto data)
        {
            dbcontext.User.Add(new ProMan_Database.Model.User()
            {
                FamilyName = data.FamilyName,
                FirstName = data.FirstName,
                eMail = data.eMail,
                Phone = data.Phone,
                Title = data.Title,
                Mobile = data.Mobile,
                Country = data.Werk,
                Abteilung = dbcontext.Abteilungen.FirstOrDefault(x => x.Fachbereich == data.Abteilung)
            }
                );

            dbcontext.SaveChanges();

            return true;
        }

        public bool SetWartungDto(WartungDto data)
        {
            dbcontext.Wartungen.Add(new ProMan_Database.Model.Wartung()
            {
                Beschreibung = data.Beschreibung,
                Status = data.Status,
                WartungsInterval = data.WartungsInterval,
            });

            dbcontext.SaveChanges();

            return true;
        }

        #endregion

        #region updates

        public bool UpdateAbteilungDto(AbteilungDto data, int id)
        {
            var item = dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == id);

            item.Name = data.Name;
            item.Werk = dbcontext.Werke.FirstOrDefault(x => x.Name == data.WerkName);


            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateWerkDto(WerkDto data, int id)
        {
            var item = dbcontext.Werke.FirstOrDefault(x => x.WerkID == id);

            item.Name = data.Name;
            item.Country = data.Ort;

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateReparaturDto(ReparaturDto data, int id)
        {
            var item = dbcontext.Reparaturen.FirstOrDefault(x => x.ReparaturID == id);

            item.Status = data.Status;
            item.Dauer = data.Dauer;

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateFertigungsDto(FertigungDto data, int id)
        {
            var item = dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == id);

            item.Name = data.Name;
            item.Abteilung = dbcontext.Abteilungen.FirstOrDefault(x => x.Name == data.AbteilungName);

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateFertigungslinieDto(FertigungslinieDto data, int id)
        {
            var item = dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == id);

            item.Name = data.Name;
            item.Fertigung = dbcontext.Fertigungen.FirstOrDefault(x => x.Name == data.FertigungName);

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateMaschineDto(MaschineDto data, int id)
        {
            var item = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == id);

            item.Garantie = data.Garantie;
            item.MaschinenStatus = data.MaschinenStatus;
            item.Zeichnungsnummer = data.Zeichnungsnummer;

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateUserDto(UserDto data, int id)
        {
            var item = dbcontext.User.FirstOrDefault(x => x.UserID == id);

            item.FirstName = data.FirstName;
            item.FamilyName = data.FamilyName;
            item.eMail = data.eMail;
            item.Mobile = data.Mobile;
            item.Phone = data.Phone;

            item.Abteilung = dbcontext.Abteilungen.FirstOrDefault(x => x.Name == data.AbteilungName && x.Werk.Name == data.WerkName);

            dbcontext.SaveChanges();

            return true;
        }

        public bool UpdateWartungDto(WartungDto data, int id)
        {
            var item = dbcontext.Wartungen.FirstOrDefault(x => x.WartungID == id);

            item.Beschreibung = data.Beschreibung;
            item.WartungsInterval = data.WartungsInterval;
            item.Status = data.Status;

            dbcontext.SaveChanges();

            return true;
        }

        #endregion
    }
}