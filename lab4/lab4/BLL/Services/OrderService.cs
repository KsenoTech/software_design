using DomainModel;
using DTO;
using Interfaces.Repository;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        private IDbRepos db;
        public OrderService(IDbRepos repos)
        {
            db = repos;
        }

        public OrderDto MakeOrder(OrderDto orderDto)
        {
            List<Motorcycle> orderedmotos = new List<Motorcycle>();
            decimal sum = 0;
            foreach (var pId in orderDto.OrderedMotosIDs)
            {
                Motorcycle phone = db.Motos.GetItem(pId);
                // валидация
                if (phone == null)
                    throw new ArgumentNullException("Мотик не найден. Сорян");
                sum += phone.Cost;
                orderedmotos.Add(phone);
            }
            // применяем скидку
            sum = new Discount(0.1m).GetDiscountedPrice(sum);
            Order order;
            if (orderDto.ID > 0)
            {
                order = db.Orders.GetItem(orderDto.ID);
                order.Date = DateTime.Now;
                order.Adress = orderDto.Adress;
                order.Total = (int?)sum;
                order.PhoneNumber = orderDto.PhoneNumber;
                order.Customer = orderDto.Customer;
                order.Motorcycles = orderedmotos;
                db.Orders.Update(order);
            }
            else
            {
                order = new Order
                {
                    Date = DateTime.Now,
                    Adress = orderDto.Adress,
                    Total = (int?)sum,
                    PhoneNumber = orderDto.PhoneNumber,
                    Customer = orderDto.Customer,
                    Motorcycles = orderedmotos
                };
                db.Orders.Create(order);
            }
            if (db.Save() > 0)
                return GetOrder(order.ID);
            return null;

        }


        public List<OrderDto> GetAllOrders()
        {
            return db.Orders.GetList().Select(i => new OrderDto(i)).ToList();
        }
        public OrderDto GetOrder(int Id)
        {
            return new OrderDto(db.Orders.GetItem(Id));
        }
        public void DeleteOrder(int id)
        {
            if (db.Orders.GetItem(id) != null)
            {
                db.Orders.Delete(id);
                db.Save();
            }
        }

    }
}
