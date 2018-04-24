///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("nachricht")]
    public class NachrichtController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetNarichtenFromUser()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetNachrichtDto(id)));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int UserID, DateTime? fromDate)
        {
            if (fromDate == null)
                fromDate = DateTime.Now.AddDays(-7);

            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetNachrichtDto(UserID)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            NachrichtDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<NachrichtDto>(value);
            dataprovider.CreateDataProvider.SetNachrichtDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            NachrichtDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<NachrichtDto>(value);
            dataprovider.UpdateDataProvider.UpdateNachrichtDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteNachrichtDto(id);
            return Ok();
        }
    }
}