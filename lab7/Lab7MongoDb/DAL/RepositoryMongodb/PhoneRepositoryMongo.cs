
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

namespace DAL.Repository
{
    public class PhoneRepositoryMongo : IRepository<Phone>
    {
        private MongoContext db;

        public PhoneRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Phone> GetList()
        {
            // строитель фильтров
            var builder = new FilterDefinitionBuilder<Phone>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            //if (!String.IsNullOrWhiteSpace(name))
            //{
            //    filter = filter & builder.Regex("Name", new BsonRegularExpression(name));
            //}
            //if (cost.HasValue)
            //{
            //    filter = filter & builder.Eq("cost", cost.Value);
            //}
            var test = db.PhoneCollection.Find(filter).ToList();
            return new List<Phone>( db.PhoneCollection.Find(filter).ToList());
        }

        public Phone GetItem(int id)
        {
            return db.PhoneCollection.Find(i=>i.Id==id).FirstOrDefault(); 
        }

        public void Create(Phone phone)
        {
            Phone last = db.PhoneCollection.Find(new FilterDefinitionBuilder<Phone>().Empty).SortByDescending(i => i.Id).Limit(1).FirstOrDefault();
            phone.Id = last!=null?last.Id+1:1;
            db.PhoneCollection.InsertOneAsync(phone);
        }

        public void Update(Phone phone)
        {
            db.PhoneCollection.ReplaceOneAsync(i => i.Id == phone.Id, phone);
        }

        public void Delete(int id)
        {
            db.PhoneCollection.DeleteOneAsync(i=>i.Id==id);
        }


    }
}
