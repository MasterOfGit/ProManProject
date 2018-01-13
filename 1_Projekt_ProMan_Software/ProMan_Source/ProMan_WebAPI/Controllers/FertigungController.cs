using ProMan_Database;
using ProMan_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProMan_WebAPI.Controllers
{
    public class FertigungController : ApiController
    {
        ProManContext dbcontext = new ProManContext();

        // GET: api/Fertigung
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Fertigung/5
        public IHttpActionResult Get(int id)
        {
            var item = dbcontext.Fertigungen.FirstOrDefault(x => x.FertigungID == id);

            FertigungDto fertigung = new FertigungDto()
            {
                ID = item.FertigungID,
                Fertigungslinien = item.Fertigungslinien.Select(x => new FertigungslinieDto()
                {
                    Maschinen = x.Maschinen.Select(y => new MaschineDto()
                    {
                        InventarNummer = y.InventarNummer,
                        Zeichnungsnummer = y.Zeichnungsnummer,
                        MaschinenStatus = y.MaschinenStatus,
                    }).ToList()
                }).ToList()
            };

            return Ok(fertigung);
        }

        // POST: api/Fertigung
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Fertigung/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Fertigung/5
        public void Delete(int id)
        {
        }
    }
}
