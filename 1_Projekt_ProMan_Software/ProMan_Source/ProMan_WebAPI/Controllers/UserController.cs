using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_Database;
using ProMan_WebAPI.Models;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("user")]
    public class UserController : ApiController
    {
        ProManContext dbcontext = new ProManContext();

        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            var item = dbcontext.User.FirstOrDefault(x => x.UserID == id);
            UserDto user = new UserDto()
            {
                Abteilung = item.Abteilung.Fachbereich,
                FirstName = item.FirstName,
                FamilyName = item.FamilyName,
                eMail = item.eMail,
                Phone = item.Phone,
                Mobile = item.Mobile,
                Title = item.Title,
                Werk = item.Abteilung.Werk.Name
            };
            return Ok(user);
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
