using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;
using ProMan_BusinessLayer.DataProvider;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("maschine")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MaschineController : BaseApiController
    {

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {


            return Ok(JToken.FromObject(dataprovider.GetMaschineDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]MaschineDto value)
        {
            dataprovider.SetMaschineDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]MaschineDto value)
        {
            dataprovider.UpdateMaschineDto(value, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}