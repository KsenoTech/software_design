using Ninject;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DIApp.Util;
using Ninject.Web.Mvc;

namespace mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // внедрение зависимостей
            var kernel = new StandardKernel(new NinjectRegistrations());
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}