using ResistorWebApp.DI;
using StructureContainer;
using StructureMap;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ResistorWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IContainer DIContainer;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DIContainer = IocContainer.Container;
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(DIContainer));
        }
    }
}
