
using DomainModel;
using Interfaces.Repository;
using System.Collections.Generic;

namespace DAL.RepositoryMongoDb
{
    public class DbReposMongo : IDbRepos
    {
        private MongoContext db;
        private MotoRepositoryMongo motoRepository;
        private OrderRepositoryMongo orderRepository;
        private TypeRepositoryMongo typeRepository;
        private ReportRepositoryMongo reportRepository;

        public DbReposMongo(string cs) 
        {
            db = new MongoContext(cs);
            motoRepository = new MotoRepositoryMongo(db);
            orderRepository = new OrderRepositoryMongo(db);
            typeRepository = new TypeRepositoryMongo(db);
            reportRepository = new ReportRepositoryMongo(db);
            //Seed();
        }

        public IRepository<Motorcycle> Motos
        {
            get { return motoRepository; }
        }

        public IRepository<Order> Orders
        {
            get { return orderRepository; }
        }

        public IRepository<Type> Types
        {
            get { return typeRepository; }
        }

        public IReportsRepository Reports
        {
            get { return reportRepository; }
        }

        //int IDbRepos.Save()
        //{
        //    return 1;
        //}
        public int Save()
        {
            return 1;
        }

        private void Seed()
        {
            List<Type> m = new List<Type>(){
                new Type() { Id=1, Name = "Спортивный" },
                new Type() { Id=2, Name = "Горный" },
                new Type() { Id=3, Name = "Трассовый" },
            };
            db.TypeCollection.InsertMany(m);

        }
    }
}
