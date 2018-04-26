///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
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
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.ExecuteLoginDto(username,password)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            LoginDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginDto>(value);
            dataprovider.CreateDataProvider.SetLoginDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            LoginDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginDto>(value);
            dataprovider.UpdateDataProvider.UpdateLoginDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteLoginDto(id);
            return Ok();
        }
    }
}