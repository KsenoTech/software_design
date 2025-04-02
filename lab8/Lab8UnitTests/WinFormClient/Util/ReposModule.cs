using DAL.Repository;
using DAL.Repository.Mongodb;
using Interfaces.Repository;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Bind<IDbRepos>().To<DbReposSQL>();
            Bind<IDbRepos>().To<DbReposMongo>().InSingletonScope().WithConstructorArgument(connectionString);
        }
    }
}
