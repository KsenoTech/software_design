using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DomainModel;
using Type = DomainModel.Type;

namespace DAL.Repository
{
    public class TypeRepositorySQL : IRepository<Type>
    {
        private ShopContext db;

        public TypeRepositorySQL(ShopContext dbcontext)
        {
            db = dbcontext;
        }

        public List<Type> GetList()
        {
            return db.Types.ToList();
        }

        public Type GetItem(int id)
        {
            return db.Types.Find(id);
        }

        public void Create(Type item)
        {
            db.Types.Add(item);
        }

        public void Update(Type item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Type item = db.Types.Find(id);
            if (item != null)
                db.Types.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
