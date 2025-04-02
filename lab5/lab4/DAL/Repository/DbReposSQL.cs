using DomainModel;
using Interfaces.Repository;

namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private ShopContext db;
        private MotoRepositorySQL motoRepository;
        private OrderRepositorySQL orderRepository;
        private TypeRepositorySQL typeRepository;
        private ReportRepositorySQL reportRepository;

        public DbReposSQL()
        {
            db = new ShopContext();
        }

        public IRepository<Motorcycle> Motos
        {
            get
            {
                if (motoRepository == null)
                    motoRepository = new MotoRepositorySQL(db);
                return motoRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepositorySQL(db);
                return orderRepository;
            }
        }

        public IRepository<Type> Types
        {
            get
            {
                if (typeRepository == null)
                    typeRepository = new TypeRepositorySQL(db);
                return typeRepository;
            }
        }

        public IReportsRepository Reports
        {
            get
            {
                if (reportRepository == null)
                    reportRepository = new ReportRepositorySQL(db);
                return reportRepository;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
