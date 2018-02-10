﻿using ProMan_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.DataProvider
{
    public interface IDataProvider
    {
        FertigungDto GetFertigungsDto(int id);
        bool SetFertigungsDto(FertigungDto data);
        bool UpdateFertigungsDto(FertigungDto data, int id);

        FertigungslinieDto GetFertigungslinieDto(int id);
        bool SetFertigungslinieDto(FertigungslinieDto data);
        bool UpdateFertigungslinieDto(FertigungslinieDto data, int id);

        MaschineDto GetMaschineDto(int id);
        bool SetMaschineDto(MaschineDto data);
        bool UpdateMaschineDto(MaschineDto data, int id);

        ReparaturDto GetReparaturDto(int id);
        bool SetReparaturDto(ReparaturDto data);
        bool UpdateReparaturDto(ReparaturDto data, int id);

        UserDto GetUserDto(int id);
        bool SetUserDto(UserDto data);
        bool UpdateUserDto(UserDto data, int id);

        WartungDto GetWartungDto(int id);
        bool SetWartungDto(WartungDto data);
        bool UpdateWartungDto(WartungDto data, int id);

        AbteilungDto GetAbteilungDto(int id);
        bool SetAbteilungDto(AbteilungDto data);
        bool UpdateAbteilungDto(AbteilungDto data, int id);

        WerkDto GetWerkDto(int id);
        bool SetWerkDto(WerkDto data);
        bool UpdateWerkDto(WerkDto data, int id);
    }
}