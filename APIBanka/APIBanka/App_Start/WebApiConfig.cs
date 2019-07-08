using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIBanka
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Buraya gelmeden önce projemize Manage Nuget'tan Microsoft Web Api Cors'u indirdik..Bu cok önemlidir. Cünkü cross origins resource server (cors) bu Api projemizin diger baglanmak isteyen projelere cevap verebilmesini saglar...Tabii ki onu indirdikten sonra asagıya su kodları da eklememiz gerekir.

            EnableCorsAttribute cors = new EnableCorsAttribute("*","*","*");//buradaki yıldızlar projenin her domaine cevap verebilecegini bildirir.

            config.EnableCors(cors);


            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
