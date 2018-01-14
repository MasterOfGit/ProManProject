using ProMan_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_WebAPI.DataProvider
{
    public interface IDataProvider
    {
        FertigungDto GetFertigungsDto(int id);
        bool SetFertigungsDto(FertigungDto data);

        FertigungslinieDto GetFertigungslinieDto(int id);
        bool SetFertigungslinieDto(FertigungslinieDto data);

        MaschineDto GetMaschineDto(int id);
        bool SetMaschineDto(MaschineDto data);

        ReparaturDto GetReparaturDto(int id);
        bool SetReparaturDto(ReparaturDto data);

        UserDto GetUserDto(int id);
        bool SetUserDto(UserDto data);

        WartungDto GetWartungDto(int id);
        bool SetWartungDto(WartungDto data);
    }
}
