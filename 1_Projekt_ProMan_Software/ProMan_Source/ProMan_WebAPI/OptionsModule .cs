///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using System.Web;

namespace ProMan_WebAPI
{
    public class OptionsModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += (sender, args) =>
            {
                var app = (HttpApplication)sender;

                if (app.Request.HttpMethod == "OPTIONS")
                {
                    app.Response.StatusCode = 200;
                    app.Response.AddHeader("Access-Control-Allow-Headers", "Content-type");
                    app.Response.AddHeader("Access-Control-Allow-Origin", "http://zoomnation.selfhost.eu");
                    app.Response.AddHeader("Access-Control-Allow-Credentials", "true");
                    app.Response.AddHeader("Access-Control-Allow-Methods", "POST,GET,PUT,DELETE,OPTIONS");
                    app.Response.AddHeader("Content-Type", "application/json");
                    app.Response.End();
                }
                if (app.Request.HttpMethod == "DELETE")
                {
                    app.Response.StatusCode = 200;
                    app.Response.AddHeader("Access-Control-Allow-Headers", "Content-type");
                    app.Response.AddHeader("Access-Control-Allow-Origin", "http://zoomnation.selfhost.eu");
                    app.Response.AddHeader("Access-Control-Allow-Credentials", "true");
                    app.Response.AddHeader("Access-Control-Allow-Methods", "POST,GET,PUT,DELETE,OPTIONS");
                    app.Response.AddHeader("Content-Type", "application/json");
                    app.Response.End();
                }
                if (app.Request.HttpMethod == "PUT")
                {
                    app.Response.StatusCode = 200;
                    app.Response.AddHeader("Access-Control-Allow-Headers", "Content-type");
                    app.Response.AddHeader("Access-Control-Allow-Origin", "http://zoomnation.selfhost.eu");
                    app.Response.AddHeader("Access-Control-Allow-Credentials", "true");
                    app.Response.AddHeader("Access-Control-Allow-Methods", "POST,GET,PUT,DELETE,OPTIONS");
                    app.Response.AddHeader("Content-Type", "application/json");
                    app.Response.End();
                }
                if (app.Request.HttpMethod == "POST")
                {
                    app.Response.StatusCode = 200;
                    app.Response.AddHeader("Access-Control-Allow-Headers", "Content-type");
                    app.Response.AddHeader("Access-Control-Allow-Origin", "http://zoomnation.selfhost.eu");
                    app.Response.AddHeader("Access-Control-Allow-Credentials", "true");
                    app.Response.AddHeader("Access-Control-Allow-Methods", "POST,GET,PUT,DELETE,OPTIONS");
                    app.Response.AddHeader("Content-Type", "application/json");
                    app.Response.End();
                }
            };
        }

        public void Dispose()
        {
        }
    }
}