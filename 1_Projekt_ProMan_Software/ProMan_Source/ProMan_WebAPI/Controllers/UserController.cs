using System.Collections.Generic;
using System.Web.Http;
using ProMan_BusinessLayer.DataProvider;
using ProMan_BusinessLayer.Models;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;
using ProMan_WebAPI.Base;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("user")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : BaseApiController
    {


        // GET: api/User
        public IEnumerable<UserDto> Get()
        {
            return dataprovider.GetListDataProvider.GetUserDto();
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {

            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetUserDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]UserDto value)
        {
            dataprovider.CreateDataProvider.SetUserDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]UserDto value)
        {
            dataprovider.UpdateDataProvider.UpdateUserDto(value, id);
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteUserDto(id);
        }
    }
}
