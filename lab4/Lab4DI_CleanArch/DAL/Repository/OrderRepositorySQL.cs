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
    public class OrderRepositorySQL : IRepository<Order>
    {
        private PhonesContext db;

        public OrderRepositorySQL(PhonesContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Order> GetList()
        {
            return db.Orders.ToList();
        }

        public Order GetItem(int id)
        {
            return db.Orders.Find(id);
        }

        public void Create(Order Order)
        {
            db.Orders.Add(Order);
        }

        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Order Order = db.Orders.Find(id);
            if (Order != null)
                db.Orders.Remove(Order);
        }


    }
}
