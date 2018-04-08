using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_Database;
using ProMan_Database.Enums;
using System;
using System.Linq;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseUpdate : IUpdateDataProvider
    {

        ProManContext dbcontext = new ProManContext();
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

        public bool UpdateNachrichtDto(NachrichtDto data, int id)
        {
            throw new NotImplementedException();
        }







        public bool UpdateLoginDto(LoginDto data, int id)
        {
            var item = dbcontext.Logins.FirstOrDefault(x => x.LoginID == id);

            AufgabenGruppe tmp;

            Enum.TryParse(data.LoginType, out tmp);

            dbcontext.Logins.Add(new ProMan_Database.Model.Login()
            {
                Username = data.LoginName,
                Password = data.Password,
                LoginType = tmp,
            });

            dbcontext.SaveChanges();

            return true;
        }



        #endregion
    }
}
