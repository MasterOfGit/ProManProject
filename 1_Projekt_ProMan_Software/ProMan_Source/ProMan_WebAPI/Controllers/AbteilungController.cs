﻿using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AbteilungController : BaseApiController
    {
        // GET: api/Abteilung
        public IEnumerable<AbteilungDto> Get()
        {
            return dataprovider.GetListDataProvider.GetAbteilungDto();
        }

        // GET: api/Abteilung/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetAbteilungDto(id)));
        }

        // POST: api/Abteilung
        public void Post([FromBody]AbteilungDto value)
        {
            dataprovider.CreateDataProvider.SetAbteilungDto(value);
        }

        // PUT: api/Abteilung/5
        public void Put(int id, [FromBody]AbteilungDto value)
        {
            dataprovider.UpdateDataProvider.UpdateAbteilungDto(value,id);
        }

        // DELETE: api/Abteilung/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteAbteilungDto(id);
        }
    }
}
