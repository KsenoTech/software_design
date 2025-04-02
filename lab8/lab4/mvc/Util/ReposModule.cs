using DAL.RepositoryMongoDb;
using Interfaces.Repository;
using Ninject.Modules;

namespace DIApp.Util
{
    public class ReposModule : NinjectModule
    {
        private string connectionString;
        public ReposModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IDbRepos>().To<DbReposMongo>().InSingletonScope().WithConstructorArgument(connectionString);
        }
    }
}
