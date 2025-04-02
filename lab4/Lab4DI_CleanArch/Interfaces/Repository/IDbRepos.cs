using DomainModel;


namespace Interfaces.Repository
{
    public interface IDbRepos
    {
        IRepository<Phone> Phones { get; }
        IRepository<Order> Orders { get; }
        IRepository<Manufacturer> Manufacturers { get; }
        IReportsRepository Reports { get; }
        int Save();
    }
}
