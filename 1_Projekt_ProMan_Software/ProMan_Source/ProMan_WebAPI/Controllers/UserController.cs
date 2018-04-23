///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
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


        // GET: api/<controller>
        public IEnumerable<UserDto> Get()
        {
            return dataprovider.GetListDataProvider.GetUserDto();
        }

        // GET: api/<controller>
        public IEnumerable<UserDto> Get(bool needlogin)
        {
            return dataprovider.GetListDataProvider.GetUserDto(needlogin);
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {

            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetUserDto(id)));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]UserDto value)
        {
            dataprovider.CreateDataProvider.SetUserDto(value);
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]UserDto value)
        {
            dataprovider.UpdateDataProvider.UpdateUserDto(value, id);
            return Ok();
        }

        // DELETE: api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteUserDto(id);
            return Ok();
        }
    }
}
