
using DTO;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class OrderController : Controller
    {
        IMotoService motoService;
        IOrderService orderServ;
        public OrderController(IMotoService crudDb, IOrderService orderservice)
        {
            orderServ = orderservice;
            motoService = crudDb;
        }

        // GET: Order
        public ActionResult Index()
        {
            var items = orderServ.GetAllOrders();
            return View(items);
        }

        public ActionResult MakeOrder()
        {
            return View(new mvc.Models.OrderModel()
            {
                MotoList = motoService.GetAllMotos(),
                Order = new OrderDto() { }
            });
        }

        [HttpPost]
        public ActionResult MakeOrder(mvc.Models.OrderModel model)
        {
            if (ModelState.IsValid)
            {
                var result = orderServ.MakeOrder(model.Order);
                if (result != null)
                    return RedirectToAction("Index");
            }
            model.MotoList = motoService.GetAllMotos();
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            orderServ.DeleteOrder(id);
            return RedirectToAction("Index");
        }


    }
}
