using DTO;
using Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAspnetMVC.Controllers
{
    public class OrderController : Controller
    {
        IPhoneService phoneService;
        IOrderService orderServ;
        public OrderController(IPhoneService crudDb, IOrderService orderservice)
        {
            orderServ = orderservice;
            phoneService = crudDb;
        }

        // GET: Order
        public ActionResult Index()
        {
            var items = orderServ.GetAllOrders();
            return View(items);
        }

        public ActionResult MakeOrder()
        {
            return View(new Lab5AspnetMVC.Models.OrderModel()
            { PhoneList = phoneService.GetAllPhones(),
                Order =new OrderDto() { }
            });
        }

        [HttpPost]
        public ActionResult MakeOrder(Lab5AspnetMVC.Models.OrderModel model)
        {
            if (ModelState.IsValid)
            {
                var result = orderServ.MakeOrder(model.Order);
                if (result != null)
                    return RedirectToAction("Index");
            }
            model.PhoneList = phoneService.GetAllPhones();
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            orderServ.DeleteOrder(id);
            return RedirectToAction("Index");
        }


    }
}
