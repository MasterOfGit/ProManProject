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
                abteilungsID = id,
                abteilungsname = $"Abteilung{id}",
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
                fertigungsID = id,
                fertigungsname = $"Fertigung{id}",
                //AbteilungName = $"Abteilung{id}",
                fertigungslinien = tmp
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
                fertigungslinieID = id,
                //fertigungslinienname = $"linie{id}",
                fertigungslinienname = $"Fertigung{id}"
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
                userID = id,
                userKennung = "Herr Login",
                userpasswort = "*****",
                userbereich = AufgabenGruppe.Administrator.ToString(),
                userLastLogin = DateTime.Now,
                userStatus = "aktiv",

            };
        }

        public LoginDto GetLoginDto(string username, string password)
        {
            return new LoginDto()
            {
                userID = 1,
                userKennung = username,
                userpasswort = password,
                userbereich = AufgabenGruppe.Administrator.ToString(),
                userLastLogin = DateTime.Now,
                userStatus = "aktiv",

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
                    abteilungsID = 1,
                    abteilungsname = "Fertigung_1",
                    WerkName = "Werk_1",
                    Fertigungen = new List<FertigungDto>()
                    {
                        new FertigungDto()
                        {
                            fertigungsID = 1,
                            fertigungsname = "Fertigung_1",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),
                                new FertigungslinieDto(),
                            }
                        },
                        new FertigungDto()
                        {
                            fertigungsID = 1,
                            fertigungsname = "Fertigung_2",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),
                                new FertigungslinieDto(),
                            }
                        },
                        new FertigungDto()
                        {
                            fertigungsID = 1,
                            fertigungsname = "Fertigung_3",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),

                            }
                        }
                    }

                },
                new ExtendedAdminAbteilungenDto()
                {
                    abteilungsID = 1,
                    abteilungsname = "Fertigung_2",
                    WerkName = "Werk_1",
                    Fertigungen = new List<FertigungDto>()
                    {
                        new FertigungDto()
                        {
                            fertigungsID = 1,
                            fertigungsname = "Fertigung_10",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),
                                new FertigungslinieDto(),
                            }
                        },
                        new FertigungDto()
                        {
                            fertigungsID = 1,
                            fertigungsname = "Fertigung_20",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto(),
                                new FertigungslinieDto(),
                            }
                        },
                        new FertigungDto()
                        {
                            fertigungsID = 1,
                            fertigungsname = "Fertigung_30",
                            fertigungslinien = new List<FertigungslinieDto>()
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
                    bauteileID = 1,
                    bauteilArt = "Bauteil_1",
                    bauteilVersion = "1.0",
                    bauteilIndex = "A",
                    bauteilIDNachfolger = 2,
                    bauteilStatus = "aktiv",
                    bauteilNummer = "111 222 333",
                },
                new BauteilDto()
                {
                    bauteileID = 2,
                    bauteilArt = "Bauteil_2",
                    bauteilVersion = "2.0",
                    bauteilIndex = "A",
                    bauteilIDNachfolger = 3,
                    bauteilStatus = "aktiv",
                    bauteilNummer = "111 222 333",
                },
                new BauteilDto()
                {
                    bauteileID = 3,
                    bauteilArt = "Bauteil_3",
                    bauteilVersion = "1.3",
                    bauteilIndex = "A",
                    bauteilIDNachfolger = 3,
                    bauteilStatus = "aktiv",
                    bauteilNummer = "111 222 333",
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
                            fertigungsID = 1,
                            fertigungsname = "Fertigung_1",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()
                                {
                                    fertigungslinieID = 1,
                                    fertigungslinienname = "Fertigungslinie1_1"
                                },
                                new FertigungslinieDto()
                                {
                                    fertigungslinieID = 2,
                                    fertigungslinienname = "Fertigungslinie1_2"
                                },
                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            fertigungsID = 2,
                            fertigungsname = "Fertigung_2",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()
                                {
                                    fertigungslinieID = 3,
                                    fertigungslinienname = "Fertigungslinie2_1"
                                },
                                new FertigungslinieDto()
                                {
                                    fertigungslinieID = 4,
                                    fertigungslinienname = "Fertigungslinie2_2"
                                },
                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            fertigungsID = 3,
                            fertigungsname = "Fertigung_3",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()

                                {
                                    fertigungslinieID = 5,
                                    fertigungslinienname = "Fertigungslinie3_1"
                                },

                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            fertigungsID = 4,
                            fertigungsname = "Fertigung_10",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()
                                {
                                    fertigungslinieID = 5,
                                    fertigungslinienname = "Fertigungslinie10_1"
                                },
                                new FertigungslinieDto()
                                {
                                    fertigungslinieID = 6,
                                    fertigungslinienname = "Fertigungslinie10_2"
                                },
                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            fertigungsID = 5,
                            fertigungsname = "Fertigung_20",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()
                                {
                                    fertigungslinieID = 7,
                                    fertigungslinienname = "Fertigungslinie20_1"
                                },
                                new FertigungslinieDto()
                                {
                                    fertigungslinieID = 8,
                                    fertigungslinienname = "Fertigungslinie20_2"
                                },
                            }
                        },
                        new ExtendedAdminFertigungDto()
                        {
                            fertigungsID = 6,
                            fertigungsname = "Fertigung_30",
                            fertigungslinien = new List<FertigungslinieDto>()
                            {
                                new FertigungslinieDto()

                                {
                                    fertigungslinieID = 9,
                                    fertigungslinienname = "Fertigungslinie30_1"
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
                    fertigungslinieID = 1,
                    fertigungslinienname = "linie_1",
                    arbeitsfolgen = new List<ArbeitsfolgeDto>()
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
                    fertigungslinieID = 2,
                    fertigungslinienname = "linie_2",
                    arbeitsfolgen = new List<ArbeitsfolgeDto>()
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
                    maschinenID = 1,
                    Anschaffungsdatum = DateTime.Now.AddDays(-10),
                    Garantie = DateTime.Now.AddDays(10),
                    hersteller = "Masch_1",
                    standort = "Stand_1",
                    Version = "1",
                    Zeichnungsnummer = "123",
                    technologie = ProMan_Database.Enums.Technologie.drehen.ToString(),

                    AbteilungsName = "Abteilung_1",
                    Arbeitsfolge = "1",
                    FertigungslinienName = "Linie_1",
                    FertigungsName = "Fertigung_1",
                    abteilungsId =1,
                    maschinenInventarNummer = "111 222 333",
                    status = "aktiv"



                },
                                new MaschineDto()
                {
                    maschinenID = 1,
                    Anschaffungsdatum = DateTime.Now.AddDays(-20),
                    Garantie = DateTime.Now.AddDays(20),
                    hersteller = "Masch_2",
                    standort = "Stand_2",
                    Version = "2",
                    Zeichnungsnummer = "456",
                    technologie = ProMan_Database.Enums.Technologie.schleifen.ToString(),
                    AbteilungsName = "Abteilung_1",
                    Arbeitsfolge = "1",
                    FertigungslinienName = "Linie_1",
                    FertigungsName = "Fertigung_1",
                    abteilungsId =1,
                    maschinenInventarNummer = "111 222 333",
                    status = "aktiv"

                },
                                                new MaschineDto()
                {
                    maschinenID = 1,
                    Anschaffungsdatum = DateTime.Now.AddDays(-30),
                    Garantie = DateTime.Now.AddDays(30),
                    hersteller = "Masch_3",
                    standort = "Stand_3",
                    Version = "3",
                    Zeichnungsnummer = "789",
                    technologie = ProMan_Database.Enums.Technologie.waschen.ToString(),
                    AbteilungsName = "Abteilung_1",
                    Arbeitsfolge = "1",
                    FertigungslinienName = "Linie_1",
                    FertigungsName = "Fertigung_1",
                    abteilungsId =1,
                    maschinenInventarNummer = "111 222 333",
                    status = "aktiv"
                    


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
                    userActive = true,
                    userBemerkung = "Projektleiter",
                    userNachname = "Molkenthin",
                    userVorname = "Thomas",
                    userAnrede = ProMan_Database.Enums.Anrede.Herr.ToString(),
                    userID = 3,
                    
                },
                                                new UserDto()
                {
                    userActive = true,
                    userBemerkung = "Projektadmin",
                    userNachname = "Kessler",
                    userVorname = "Markus",
                    userAnrede = ProMan_Database.Enums.Anrede.Herr.ToString(),
                    userID = 3
                },
                new UserDto()
                {
                    userActive = true,
                    userBemerkung = "Projektmitarbeiter",
                    userNachname = "Molkenthin",
                    userVorname = "Sebastian",
                    userAnrede = ProMan_Database.Enums.Anrede.Herr.ToString(),
                    userID = 3
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
                NachrichtenStatus = "Gelesen",
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
                                NachrichtenStatus = "Gelesen",
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
                            NachrichtenStatus = "Gelesen",
                            ID = UserID,
                            From = GetUserDto(1),
                            To = GetUserDto(2),
                            SendDate = DateTime.Now,
                            Type = NachrichtenTyp.EMail
                        }
        };
        }


        public AuditDto GetAuditDto(int id)
        {
            return new AuditDto()
            {
                auditID = 1,
                abteilung = 1,
                auditart = "Irgendwas",
                beurteilung = "Gut",
                nacharbeiten = "nein",
                status = "erledigt",
                termin = DateTime.Now,
                terminturnus = "monatlich"
            };
        }

        public BauteilVerwendungDto GetBauteilVerwendungDto(int id)
        {
            return new BauteilVerwendungDto()
                {
                bauteileID = 1,
                bearbeitungen = "irgendwas",
                bearbeitungsschritt = 2,
                fertingungsLinienID = 1,
                technologie = "fräsen",
                verwendungsZweck = "Auto"


            };
        }

        public InstandhaltungsAuftragDto GetInstandhaltungsAuftragDto(int id)
        {
            return new InstandhaltungsAuftragDto()
            {
                abteilung = 1,
                auftragsstatus = "offen",
                fachbereich = "werk",
                fachrichtung = "maschine",
                fehlertext = "Hier ist ein Fehler für dich",
                machinenIventarnummer = "111 222 333",
                instandhaltungID = 1,
                thema = "Kaput gemacht"
            };
        }

        public LagerBestandDto GetLagerBestandDto(int id)
        {
            return new LagerBestandDto()
            {
                bauteilID = 1,
                bauteilindex = "A",
                bauteilname = "111 222 333",
                bauteilverwendung = "Dinge",
                istBestand = 500,
                lagerplatz = "Regal",
                minBestand = 300
            };
        }

        public MaschineVerwendungDto GetMaschineVerwendungDto(int id)
        {
            return new MaschineVerwendungDto()
            {
                abteilungID = 1,
                arbeitsfolge = 2,
                bauteileID = 3,
                fertigungID = 4,
                fertigungslinieID = 5,
                maschinenID = 6
            };
        }

        public ProduktionsplanDto GetProduktionsplanDto(int id)
        {
            return new ProduktionsplanDto()
            {
                bauteilindex = "A",
                bauteilname = "111 222 333",
                bauteilverwendung = "Auto",
                folgenummer = 2,
                prodMenge = 500,
                status = "offen"
                
            };
        }

        public UserAnfrageDto GetUserAnfrageDto(int id)
        {
            return new UserAnfrageDto()
            {
                userId = 1,
                userAnfrageStatus = "offen",
                userGrund = "Nerven",
                userNachricht = "Hier ist eine Spam Nachricht"
            };
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
                    userNachname = "Heinrich",
                    userVorname = "Dieter",
                    userFestnetzNr = "0123/456790"
                },
                Maschinen = new List<MaschineDto>()
                {
                    new MaschineDto()
                    {
                        maschinenInventarNummer = "123",
                        Zeichnungsnummer = "as 5455 78a v1.1",
                        Anschaffungsdatum = DateTime.Now.AddYears(-5),
                        Garantie = DateTime.Now.AddYears(2),
                    },
                                        new MaschineDto()
                    {
                        maschinenInventarNummer = "456",
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
                InventarNummer = "1",
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

        public BauteilDto GetBauteilDto(int id)
        {
            return new BauteilDto()
            {
                bauteileID = id,
            };
        }

        public bool ExecuteLoginDto(string username, string password)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}
