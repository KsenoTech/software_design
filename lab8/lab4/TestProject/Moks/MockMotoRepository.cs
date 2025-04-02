using DomainModel;
using Interfaces.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Moks
{
    public static class MockMotoRepository
    {//список объектов, замещаюзий реальные данные
        public static List<Motorcycle> motos => new List<Motorcycle>(){
                new Motorcycle()
                    {
                        Id = 1,
                        Brand_name = "Nokia 3210",
                        id_Type_FK = 1,
                        Cost = 1000,
                    },
                new Motorcycle()
                    {
                        Id = 2,
                        Brand_name = "Nokia 3211",
                        id_Type_FK = 3,
                    Cost = 2000
                }
            };
        //настройка методов мока репозитория
        public static Mock<IRepository<Motorcycle>> GetMock()
        {
            var mock = new Mock<IRepository<Motorcycle>>();
            mock.Setup(m => m.GetList()).Returns(() => motos);
            mock.Setup(m => m.GetItem(It.IsAny<int>()))
                .Returns((int id) => motos.FirstOrDefault(o => o.Id == id));
            mock.Setup(m => m.Create(It.IsAny<Motorcycle>()))
                .Callback(() => { return; });
            mock.Setup(m => m.Update(It.IsAny<Motorcycle>()))
               .Callback(() => { return; });
            mock.Setup(m => m.Delete(It.IsAny<int>()))
               .Callback(() => { return; });

            return mock;
        }
    }
}
