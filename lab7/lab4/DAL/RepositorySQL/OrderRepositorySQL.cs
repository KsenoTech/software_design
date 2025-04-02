using DomainModel;
using Interfaces.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repository
{
    public class OrderRepositorySQL : IRepository<Order>
    {
        private ShopContext db;

        public OrderRepositorySQL(ShopContext dbcontext) // инверсия управления
        {
            db = dbcontext;
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
