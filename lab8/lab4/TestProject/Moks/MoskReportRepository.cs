using DomainModel;
using Interfaces.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Moks
{
    public static class MockReportRepository
    {
        static List<DTO.ReportSQLData> data => MockMotoRepository.motos.Select(i => new DTO.ReportSQLData { Brand_name = i.Brand_name, Cost = i.Cost }).ToList();
        public static Mock<IReportsRepository> GetMock()
        {
            var mock = new Mock<IReportsRepository>();
            mock.Setup(m => m.MotosOfType(It.IsAny<int>()))
                .Returns((int id) => data);

            return mock;
        }
    }
}
