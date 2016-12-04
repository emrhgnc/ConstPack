using System.Web.Http;

namespace ConstPackServiceApi
{
    internal class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            configuration.Routes.MapHttpRoute("RPC", "api/{controller}/{Action}/{id}", new { id = RouteParameter.Optional });
        }
    }
}