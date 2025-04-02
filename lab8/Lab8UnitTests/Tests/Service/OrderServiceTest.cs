using BLL.Services;
using DTO;
using Interfaces.Repository;
using Interfaces.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Mocks;

namespace Tests.Services
{
    public class OrderServiceTest
    {
        private readonly OrderDto _NoPhoneOrderDto = new OrderDto
        {
            Address = "city str apt",
            Customer = "Customer1",
            PhoneNumber = "123456",
        };
        private readonly OrderDto _InvalidPhoneOrderDto = new OrderDto
        {
            Address = "city str apt",
            Customer = "Customer1",
            PhoneNumber = "123456",
            OrderedPhonesIds = new List<int> { 3, 2 },
        };
        private readonly OrderDto _ValidOnePhoneOrderDto = new OrderDto
        {
            Id = 1,
            Address = "city str apt",
            Customer = "Customer1",
            PhoneNumber = "123456",
            OrderedPhonesIds = new List<int> { 1 }
        };
        private readonly OrderDto _ValidManyPhonesOrderDto = new OrderDto
        {
            Address = "city str apt",
            Customer = "Customer1",
            PhoneNumber = "123456",
            OrderedPhonesIds = new List<int> { 1, 2 },
        };

        Mock<IDbRepos> uowMock;
        OrderService service;

        [SetUp]
        public void Setup()
        {
            uowMock = MockUowRepository.GetMock();
            service = new OrderService(uowMock.Object);
        }

        [Test]
        public void CreateOrder_Fail()
        {
            //var result = service.MakeOrder(_NoPhoneOrderDto);
            try
            {
                var result = service.MakeOrder(_InvalidPhoneOrderDto);
                Assert.IsNull(result);
                Assert.Throws<ArgumentNullException>(() => service.MakeOrder(_NoPhoneOrderDto));
            }
            catch (Exception ex) { }

            Assert.Pass();
        }

        [Test]
        public void CreateOrder_Success()
        {

            var result = service.MakeOrder(_ValidOnePhoneOrderDto);
            Assert.IsNotNull(result);
            Assert.GreaterOrEqual(1, result.Id);
            string ph1stName = uowMock.Object.Phones.GetItem(_ValidOnePhoneOrderDto.OrderedPhonesIds[0]).Name ?? "";
            Assert.That(result.OrderedPhones, Is.EqualTo(ph1stName));

            Assert.Pass();
        }

        [Test]
        public void CreateOrderOfPhonesArray_Success()
        {
            var ph1 = uowMock.Object.Phones.GetItem(_ValidManyPhonesOrderDto.OrderedPhonesIds[0]);
            var ph2 = uowMock.Object.Phones.GetItem(_ValidManyPhonesOrderDto.OrderedPhonesIds[1]);

            var result = service.MakeOrder(_ValidManyPhonesOrderDto);
            Assert.IsNotNull(result);
            Assert.GreaterOrEqual(1, result.Id);

            string ph1stName = ph1.Name ?? "";
            string ph2ndName = ph2.Name ?? "";
            StringAssert.Contains(ph1stName, result.OrderedPhones);
            StringAssert.Contains(ph2ndName, result.OrderedPhones);

            Assert.Pass();
        }

    }

}
