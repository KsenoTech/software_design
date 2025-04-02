using DomainModel;
using Interfaces.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Type = DomainModel.Type;

namespace TestProject.Moks
{
    public static class MockTypeRepository
    {
        public static Mock<IRepository<Type>> GetMock()
        {
            var mock = new Mock<IRepository<Type>>();
            var list = new List<Type>()
            {
                new Type()
                {
                    Id = 1,
                    Name = "Test Typa",
                }
            };
            mock.Setup(m => m.GetList()).Returns(() => list);
            mock.Setup(m => m.GetItem(It.IsAny<int>()))
                .Returns((int id) => list.First());
            mock.Setup(m => m.Create(It.IsAny<Type>()))
                .Callback(() => { return; });
            mock.Setup(m => m.Update(It.IsAny<Type>()))
               .Callback(() => { return; });
            mock.Setup(m => m.Delete(It.IsAny<int>()))
               .Callback(() => { return; });
            return mock;
        }
    }
}
