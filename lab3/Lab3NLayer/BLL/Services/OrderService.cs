using BLL.DTO;
using DAL;
using DAL.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class OrderService
    {
        shop db;
        public OrderService()
        {
            db = new shop();
        }

        public bool MakeOrder(Orders orderss)
        {
            List<Motorcycle> orderedmotos = new List<Motorcycle>();
            decimal sum = 0;
            foreach (var pId in orderss.OrderedMotosIDs)
            {
                Motorcycle moto = db.Motorcycles.Find(pId);
                // валидация
                if (moto == null)
                    throw new Exception("Мото не найден");
                sum += moto.Cost;
                orderedmotos.Add(moto);
            }
            // применяем скидку
            sum = new Discount(0.1m).GetDiscountedPrice(sum);

            Order order = new Order
            {
                Date = DateTime.Now,
                Adress = orderss.Adress,
                Total = (int)sum,
                PhoneNumber = orderss.PhoneNumber,
                Customer = orderss.Customer,
                Motorcycles = orderedmotos
            };
            db.Orders.Add(order);
            if (db.SaveChanges() > 0)
                return true;
            return false;

        }


        public List<Orders> GetAllOrders()
        {
            return db.Orders.ToList().Select(i => new Orders(i)).ToList();
        }
    }
}
