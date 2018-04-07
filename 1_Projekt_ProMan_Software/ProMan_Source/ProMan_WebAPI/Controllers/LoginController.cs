using System.Collections.Generic;
using System.Web.Http;
using ProMan_WebAPI.Base;
using ProMan_BusinessLayer.Models;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("login")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : BaseApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //[HttpGet]
        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetLoginDto(id)));
        }

        //[HttpGet]
        // GET api/<controller>/?username=&password=
        public IHttpActionResult Get(string username, string password)
        {
            return Ok(JToken.FromObject(dataprovider.GetLoginDto(username,password)));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]LoginDto value)
        {
            return Ok(dataprovider.SetLoginDto(value));
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]LoginDto value)
        {
            dataprovider.UpdateLoginDto(value,id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}