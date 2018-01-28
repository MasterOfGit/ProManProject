using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_WebAPI.Models;
using ProMan_Database;
using ProMan_WebAPI.DataProvider;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("reparatur")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReparaturController : ApiController
    {
        IDataProvider dataprovider = new DataProviderFactory().data;

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetReparaturDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]ReparaturDto value)
        {
            dataprovider.SetReparaturDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]ReparaturDto value)
        {
            dataprovider.UpdateReparaturDto(value, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}