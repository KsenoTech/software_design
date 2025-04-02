using DomainModel;
using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repository
{
    public class MotoRepositorySQL : IRepository<Motorcycle>
    {
        private ShopContext db;

        public MotoRepositorySQL(ShopContext dbcontext)
        {
            db = dbcontext;
        }

        public List<Motorcycle> GetList()
        {
            return db.Motorcycles.ToList();
        }

        public Motorcycle GetItem(int id)
        {
            return db.Motorcycles.Find(id);
        }

        public void Create(Motorcycle Moto)
        {
            db.Motorcycles.Add(Moto);
        }

        public void Update(Motorcycle Moto)
        {
            db.Entry(Moto).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Motorcycle Moto = db.Motorcycles.Find(id);
            if (Moto != null)
                db.Motorcycles.Remove(Moto);
        }

    }
}
