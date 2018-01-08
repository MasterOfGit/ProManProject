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
    [RoutePrefix("maschine")]
    public class MaschineController : ApiController
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
            var item = dbcontext.Maschinen.FirstOrDefault(x => x.MaschineID == id);
            MaschineDto maschine = new MaschineDto()
            {
                InventarNummer = item.InventarNummer,
                Zeichnungsnummer = item.Zeichnungsnummer,
                Baujahr = item.Baujahr.GetValueOrDefault(),
                Garantie = item.Garantie.GetValueOrDefault(),
                MaschinenStatus = item.MaschinenStatus,
                Hersteller = item.Hersteller.Name,
                Type = item.Type.Name

            };

            return Ok(maschine);
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