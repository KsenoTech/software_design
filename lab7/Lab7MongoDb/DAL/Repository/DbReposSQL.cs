using DomainModel;
using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private PhonesContext db;
        private PhoneRepositorySQL phoneRepository;
        private OrderRepositorySQL orderRepository;
        private ManufacturerRepositorySQL manufacturerRepository;
        private ReportRepositorySQL reportRepository;

        public DbReposSQL()
        {
            db = new PhonesContext();
        }

        public IRepository<Phone> Phones
        {
            get
            {
                if (phoneRepository == null)
                    phoneRepository = new PhoneRepositorySQL(db);
                return phoneRepository;
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

        public IRepository<Manufacturer> Manufacturers
        {
            get
            {
                if (manufacturerRepository == null)
                    manufacturerRepository = new ManufacturerRepositorySQL(db);
                return manufacturerRepository;
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
