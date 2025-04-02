
using DomainModel;
using Interfaces.Repository;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RepositoryMongoDb //реализации репозиториев 
{
    public class MotoRepositoryMongo : IRepository<Motorcycle>
    {
        private MongoContext db;

        public MotoRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Motorcycle> GetList()
        {
            // строитель фильтров
            var builder = new FilterDefinitionBuilder<Motorcycle>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            //if (!String.IsNullOrWhiteSpace(name))
            //{
            //    filter = filter & builder.Regex("Name", new BsonRegularExpression(name));
            //}
            //if (cost.HasValue)
            //{
            //    filter = filter & builder.Eq("cost", cost.Value);
            //}
            //var test = db.MotoCollection.Find(filter).ToList();
            return new List<Motorcycle>(db.MotoCollection.Find(filter).ToList());
        }

        public Motorcycle GetItem(int id)
        {
            return db.MotoCollection.Find(i => i.Id == id).FirstOrDefault();
        }

        public void Create(Motorcycle moto)
        {
            Motorcycle last = db.MotoCollection.Find(new FilterDefinitionBuilder<Motorcycle>().Empty).SortByDescending(i => i.Id).Limit(1).FirstOrDefault();
            moto.Id = last != null ? last.Id + 1 : 1;
            db.MotoCollection.InsertOneAsync(moto);
        }

        public void Update(Motorcycle moto)
        {
            db.MotoCollection.ReplaceOneAsync(i => i.Id == moto.Id, moto);
        }

        public void Delete(int id)
        {
            db.MotoCollection.DeleteOneAsync(i => i.Id == id);
        }


    }
}
