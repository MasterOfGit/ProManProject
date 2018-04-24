///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_BusinessLayer;
using ProMan_WebAPI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("addgetdeleteobject")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AddGetDeleteObjectController : BaseApiController
    {
        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(string type, int parent, int id)
        {
            dataprovider.DeleteDataProvider.RemoteObject(type, parent, id);
            return Ok();
        }

        // GET: api/AddGetDeleteObject
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AddGetDeleteObject/?type=
        public IEnumerable<KeyValueHelper> Get(string type)
        {
            return dataprovider.GetListDataProvider.GetTypeObjects(type);
        }

        [Route("create")]
        [HttpPost]
        public void Create(string type, int parent, int id)
        {
            dataprovider.CreateDataProvider.AddObject(type, parent, id);
        }

        // PUT: api/AddGetDeleteObject/?type=&oldparent=&newparent=&id=
        public void Put(string type, int oldparent, int newparent, int id)
        {
            dataprovider.UpdateDataProvider.MoveObject(type, oldparent, newparent, id);
        }


    }
}
