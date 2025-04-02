using BLL.Services;
using DAL.Repository;
using Interfaces.Repository;
using Interfaces.Services;
using Ninject.Modules;

namespace DIApp.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
            Bind<IReportService>().To<ReportService>();
            Bind<IMotoService>().To<MotoService>();

            Bind<IDbRepos>().To<DbReposSQL>();
        }
    }
}
