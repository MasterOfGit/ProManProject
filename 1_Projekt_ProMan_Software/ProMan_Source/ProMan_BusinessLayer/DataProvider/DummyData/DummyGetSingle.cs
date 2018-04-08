using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.AdminPages;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;
using ProMan_Database.Enums;
using System;
using System.Collections.Generic;

namespace ProMan_BusinessLayer.DataProvider.DummyData
{
    public class DummyGetSingle : IGetSingleProvider
    {

        #region single objects

        public AbteilungDto GetAbteilungDto(int id)
        {
            List<FertigungDto> ferttmp = new List<FertigungDto>();
            List<UserDto> usertmp = new List<UserDto>();

            for (int i = 1; i < id + 1; i++)
            {
                ferttmp.Add(GetFertigungsDto(i));
                usertmp.Add(GenerateUser(i));
            }

            AbteilungDto item = new AbteilungDto()
            {
                ID = id,
                Name = $"Abteilung{id}",
                Fachbereich = $"Fachbereich{id}",
                WerkName = $"Werk{id}",
                Fertigungen = ferttmp,
                User = usertmp,
            };

            return item;
        }


        public FertigungDto GetFertigungsDto(int id)
        {
            List<FertigungslinieDto> tmp = new List<FertigungslinieDto>();
            for (int i = 0; i < id; i++)
            {
                tmp.Add(GetFertigungslinieDto(i));
            }

            FertigungDto item = new FertigungDto()
            {
                ID = id,
                Name = $"Fertigung{id}",
                AbteilungName = $"Abteilung{id}",
                Fertigungslinien = tmp
            };
            return item;
        }

        public FertigungslinieDto GetFertigungslinieDto(int id)
        {
            List<MaschineDto> tmp = new List<MaschineDto>();
            for (int i = 0; i < id; i++)
            {
                tmp.Add(GenerateMaschine(id));
            }

            FertigungslinieDto item = new FertigungslinieDto()
            {
                ID = id,
                Name = $"linie{id}",
                FertigungName = $"Fertigung{id}"
            };

            return item;

        }

        public MaschineDto GetMaschineDto(int id)
        {
            return GenerateMaschine(id);
        }

        public ReparaturDto GetReparaturDto(int id)
        {
            return GenerateReparatur(id);
        }

        public UserDto GetUserDto(int id)
        {
            return GenerateUser(id);
        }

        public WartungDto GetWartungDto(int id)
        {
            return GenerateWartung(id);
        }

        public LoginDto GetLoginDto(int id)
        {
            return new LoginDto()
            {
                AnzeigeName = "Herr Login",
                LoginName = "Login",
                Password = "*****",
                LoginType = AufgabenGruppe.Administrator.ToString()

            };
        }

        public LoginDto GetLoginDto(string username, string password)
        {
            return new LoginDto()
            {
                AnzeigeName = "Herr Login",
                LoginName = username,
                Password = password,
                LoginType = AufgabenGruppe.Administrator.ToString()

            };
        }

        #endregion

        #region ViewModels

        #region Adminpages


