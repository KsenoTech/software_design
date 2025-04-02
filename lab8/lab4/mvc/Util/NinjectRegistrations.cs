using BLL.Services;
using DAL.RepositoryMongoDb;

using Interfaces.Repository;
using Interfaces.Services;
using Ninject.Modules;
using System.Configuration;

namespace DIApp.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
            Bind<IReportService>().To<ReportService>();
            Bind<IMotoService>().To<MotoService>();

            //Bind<IDbRepos>().To<DbReposSQL>(); - для SQL

            Bind<IDbRepos>().To<DbReposMongo>().InSingletonScope().WithConstructorArgument(ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString);

        }
    }
}
