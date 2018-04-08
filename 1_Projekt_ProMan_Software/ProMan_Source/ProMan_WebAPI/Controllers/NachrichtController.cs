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
        // GET: api/Nachricht
        public IEnumerable<NachrichtDto> Get()
        {
            return dataprovider.GetListDataProvider.GetNarichtenFromUser();
        }

        // GET: api/Nachricht/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetNachrichtDto(id)));
        }

        // GET: api/Nachricht/5
        public IHttpActionResult Get(int UserID,DateTime? fromDate)
        {
            if (fromDate == null)
                fromDate = DateTime.Now.AddDays(-7);
                
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetNachrichtDto(UserID)));
        }

        // POST: api/Nachricht
        public void Post([FromBody]NachrichtDto value)
        {
            dataprovider.CreateDataProvider.SetNachrichtDto(value);
        }

        // PUT: api/Nachricht/5
        public void Put(int id, [FromBody]NachrichtDto value)
        {
            dataprovider.UpdateDataProvider.UpdateNachrichtDto(value,id);
        }

        // DELETE: api/Nachricht/5
        public void Delete(int id)
        {
        }
    }
}
