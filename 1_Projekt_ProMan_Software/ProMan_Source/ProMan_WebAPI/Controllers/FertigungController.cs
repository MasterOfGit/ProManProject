using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FertigungController : BaseApiController
    {
        // GET: api/Fertigung
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Fertigung/5
        public IHttpActionResult Get(int id)
        {

            return Ok(JToken.FromObject(dataprovider.GetFertigungsDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]FertigungDto value)
        {
            dataprovider.SetFertigungsDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]FertigungDto value)
        {
            dataprovider.UpdateFertigungsDto(value, id);
        }

        // DELETE: api/Fertigung/5
        public void Delete(int id)
        {
        }
    }
}
