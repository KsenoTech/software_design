//using DIApp.Util;
//using Ninject;
//using Ninject.Web.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Optimization;
//using System.Web.Routing;

//namespace lab5Mvc
//{
//    public class MvcApplication : System.Web.HttpApplication
//    {
//        protected void Application_Start()
//        {
//            AreaRegistration.RegisterAllAreas();
//            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
//            RouteConfig.RegisterRoutes(RouteTable.Routes);
//            BundleConfig.RegisterBundles(BundleTable.Bundles);
//            // внедрение зависимостей
//            var kernel = new StandardKernel(new NinjectRegistrations());
//            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

//        }
//    }
//}
