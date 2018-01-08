﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_WebAPI.Models;
using ProMan_Database;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("fertigungslinie")]
    public class FertigungslinieController : ApiController
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
            var item = dbcontext.Fertigungslinien.FirstOrDefault(x => x.FertigungslinieID == id);

            FertigungslinieDto fertigungslinie = new FertigungslinieDto()
            {
                Maschinen = item.Maschinen.Select(x => new MaschineDto()
                {
                    InventarNummer = x.InventarNummer,
                    Zeichnungsnummer = x.Zeichnungsnummer,
                    MaschinenStatus = x.MaschinenStatus,
                }).ToList()
            };


            return Ok(fertigungslinie);
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