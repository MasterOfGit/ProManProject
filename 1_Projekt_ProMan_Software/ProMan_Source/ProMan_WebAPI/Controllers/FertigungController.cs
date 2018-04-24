///////////////////////////////
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
    [RoutePrefix("fertigung")]
    public class FertigungController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetFertigungDto()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetFertigungDto(id)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            FertigungDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<FertigungDto>(value);
            dataprovider.CreateDataProvider.SetFertigungDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            FertigungDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<FertigungDto>(value);
            dataprovider.UpdateDataProvider.UpdateFertigungDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteFertigungDto(id);
            return Ok();
        }
    }
}
