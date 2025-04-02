using DomainModel;
using Interfaces.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Mocks
{
    public static class MockManufRepository
    {
        public static Mock<IRepository<Manufacturer>> GetMock()
        {
            var mock = new Mock<IRepository<Manufacturer>>();
            var list = new List<Manufacturer>()
            {
                new Manufacturer()
                {
                    Id = 1,
                    Name = "Test Manufa",
                }
            };
            mock.Setup(m => m.GetList()).Returns(() => list);
            mock.Setup(m => m.GetItem(It.IsAny<int>()))
                .Returns((int id) => list.First());
            mock.Setup(m => m.Create(It.IsAny<Manufacturer>()))
                .Callback(() => { return; });
            mock.Setup(m => m.Update(It.IsAny<Manufacturer>()))
               .Callback(() => { return; });
            mock.Setup(m => m.Delete(It.IsAny<int>()))
               .Callback(() => { return; });
            return mock;
        }
    }
}
