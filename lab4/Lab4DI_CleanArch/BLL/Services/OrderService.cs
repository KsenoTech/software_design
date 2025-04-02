using DomainModel;
using DTO;
using Interfaces.Repository;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class OrderService: IOrderService
    {
        private IDbRepos db;
        public OrderService(IDbRepos repos)
        {
            db = repos;
        }

        public OrderDto MakeOrder(OrderDto orderDto)
        {
            List<Phone> orderedphones = new List<Phone>();
            decimal sum = 0;
            foreach (var pId in orderDto.OrderedPhonesIds)
            {
                Phone phone = db.Phones.GetItem(pId);
                // валидация
                if (phone == null)
                    throw new ArgumentNullException("Телефон не найден");
                sum += phone.Cost;
                orderedphones.Add(phone);
            }
            // применяем скидку
            sum = new Discount(0.1m).GetDiscountedPrice(sum);
            Order order;
            if (orderDto.Id > 0)
            {
                order = db.Orders.GetItem(orderDto.Id);
                order.Date = DateTime.Now;
                order.Address = orderDto.Address;
                order.Total = sum;
                order.PhoneNumber = orderDto.PhoneNumber;
                order.Customer = orderDto.Customer;
                order.Phones = orderedphones;
                db.Orders.Update(order);
            }
            else
            {
                order = new Order
                {
                    Date = DateTime.Now,
                    Address = orderDto.Address,
                    Total = sum,
                    PhoneNumber = orderDto.PhoneNumber,
                    Customer = orderDto.Customer,
                    Phones = orderedphones
                };
                db.Orders.Create(order);
            }
            if (db.Save() > 0)
                return GetOrder(order.Id);
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
