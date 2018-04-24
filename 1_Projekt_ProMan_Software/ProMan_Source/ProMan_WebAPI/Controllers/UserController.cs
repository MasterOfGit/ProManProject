﻿///////////////////////////////
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
    [RoutePrefix("login")]
    public class LoginController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetLoginDto()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetLoginDto(id)));
        }

        // GET: api/<controller>
        public IEnumerable<UserDto> Get(bool needlogin)
        {
            return dataprovider.GetListDataProvider.GetUserDto(needlogin);
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


