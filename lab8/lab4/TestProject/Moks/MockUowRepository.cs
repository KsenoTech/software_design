using DAL.Repository;
using DomainModel;
using Interfaces.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Moks;

namespace TestProject.Moks
{
    public static class MockUowRepository
    {
        public static Mock<IDbRepos> GetMock()
        {
            var mock = new Mock<IDbRepos>();
            var orderRepoMock = MockOrderRepository.GetMock();
            var motoRepoMock = MockMotoRepository.GetMock();
            var typeRepoMock = MockTypeRepository.GetMock();
            var reportRepoMock = MockReportRepository.GetMock();

            mock.Setup(m => m.Orders).Returns(() => orderRepoMock.Object);
            mock.Setup(m => m.Motos).Returns(() => motoRepoMock.Object);
            mock.Setup(m => m.Types).Returns(() => typeRepoMock.Object);
            mock.Setup(m => m.Reports).Returns(() => reportRepoMock.Object);
            // не тестируем запись в бд
            mock.Setup(m => m.Save()).Returns(() => { return 1; });
            return mock;
        }
    }
}
