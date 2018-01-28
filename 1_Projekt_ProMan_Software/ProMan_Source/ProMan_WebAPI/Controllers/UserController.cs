using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_Database;
using ProMan_WebAPI.Models;
using ProMan_WebAPI.DataProvider;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("user")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        IDataProvider dataprovider = new DataProviderFactory().data;

        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {

            return Ok(JToken.FromObject(dataprovider.GetUserDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]UserDto value)
        {
            dataprovider.SetUserDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]UserDto value)
        {
            dataprovider.UpdateUserDto(value, id);
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
