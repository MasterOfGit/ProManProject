using ProMan_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_WebAPI.Models;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("wartung")]
    public class WartungController : ApiController
    {
        ProManContext dbcontext = new ProManContext();

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var item = dbcontext.Wartungen.FirstOrDefault(x => x.MaschineID == id);
            var itemmaschine = dbcontext.Maschinen.FirstOrDefault(x => item.MaschineID == x.MaschineID);

            WartungDto wartung = new WartungDto()
            {
                InventarNummer = itemmaschine.InventarNummer,
                Zeichnungsnummer = itemmaschine.Zeichnungsnummer,
                Beschreibung = item.Beschreibung,
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
                WartungsInterval = item.WartungsInterval.GetValueOrDefault(),
            };
            return Ok(wartung);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}