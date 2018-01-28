using ProMan_BusinessLayer.DataProvider;
using ProMan_BusinessLayer.Models;
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;
using ProMan_WebAPI.Base;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("wartung")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WartungController : BaseApiController
    {

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {

            return Ok(JToken.FromObject(dataprovider.GetWartungDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]WartungDto value)
        {
            dataprovider.SetWartungDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]WartungDto value)
        {
            dataprovider.UpdateWartungDto(value,id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}