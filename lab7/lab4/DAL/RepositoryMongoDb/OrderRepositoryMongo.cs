using DomainModel;
using Interfaces.Repository;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;

namespace DAL.RepositoryMongoDb //реализации репозиториев 
{
    public class OrderRepositoryMongo : IRepository<Order>
    {
        private MongoContext db;

        public OrderRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Order> GetList()
        {
            var builder = new FilterDefinitionBuilder<Order>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            return new List<Order>(db.OrderCollection.Find(filter).ToListAsync().Result);
        }

        public Order GetItem(int id)
        {
            return db.OrderCollection.Find(i => i.Id == id).FirstOrDefault();
        }

        public void Create(Order order)
        {
            Order last = db.OrderCollection.Find(new FilterDefinitionBuilder<Order>().Empty).SortByDescending(i => i.Id).Limit(1).FirstOrDefault();
            order.Id = last != null ? last.Id + 1 : 1;
            db.OrderCollection.InsertOneAsync(order).Wait();
        }

        public void Update(Order order)
        {
            db.OrderCollection.ReplaceOneAsync(new BsonDocument("Id", order.Id), order);

        }

        public void Delete(int id)
        {
            db.OrderCollection.DeleteOneAsync(new BsonDocument("Id", new ObjectId(id.ToString())));
            //Console.Read();
        }

    }
}
