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
        public IEnumerable<LoginDto> Get()
        {
            return dataprovider.GetListDataProvider.GetLoginDto();
        }

        //[HttpGet]
        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetLoginDto(id)));
        }

        //[HttpGet]
        // GET api/<controller>/?username=&password=
        public IHttpActionResult Get(string username, string password)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetLoginDto(username,password)));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]LoginDto value)
        {
            return Ok(dataprovider.CreateDataProvider.SetLoginDto(value));
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]LoginDto value)
        {
            dataprovider.UpdateDataProvider.UpdateLoginDto(value,id);
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteLoginDto(id);
            return Ok();
        }
    }
}