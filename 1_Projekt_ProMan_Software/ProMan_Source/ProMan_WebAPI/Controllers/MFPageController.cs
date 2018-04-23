///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using Newtonsoft.Json.Linq;
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
    public class MFPageController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/<controller>/?identifier=
        public IHttpActionResult Get(string identifier)
        {
            JToken returnvalue = null;
            switch (identifier)
            {
                case "MFAbteilungOverviewDto":
                    returnvalue = JToken.FromObject(dataprovider.GetSingleProvider.GetMFAbteilungOverviewDto(1));
                    break;
                case "MFLinieDto":
                    returnvalue = JToken.FromObject(dataprovider.GetSingleProvider.GetMFLinieDto(1));
                    break;
                default:
                    break;

            }

            return Ok(returnvalue);

        }

        // GET: api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
