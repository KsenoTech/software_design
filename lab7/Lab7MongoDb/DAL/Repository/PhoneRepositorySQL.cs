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
    public class PhoneRepositorySQL : IRepository<Phone>
    {
        private PhonesContext db;

        public PhoneRepositorySQL(PhonesContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Phone> GetList()
        {
            return db.Phones.ToList();
        }

        public Phone GetItem(int id)
        {
            return db.Phones.Find(id);
        }

        public void Create(Phone Phone)
        {
            db.Phones.Add(Phone);
        }

        public void Update(Phone Phone)
        {
            db.Entry(Phone).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Phone Phone = db.Phones.Find(id);
            if (Phone != null)
                db.Phones.Remove(Phone);
        }


    }
}
