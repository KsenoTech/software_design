
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
using Type = DomainModel.Type;

namespace DAL.RepositoryMongoDb //реализации репозиториев 
{
    public class TypeRepositoryMongo : IRepository<Type>
    {
        private MongoContext db;

        public TypeRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Type> GetList()
        {
            var builder = new FilterDefinitionBuilder<Type>();
            var filter = builder.Empty;
            return new List<Type>(db.TypeCollection.Find(filter).ToListAsync().Result);
        }

        Type IRepository<Type>.GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Type item)
        {
            throw new NotImplementedException();
        }

        public void Update(Type item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
