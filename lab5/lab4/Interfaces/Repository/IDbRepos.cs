using DomainModel;
using System.Security.Policy;


namespace Interfaces.Repository
{
    public interface IDbRepos //паттерн unit of work? так же em+ntyty fr реалиузет unit of work
    {
        IRepository<Motorcycle> Motos { get; }
        IRepository<Order> Orders { get; }
        IRepository<Type> Types { get; }
        IReportsRepository Reports { get; }
        int Save();
    }
}
