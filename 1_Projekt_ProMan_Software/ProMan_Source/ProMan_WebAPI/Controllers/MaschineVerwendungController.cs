﻿using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MaschineVerwendungController : BaseApiController
    {
        // GET: api/Audit
        public IEnumerable<MaschineVerwendungDto> Get()
        {
            return dataprovider.GetListDataProvider.GetMaschineVerwendungDto();
        }

        // GET: api/Audit/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetMaschineVerwendungDto(id)));
        }

        // POST: api/Audit
        public void Post([FromBody]MaschineVerwendungDto value)
        {
            dataprovider.CreateDataProvider.SetMaschineVerwendungDto(value);
        }

        // PUT: api/Audit/5
        public void Put(int id, [FromBody]MaschineVerwendungDto value)
        {
            dataprovider.UpdateDataProvider.UpdateMaschineVerwendungDto(value, id);
        }

        // PUT: api/Audit/5
        public void Put(int id, [FromBody]List<MaschineVerwendungDto> value)
        {
            foreach (var item in value)
            {
                Put(id, value);
            }


        }

        // DELETE: api/Audit/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteMaschineVerwendungDto(id);
        }
    }

}
