using System;
using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_Database;
using System.Linq;
using ProMan_Database.Model;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseDelete : IDeleteDataProvider
    {
        ProManContext dbcontext = new ProManContext();

        public bool DeleteAbteilungDto(int id)
        {
            var item = dbcontext.Abteilungen.FirstOrDefault(x => x.AbteilungID == id);
            if (item == null)
            {
                return false;
            }
                

            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Abteilungen.Remove(item);
                dbcontext.SaveChanges();
            }
            catch(Exception)
            {
                return false;
            }
            

            return true;
        }

        public bool DeleteAuditDto(int id)
        {
            var item = dbcontext.Audits.FirstOrDefault(x => x.AuditID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Audits.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }



        public bool DeleteFertigungsDto(int id)
        {
            var item = dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Fertigungen.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }

        public bool DeleteFertigungslinieDto(int id)
        {
            var item = dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Fertigungslinien.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }



        public bool DeleteLoginDto(int id)
        {
            var item = dbcontext.Logins.FirstOrDefault(x => x.LoginID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Logins.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }

        public bool DeleteMaschineDto(int id)
        {
            var item = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Maschinen.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }



        public bool DeleteNachrichtDto(int id)
        {
            var item = dbcontext.Nachrichten.FirstOrDefault(x => x.NachrichtID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Nachrichten.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }



        public bool DeleteReparaturDto(int id)
        {
            var item = dbcontext.Reparaturen.FirstOrDefault(x => x.ReparaturID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Reparaturen.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }



        public bool DeleteUserDto(int id)
        {
            var item = dbcontext.Mitarbeiter.FirstOrDefault(x => x.MitarbeiterID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Mitarbeiter.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }

        public bool DeleteWartungDto(int id)
        {
            var item = dbcontext.Wartungen.FirstOrDefault(x => x.WartungID == id);
            if (item == null)
            {
                return false;
            }


            //try to remove it. If it is locked, an exception will be thrown
            try
            {
                dbcontext.Wartungen.Remove(item);
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }

        public bool DeleteBauteilVerwendungDto(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteInstandhaltungsAuftragDto(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLagerBestandDto(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserAnfrageDto(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduktionsplanDto(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMaschineVerwendungDto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
