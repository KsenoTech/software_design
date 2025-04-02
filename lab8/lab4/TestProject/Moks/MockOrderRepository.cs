using DomainModel;
using Interfaces.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Moks
{
    public static class MockOrderRepository
    {
        public static List<Order> orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                Customer = "John1",
                Date = DateTime.Now,
                Adress = "city street apt",
                Motorcycles = new List<Motorcycle>()
                {
                    MockMotoRepository.motos[0]
                }
            },
            new Order()
            {
                Id = 0,
                Customer = "John2",
                Date = DateTime.Now,
                Adress = "city street apt",
                Motorcycles = MockMotoRepository.motos
            }
        };

        public static Mock<IRepository<Order>> GetMock()
        {
            var mock = new Mock<IRepository<Order>>();

            mock.Setup(m => m.GetList()).Returns(() => orders);
            mock.Setup(m => m.GetItem(It.IsAny<int>()))
                .Returns((int id) => orders.FirstOrDefault(o => o.Id == id) ?? orders[0]);
            mock.Setup(m => m.Create(It.IsAny<Order>()))
                .Callback(() => { return; });
            mock.Setup(m => m.Update(It.IsAny<Order>()))
               .Callback(() => { return; });
            mock.Setup(m => m.Delete(It.IsAny<int>()))
               .Callback(() => { return; });
            return mock;
        }
    }
}