        public AdminPageAbteilungDto GetAdminPageAbteilungDto()
        {
            AdminPageAbteilungDto value = new AdminPageAbteilungDto();
            value.Abteilungen = new List<ExtendedAdminAbteilungenDto>()
            {
                new ExtendedAdminAbteilungenDto()
                {
                    ID = 1,
                    Name = "Fertigung_1",
                    WerkName = "Werk_1",
                    Fertigungen = new List<FertigungDto>()
                    {
                        new FertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_1",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),
                                new FertigungslinieDto(),
                            }
                        },
                        new FertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_2",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),
                                new FertigungslinieDto(),
                            }
                        },
                        new FertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_3",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),

                            }
                        }
                    }

                },
                new ExtendedAdminAbteilungenDto()
                {
                    ID = 1,
                    Name = "Fertigung_2",
                    WerkName = "Werk_1",
                    Fertigungen = new List<FertigungDto>()
                    {
                        new FertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_10",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),
                                new FertigungslinieDto(),
                            }
                        },
                        new FertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_20",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),
                                new FertigungslinieDto(),
                            }
                        },
                        new FertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_30",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),

                            }
                        }
                    }
                }
            };

            return value;
        }

        public AdminPageBauteilDto GetAdminPageBauteilDto()
        {
            AdminPageBauteilDto value = new AdminPageBauteilDto();
            value.Bauteile = new List<BauteilDto>()
            {
                new BauteilDto()
                {
                    ID = 1,
                    Teilart = "Bauteil_1",
                    Version = "1.0",
                    Verwendungsort = "hier"
                },
                new BauteilDto()
                {
                    ID = 2,
                    Teilart = "Bauteil_2",
                    Version = "1.2",
                    Verwendungsort = "dort"
                },
                new BauteilDto()
                {
                    ID = 1,
                    Teilart = "Bauteil_3",
                    Version = "1.3",
                    Verwendungsort = "da hinten"
                }
            };
            return value;
        }

        public AdminPageFertigungDto GetAdminPageFertigungDto()
        {
            AdminPageFertigungDto value = new AdminPageFertigungDto();
            value.Fertigungen = new List<ExtendedAdminFertigungDto>()
                    {
                        new ExtendedAdminFertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_1",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()
                                {
                                    Name = "Fertigungslinie1_1"
                                },
                                new FertigungslinieDto()
                                {
                                    Name = "Fertigungslinie1_2"
                                },
                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_2",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()
                                {
                                    Name = "Fertigungslinie2_1"
                                },
                                new FertigungslinieDto()
                                {
                                    Name = "Fertigungslinie2_2"
                                },
                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_3",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()

                                {
                                    Name = "Fertigungslinie3_1"
                                },

                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_10",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()
                                {
                                    Name = "Fertigungslinie10_1"
                                },
                                new FertigungslinieDto()
                                {
                                    Name = "Fertigungslinie10_2"
                                },
                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_20",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()
                                {
                                    Name = "Fertigungslinie20_1"
                                },
                                new FertigungslinieDto()
                                {
                                    Name = "Fertigungslinie20_2"
                                },
                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            ID = 1,
                            Name = "Fertigung_30",
                            Fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()

                                {
                                    Name = "Fertigungslinie30_1"
                                },

                            }
                        }
            };
            return value;
        }

        public AdminPageFertigungslinieDto GetAdminPageFertigungslinieDto()
        {
            AdminPageFertigungslinieDto value = new AdminPageFertigungslinieDto();
            value.Fertigungslinien = new List<FertigungslinieDto>()
            {
                new FertigungslinieDto()
                {
                    ID = 1,
                    Name = "linie_1",
                    Arbeitsfolgen = new List<ArbeitsfolgeDto>()
                    {
                        new ArbeitsfolgeDto()
                        {
                            ID = 1,
                            ArbeitsfolgeName = "ABF_1",
                            Arbeitsplaene = "PL_1",
                            Status = ProMan_Database.Enums.StatusArt.Aufbau
                        },
                        new ArbeitsfolgeDto()
                        {
                            ID = 2,
                            ArbeitsfolgeName = "ABF_2",
                            Arbeitsplaene = "PL_2",
                            Status = ProMan_Database.Enums.StatusArt.Aufbau
                        }
                    }
                },
                                new FertigungslinieDto()
                {
                    ID = 2,
                    Name = "linie_2",
                    Arbeitsfolgen = new List<ArbeitsfolgeDto>()
                    {
                        new ArbeitsfolgeDto()
                        {
                            ID = 3,
                            ArbeitsfolgeName = "ABF_3",
                            Arbeitsplaene = "PL_3",
                            Status = ProMan_Database.Enums.StatusArt.AusserBetrieb
                        },
                        new ArbeitsfolgeDto()
                        {
                            ID = 4,
                            ArbeitsfolgeName = "ABF_3",
                            Arbeitsplaene = "PL_3",
                            Status = ProMan_Database.Enums.StatusArt.AusserBetrieb
                        }
                    }
                }
            };

            return value;
        }

        public AdminPageMaschineDto GetAdminPageMaschineDto()
        {
            AdminPageMaschineDto value = new AdminPageMaschineDto();
            value.Maschinen = new List<MaschineDto>()
            {
                new MaschineDto()
                {
                    ID = 1,
                    Anschaffungsdatum = DateTime.Now.AddDays(-10),
                    Garantie = DateTime.Now.AddDays(10),
                    Hersteller = "Masch_1",
                    Standort = "Stand_1",
                    Version = "1",
                    Zeichnungsnummer = "123",
                    Technologie = ProMan_Database.Enums.Technologie.drehen.ToString(),

                    AbteilungsName = "Abteilung_1",
                    Arbeitsfolge = "1",
                    FertigungslinienName = "Linie_1",
                    FertigungsName = "Fertigung_1"



                },
                                new MaschineDto()
                {
                    ID = 1,
                    Anschaffungsdatum = DateTime.Now.AddDays(-20),
                    Garantie = DateTime.Now.AddDays(20),
                    Hersteller = "Masch_2",
                    Standort = "Stand_2",
                    Version = "2",
                    Zeichnungsnummer = "456",
                    Technologie = ProMan_Database.Enums.Technologie.schleifen.ToString(),
                    AbteilungsName = "Abteilung_1",
                    Arbeitsfolge = "1",
                    FertigungslinienName = "Linie_1",
                    FertigungsName = "Fertigung_1"

                },
                                                new MaschineDto()
                {
                    ID = 1,
                    Anschaffungsdatum = DateTime.Now.AddDays(-30),
                    Garantie = DateTime.Now.AddDays(30),
                    Hersteller = "Masch_3",
                    Standort = "Stand_3",
                    Version = "3",
                    Zeichnungsnummer = "789",
                    Technologie = ProMan_Database.Enums.Technologie.waschen.ToString(),
                    AbteilungsName = "Abteilung_1",
                    Arbeitsfolge = "1",
                    FertigungslinienName = "Linie_1",
                    FertigungsName = "Fertigung_1"


                },
            };

            return value;
        }

        public AdminPageUserDto GetAdminPageUserDto()
        {
            AdminPageUserDto value = new AdminPageUserDto();

            value.User = new List<UserDto>()
            {
                new UserDto()
                {
                    Active = true,
                    Bemerkung = "Projektleiter",
                    Nachname = "Molkenthin",
                    Vorname = "Thomas",
                    Namenszusatz = ProMan_Database.Enums.Anrede.Herr,
                    ID = 3
                },
                                                new UserDto()
                {
                    Active = true,
                    Bemerkung = "Projektadmin",
                    Nachname = "Kessler",
                    Vorname = "Markus",
                    Namenszusatz = ProMan_Database.Enums.Anrede.Herr,
                    ID = 3
                },
                new UserDto()
                {
                    Active = true,
                    Bemerkung = "Projektmitarbeiter",
                    Nachname = "Molkenthin",
                    Vorname = "Sebastian",
                    Namenszusatz = ProMan_Database.Enums.Anrede.Herr,
                    ID = 3
                },
            };

            return value;
        }





        public NachrichtDto GetNachrichtDto(int id)
        {
            return new NachrichtDto()
            {
                Betreff = "Hallo Betreff",
                Text = "Hallo Text",
                Gelesen = false,
                ID = id,
                From = GetUserDto(1),
                To = GetUserDto(2),
                SendDate = DateTime.Now,
                Type = NachrichtenTyp.EMail
            };
        }

        public List<NachrichtDto> GetNarichtenFromUser(int UserID, DateTime fromDate)
        {
            return new List<NachrichtDto>()
            {
                            new NachrichtDto()
                            {
                                Betreff = "Hallo Betreff",
                                Text = "Hallo Text",
                                Gelesen = false,
                                ID = UserID,
                                From = GetUserDto(1),
                                To = GetUserDto(2),
                                SendDate = DateTime.Now,
                                Type = NachrichtenTyp.EMail
                            },
                         new NachrichtDto()
                        {
                            Betreff = "Hallo Betreff2",
                            Text = "Hallo Text2",
                            Gelesen = false,
                            ID = UserID,
                            From = GetUserDto(1),
                            To = GetUserDto(2),
                            SendDate = DateTime.Now,
                            Type = NachrichtenTyp.EMail
                        }
        };
        }

        public bool SetNachrichtDto(NachrichtDto data)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNachrichtDto(NachrichtDto data, int id)
        {
            throw new NotImplementedException();
        }



        #endregion

        #region MF

        public MFAbteilungOverviewDto GetMFAbteilungOverviewDto(int id)
        {
            var item = new MFAbteilungOverviewDto()
            {
                Abteilungsname = "Abteilung_1",
                Fertigungen = new List<MFFertigungDto>()
                {
                    new MFFertigungDto()
                    {
                        Abteilung = "Abteilung_1",
                        Bereich = "Bereich_1",
                        Ort = "Kassel",
                        Name = "Fertigung1",
                        Werk = "Werk_1",
                        Type = ProMan_Database.Enums.Fertigungstype.Gruenfertigung,
                        AuditsCount = 5,
                        BauteileCount = 20,
                        ReparaturenCount = 0,
                        WartungenCount = 2
                    },
                    new MFFertigungDto()
                    {
                        Abteilung = "Abteilung_1",
                        Bereich = "Bereich_2",
                        Ort = "Kassel",
                        Name = "Fertigung2",
                        Werk = "Werk_1",
                        Type = ProMan_Database.Enums.Fertigungstype.Haerterei,
                        AuditsCount = 2,
                        BauteileCount = 10,
                        ReparaturenCount = 1,
                        WartungenCount = 0
                    }
                },
            };

            return item;

        }

        public MFLinieDto GetMFLinieDto(int id)
        {
            var item = new MFLinieDto()
            {
                Aktuelle_Stueckzahl_Ist = 100,
                Aktuelle_Stueckzahl_Soll = 200,
                Aktuelle_Teilenummer = "Teil_123",
                Naechste_Stueckzahl_Soll = 300,
                Naechste_Teilnummer = "Teil_456",
                Audits_Done_Count = 5,
                Audits_Done_Open = 2,
                Reparaturen_Count = 10,
                Reparaturen_Done_Count = 5,
                Reparaturen_Done_History = 20,
                Reparaturen_Done_Open = 5,
                Wartung_Count = 2,
                Wartung_Done_Open = 2,
                Wartung_Done_Count = 10,
                Wartung_Done_History = 50,
                Optimierungen_Done_Count = 1,
                Optimierungen_Done_Open = 0,
                Halle = "Halle_1",
                Name = "Linie_1",
                Schicht = "Erste_Schicht",
                Werk = "Kassel",
                Ort = "Alpha",
                Verantwortlicher = new UserDto()
                {
                    Nachname = "Heinrich",
                    Vorname = "Dieter",
                    Festnetz = "0123/456790"
                },
                Maschinen = new List<MaschineDto>()
                {
                    new MaschineDto()
                    {
                        Inventarnummer = "123",
                        Zeichnungsnummer = "as 5455 78a v1.1",
                        Anschaffungsdatum = DateTime.Now.AddYears(-5),
                        Garantie = DateTime.Now.AddYears(2),
                    },
                                        new MaschineDto()
                    {
                        Inventarnummer = "456",
                        Zeichnungsnummer = "as 5455 78a v1.2",
                        Anschaffungsdatum = DateTime.Now.AddYears(-3),
                        Garantie = DateTime.Now.AddYears(6),
                    }
                }

            };

            return item;
        }


        public List<MFFertigungDto> GetMFFertigungDto()
        {
            throw new NotImplementedException();
        }

        public MFInstandhaltung GetMFInstandhaltung()
        {
            var item = new MFInstandhaltung();

            return item;
        }


        #endregion

        #endregion

        #region Generate Data

        private WartungDto GenerateWartung(int id)
        {
            return new WartungDto()
            {
            };
        }

        private UserDto GenerateUser(int id)
        {
            return new UserDto()
            {
            };
        }

        private ReparaturDto GenerateReparatur(int id)
        {
            return new ReparaturDto()
            {
                ID = id,
                Status = "Finish",
                Dauer = new DateTime().AddHours(id),
                InventarNummer = 1,
                Start = DateTime.Now.AddHours(-id),
                User = GetUserDto(0),
                Zeichnungsnummer = $"Reparatur_{id}"
            };
        }

        private MaschineDto GenerateMaschine(int id)
        {
            return new MaschineDto()
            {
            };
        }

        #endregion
    }
}
