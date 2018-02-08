using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AbteilungController : BaseApiController
    {
        // GET: api/Abteilung
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Abteilung/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetAbteilungDto(id)));
        }

        // POST: api/Abteilung
        public void Post([FromBody]AbteilungDto value)
        {
            dataprovider.SetAbteilungDto(value);
        }

        // PUT: api/Abteilung/5
        public void Put(int id, [FromBody]AbteilungDto value)
        {
            dataprovider.UpdateAbteilungDto(value,id);
        }

        // DELETE: api/Abteilung/5
        public void Delete(int id)
        {
        }
    }
}
