﻿///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("bauteilVerwendung")]
    public class BauteilVerwendungController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetBauteilVerwendungDto()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetBauteilVerwendungDto(id)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            BauteilVerwendungDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<BauteilVerwendungDto>(value);
            dataprovider.CreateDataProvider.SetBauteilVerwendungDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            BauteilVerwendungDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<BauteilVerwendungDto>(value);
            dataprovider.UpdateDataProvider.UpdateBauteilVerwendungDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteBauteilVerwendungDto(id);
            return Ok();
        }
    }
}
