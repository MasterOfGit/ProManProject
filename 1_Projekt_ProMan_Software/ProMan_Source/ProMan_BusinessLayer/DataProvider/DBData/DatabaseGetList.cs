using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseGetList : IGetListDataProvider
    {
        ProManContext dbcontext = new ProManContext();

        public List<AbteilungDto> GetAbteilungDto()
        {
            throw new NotImplementedException();
        }

        public List<FertigungDto> GetFertigungsDto()
        {
            throw new NotImplementedException();
        }

        public List<FertigungslinieDto> GetFertigungslinieDto()
        {
            throw new NotImplementedException();
        }

        public List<LoginDto> GetLoginDto()
        {
            throw new NotImplementedException();
        }

        public List<MaschineDto> GetMaschineDto()
        {
            throw new NotImplementedException();
        }

        public List<MFFertigungDto> GetMFFertigungDto()
        {
            throw new NotImplementedException();
        }

        public List<NachrichtDto> GetNarichtenFromUser()
        {
            throw new NotImplementedException();
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

                });
            }
            return nachrichten;
        }

        public List<ReparaturDto> GetReparaturDto()
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetUserDto()
        {
            throw new NotImplementedException();
        }

        public List<WartungDto> GetWartungDto()
        {
            throw new NotImplementedException();
        }
    }
}
