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
    [RoutePrefix("maschineVerwendung")]
    public class MaschineVerwendungController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetMaschineVerwendungDto()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetMaschineVerwendungDto(id)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            MaschineVerwendungDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<MaschineVerwendungDto>(value);
            dataprovider.CreateDataProvider.SetMaschineVerwendungDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            MaschineVerwendungDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<MaschineVerwendungDto>(value);
            dataprovider.UpdateDataProvider.UpdateMaschineVerwendungDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteMaschineVerwendungDto(id);
            return Ok();
        }
    }
}
