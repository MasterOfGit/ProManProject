///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("nachricht")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NachrichtController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<NachrichtDto> Get()
        {
            return dataprovider.GetListDataProvider.GetNarichtenFromUser();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetNachrichtDto(id)));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int UserID,DateTime? fromDate)
        {
            if (fromDate == null)
                fromDate = DateTime.Now.AddDays(-7);
                
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetNachrichtDto(UserID)));
        }

        // POST: api/<controller>
        public IHttpActionResult Post([FromBody]NachrichtDto value)
        {
            dataprovider.CreateDataProvider.SetNachrichtDto(value);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]NachrichtDto value)
        {
            dataprovider.UpdateDataProvider.UpdateNachrichtDto(value,id);
            return Ok();
        }

        // DELETE: api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteNachrichtDto(id);
            return Ok();
        }
    }
}
