using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
