///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("user")]
    public class UserController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetUserDto()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetUserDto(id)));
        }

        // GET: api/<controller>
        public IEnumerable<UserDto> Get(bool needUser)
        {
            return dataprovider.GetListDataProvider.GetUserDto(needUser);
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            UserDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<UserDto>(value);
            dataprovider.CreateDataProvider.SetUserDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            UserDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<UserDto>(value);
            dataprovider.UpdateDataProvider.UpdateUserDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteUserDto(id);
            return Ok();
        }
    }
}


