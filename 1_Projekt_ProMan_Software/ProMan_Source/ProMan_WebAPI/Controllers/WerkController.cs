using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WerkController : BaseApiController
    {
        // GET: api/Werk
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Werk/5
        public IHttpActionResult Get(int id)
        {
            //return Ok(JToken.FromObject(dataprovider.GetWerkDto(id)));
            return Ok(dataprovider.GetWerkDto(id));
        }

        // POST: api/Werk
        public void Post([FromBody]WerkDto value)
        {
            dataprovider.SetWerkDto(value);
        }

        // PUT: api/Werk/5
        public void Put(int id, [FromBody]WerkDto value)
        {
            dataprovider.UpdateWerkDto(value, id);
        }

        // DELETE: api/Werk/5
        public void Delete(int id)
        {
        }
    }
}
