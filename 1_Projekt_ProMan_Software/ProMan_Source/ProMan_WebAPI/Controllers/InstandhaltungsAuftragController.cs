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
    [RoutePrefix("InstandhaltungsAuftrag")]
    public class InstandhaltungsAuftragController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetInstandhaltungsAuftragDto()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetInstandhaltungsAuftragDto(id)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            InstandhaltungsAuftragDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<InstandhaltungsAuftragDto>(value);
            dataprovider.CreateDataProvider.SetInstandhaltungsAuftragDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            InstandhaltungsAuftragDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<InstandhaltungsAuftragDto>(value);
            dataprovider.UpdateDataProvider.UpdateInstandhaltungsAuftragDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteInstandhaltungsAuftragDto(id);
            return Ok();
        }
    }
}
