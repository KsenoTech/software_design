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
    public static class MockReportRepository
    {
        static List<DTO.ReportData> data => MockPhoneRepository.phones.Select(i => new DTO.ReportData { PhoneName = i.Name, Cost = i.Cost }).ToList();
        public static Mock<IReportsRepository> GetMock()
        {
            var mock = new Mock<IReportsRepository>();
            mock.Setup(m => m.PhonesOfMunufacturer(It.IsAny<int>()))
                .Returns((int id) => data);

            return mock;
        }
    }
}
