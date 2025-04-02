using BLL.Services;
using Interfaces.Repository;
using Moq;
using TestProject.Moks;

namespace TestProject.Service
{
    public class ReportServiceTest
    {
        Mock<IDbRepos> uowMock;
        ReportService service;

        [SetUp]
        public void Setup()
        {
            uowMock = MockUowRepository.GetMock();
            service = new ReportService(uowMock.Object);
        }

        [Test]
        public void ReportPhonesOfMunufacturer_Success()
        {
            var result = service.ReportMotosOfType(1);
            Assert.IsNotNull(result);
            Assert.That(MockMotoRepository.motos.Count, Is.EqualTo(result.Count));

            Assert.Pass();
        }


    }
}
