using ProMan_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    public interface IUpdateDataProvider
    {
        bool UpdateFertigungsDto(FertigungDto data, int id);
        bool UpdateFertigungslinieDto(FertigungslinieDto data, int id);
        bool UpdateMaschineDto(MaschineDto data, int id);
        bool UpdateReparaturDto(ReparaturDto data, int id);
        bool UpdateUserDto(UserDto data, int id);
        bool UpdateWartungDto(WartungDto data, int id);
        bool UpdateAbteilungDto(AbteilungDto data, int id);
        bool UpdateNachrichtDto(NachrichtDto data, int id);
        bool UpdateLoginDto(LoginDto data, int id);
    }
}
