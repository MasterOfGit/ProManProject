using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_Database;
using ProMan_WebAPI.Models;
using ProMan_WebAPI.DataProvider;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("user")]
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

            return Ok(dataprovider.GetUserDto(id));
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
