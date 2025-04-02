
using BLL.Services;
using DAL.Repository;
using DAL.Repository.Mongodb;
using Interfaces.Repository;
using Interfaces.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIApp.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            //Bind<IDbRepos>().To<DbReposSQL>();
            Bind<IDbRepos>().To<DbReposMongo>().InSingletonScope().WithConstructorArgument(ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString);
            Bind<IOrderService>().To<OrderService>();
            Bind<IReportService>().To<ReportService>();
            Bind<IPhoneService>().To<PhoneService>();
        }
    }
}
