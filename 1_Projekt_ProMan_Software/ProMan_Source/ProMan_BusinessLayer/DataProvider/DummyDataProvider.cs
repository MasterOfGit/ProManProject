﻿using System;
using System.Collections.Generic;
using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.AdminPages;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;
using System.Linq;

namespace ProMan_BusinessLayer.DataProvider
{
    /// <summary>
    /// Generates dummy data for the view. Does not support setting or updating data
    /// </summary>
    public class DummyDataProvider : IDataProvider
    {
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
        #region set

        public bool SetFertigungsDto(FertigungDto data)
        {
            return true;
        }

        public bool SetFertigungslinieDto(FertigungslinieDto data)
        {
            return true;
        }

        public bool SetMaschineDto(MaschineDto data)
        {
            return true;
        }

        public bool SetReparaturDto(ReparaturDto data)
        {
            return true;
        }

        public bool SetUserDto(UserDto data)
        {
            return true;
        }

        public bool SetWartungDto(WartungDto data)
        {
            return true;
        }

        public bool SetAbteilungDto(AbteilungDto data)
        {
            return true;
        }
        #endregion

        #region Update

        public bool UpdateFertigungsDto(FertigungDto data, int id)
        {
            return true;
        }

        public bool UpdateFertigungslinieDto(FertigungslinieDto data, int id)
        {
            return true;
        }

        public bool UpdateMaschineDto(MaschineDto data, int id)
        {
            return true;
        }

        public bool UpdateReparaturDto(ReparaturDto data, int id)
        {
            return true;
        }

        public bool UpdateUserDto(UserDto data, int id)
        {
            return true;
        }

        public bool UpdateWartungDto(WartungDto data, int id)
        {
            return true;
        }
        public bool UpdateAbteilungDto(AbteilungDto data, int id)
        {
            return true;
        }



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

        #region Adminpages


        public AdminPageAbteilungDto GetAdminPageAbteilungDto()
        {
            AdminPageAbteilungDto value = new AdminPageAbteilungDto();
            value.Abteilungen = new List<AbteilungDto>()
            {
                new AbteilungDto()
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
                new AbteilungDto()
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
            value.Abteilungsnamen = new List<string>();
            value.Fertigungsnamen = new List<string>();
            foreach (var item in value.Abteilungen)
            {
                if (!value.Abteilungsnamen.Contains(item.Name))
                    value.Abteilungsnamen.Add(item.Name);
                
                foreach(var fert in item.Fertigungen)
                {
                    if (!value.Fertigungsnamen.Contains(fert.Name))
                        value.Fertigungsnamen.Add(fert.Name);
                }

            }

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
            value.Fertigungen = new List<FertigungDto>()
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
                        },
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

        public List<MFFertigungDto> GetMFFertigungDto()
        {
            throw new NotImplementedException();
        }

        public MFInstandhaltung GetMFInstandhaltung()
        {
            throw new NotImplementedException();
        }

        public MFLinieDto GetMFLinieDto()
        {
            throw new NotImplementedException();
        }

        public NachrichtDto GetNachrichtDto(int id)
        {
            throw new NotImplementedException();
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

    }
}