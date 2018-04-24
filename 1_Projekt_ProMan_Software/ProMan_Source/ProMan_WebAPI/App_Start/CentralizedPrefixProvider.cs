using System.Web.Http.Controllers;
using System.Web.Http.Routing;

namespace ProMan_WebAPI
{
    //Got it from https://www.strathweb.com/2015/10/global-route-prefixes-with-attribute-routing-in-asp-net-web-api/
    public class CentralizedPrefixProvider : DefaultDirectRouteProvider
    {
        private readonly string _centralizedPrefix;

        public CentralizedPrefixProvider(string centralizedPrefix)
        {
            _centralizedPrefix = centralizedPrefix;
        }

        protected override string GetRoutePrefix(HttpControllerDescriptor controllerDescriptor)
        {
            var existingPrefix = base.GetRoutePrefix(controllerDescriptor);
            if (existingPrefix == null) return _centralizedPrefix;

            return string.Format("{0}/{1}", _centralizedPrefix, existingPrefix);
        }
    }
}