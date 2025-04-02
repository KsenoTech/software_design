using DomainModel;
using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ManufacturerRepositorySQL : IRepository<Manufacturer>
    {
        private PhonesContext db;

        public ManufacturerRepositorySQL(PhonesContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Manufacturer> GetList()
        {
            return db.Manufacturers.ToList();
        }

        public Manufacturer GetItem(int id)
        {
            return db.Manufacturers.Find(id);
        }

        public void Create(Manufacturer item)
        {
            db.Manufacturers.Add(item);
        }

        public void Update(Manufacturer item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Manufacturer item = db.Manufacturers.Find(id);
            if (item != null)
                db.Manufacturers.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges()>0;
        }

    }
}
