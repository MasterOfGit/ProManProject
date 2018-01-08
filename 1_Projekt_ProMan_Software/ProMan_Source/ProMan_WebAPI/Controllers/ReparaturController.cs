using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_WebAPI.Models;
using ProMan_Database;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("reparatur")]
    public class ReparaturController : ApiController
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
            var item = dbcontext.Reparaturen.FirstOrDefault(x => x.Maschine.MaschineID == id);

            ReparaturDto reparatur = new ReparaturDto()
            {
                InventarNummer = item.Maschine.InventarNummer,
                Zeichnungsnummer = item.Maschine.Zeichnungsnummer,
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
                Start = item.Start.GetValueOrDefault(),
                Dauer = item.Dauer.GetValueOrDefault(),
            };
            return Ok(reparatur);
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