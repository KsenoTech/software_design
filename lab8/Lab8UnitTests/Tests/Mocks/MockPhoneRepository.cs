using DomainModel;
using Interfaces.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Mocks
{
    public static class MockPhoneRepository
    {
        public static List<Phone> phones => new List<Phone>(){
                new Phone()
                    {
                        Id = 1,
                        Name = "Nokia 3210",
                        ManufacturerId = 1,
                        Cost = 1000,
                    },
                new Phone()
                    {
                        Id = 2,
                        Name = "Nokia 3211",
                        ManufacturerId = 1,
                        Cost = 2000
                    }
            };

        public static Mock<IRepository<Phone>> GetMock()
        {
            var mock = new Mock<IRepository<Phone>>();
            mock.Setup(m => m.GetList()).Returns(() => phones);
            mock.Setup(m => m.GetItem(It.IsAny<int>()))
                .Returns((int id) => phones.FirstOrDefault(o => o.Id == id));
            mock.Setup(m => m.Create(It.IsAny<Phone>()))
                .Callback(() => { return; });
            mock.Setup(m => m.Update(It.IsAny<Phone>()))
               .Callback(() => { return; });
            mock.Setup(m => m.Delete(It.IsAny<int>()))
               .Callback(() => { return; });

            return mock;
        }
    }
}
