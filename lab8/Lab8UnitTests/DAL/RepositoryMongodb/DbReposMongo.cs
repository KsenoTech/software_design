
using DomainModel;
using Interfaces.Repository;
using System.Collections.Generic;

namespace DAL.Repository.Mongodb
{
    public class DbReposMongo : IDbRepos
    {
        private MongoContext db;
        private PhoneRepositoryMongo phoneRepository;
        private OrderRepositoryMongo orderRepository;
        private ManufacturerRepositoryMongo manufacturerRepository;
        private ReportRepositoryMongo reportRepository;

        public DbReposMongo(string cs)
        {
            db = new MongoContext(cs);
            phoneRepository = new PhoneRepositoryMongo(db);
            orderRepository = new OrderRepositoryMongo(db);
            manufacturerRepository = new ManufacturerRepositoryMongo(db);
            reportRepository = new ReportRepositoryMongo(db);
        }

        public IRepository<Phone> Phones
        {
            get { return phoneRepository; }
        }

        public IRepository<Order> Orders
        {
            get { return orderRepository; }
        }

        public IRepository<Manufacturer> Manufacturers
        {
            get { return manufacturerRepository; }
        }

        public IReportsRepository Reports
        {
            get { return reportRepository; }
        }

        public int Save()
        {
            
            return 1;
        }
        private void Seed()
        {
            List<Manufacturer> m =new List<Manufacturer>(){
                new Manufacturer() { Id = 1, Name = "Sony" },
                new Manufacturer() { Id = 2,Name = "Sumsung" },
                new Manufacturer() { Id = 3,Name = "Huawei" },
                new Manufacturer() { Id = 4,Name = "HTC" },
                new Manufacturer() { Id = 5,Name = "Asus" },
                 new Manufacturer() { Id = 6,Name = "Apple" }
            };
            db.ManufacturerCollection.InsertMany(m);

        }
    }
}
