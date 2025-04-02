
using DomainModel;
using Interfaces.Repository;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ManufacturerRepositoryMongo : IRepository<Manufacturer>
    {
        private MongoContext db;

        public ManufacturerRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Manufacturer> GetList()
        {
            var builder = new FilterDefinitionBuilder<Manufacturer>();
            var filter = builder.Empty; 
            return new List<Manufacturer>(db.ManufacturerCollection.Find(filter).ToListAsync().Result);
        }

        Manufacturer IRepository<Manufacturer>.GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Manufacturer item)
        {
            throw new NotImplementedException();
        }

        public void Update(Manufacturer item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
