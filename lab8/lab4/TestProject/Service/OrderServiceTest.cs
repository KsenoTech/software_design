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
using TestProject.Moks;


namespace TestProject.Service
{
    public class OrderServiceTest
    {
        private readonly OrderDto _NoPhoneOrderDto = new OrderDto
        {
            Adress = "city str apt",
            Customer = "Customer1",
            PhoneNumber = "123456",
        };
        private readonly OrderDto _InvalidPhoneOrderDto = new OrderDto
        {
            Adress = "city str apt",
            Customer = "Customer1",
            PhoneNumber = "123456",
           
        };
        private readonly OrderDto _ValidOnePhoneOrderDto = new OrderDto
        {
            Id = 1,
            Adress = "city str apt",
            Customer = "Customer1",
            PhoneNumber = "123456",
            OrderedMotosIDs = new List<int> { 1 }
        };
        private readonly OrderDto _ValidManyPhonesOrderDto = new OrderDto
        {
            Adress = "city str apt",
            Customer = "Customer1",
            PhoneNumber = "123456",
            OrderedMotosIDs = new List<int> { 1, 2 },
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
       var result = service.MakeOrder(_InvalidPhoneOrderDto);
       
       //Assert.Throws<IsNull>(() => service.MakeOrder(_NoPhoneOrderDto));
       Assert.IsNull(result);

          //Assert.Pass();
        }

        [Test]
        public void CreateOrder_Success()
        {

            var result = service.MakeOrder(_ValidOnePhoneOrderDto);
            Assert.IsNotNull(result);
            Assert.GreaterOrEqual(1, result.Id);
            string ph1stName = uowMock.Object.Motos.GetItem(_ValidOnePhoneOrderDto.OrderedMotosIDs[0]).Brand_name ?? "";
            Assert.That(result.OrderedMotos, Is.EqualTo(ph1stName));

            Assert.Pass();
        }

        [Test]
        public void CreateOrderOfPhonesArray_Success()
        {
            var ph1 = uowMock.Object.Motos.GetItem(_ValidManyPhonesOrderDto.OrderedMotosIDs[0]);
            var ph2 = uowMock.Object.Motos.GetItem(_ValidManyPhonesOrderDto.OrderedMotosIDs[1]);

            var result = service.MakeOrder(_ValidManyPhonesOrderDto);
            Assert.IsNotNull(result);
            Assert.GreaterOrEqual(1, result.Id);

            string ph1stName = ph1.Brand_name ?? "";
            string ph2ndName = ph2.Brand_name ?? "";
            StringAssert.Contains(ph1stName, result.OrderedMotos);
            StringAssert.Contains(ph2ndName, result.OrderedMotos);

            Assert.Pass();
        }

    }

}
