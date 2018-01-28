using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("fertigungslinie")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FertigungslinieController : BaseApiController
    {

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {


            return Ok(JToken.FromObject(dataprovider.GetFertigungslinieDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]FertigungslinieDto value)
        {
            dataprovider.SetFertigungslinieDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]FertigungslinieDto value)
        {
            dataprovider.UpdateFertigungslinieDto(value, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}