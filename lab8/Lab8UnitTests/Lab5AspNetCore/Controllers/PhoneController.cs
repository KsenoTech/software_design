using DTO;
using Interfaces.Services;
using Lab5AspnetMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAspnetMVC.Controllers
{
    public class PhoneController : Controller
    {
        IPhoneService phoneService;
        public PhoneController(IPhoneService crudDb)
        {
            phoneService = crudDb;
        }

        // GET: Phones
        public ActionResult Index()
        {
            List<ManufacturerDto> mList = phoneService.GetManufacturers();
            var items = phoneService.GetAllPhones().Select(i=>new PhoneModel(i,mList) );
            return View("List",items);
        }

        public ActionResult Edit(int id)
        {
            List<ManufacturerDto> mnfs = phoneService.GetManufacturers();
            PhoneModel p = new PhoneModel(phoneService.GetPhone(id), mnfs);
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(PhoneModel model)
        {
            PhoneDto ph = new PhoneDto();
            ph.Id = model.Id;
            ph.Name = model.Name;
            ph.Cost = model.Cost;
            ph.ManufacturerId = model.ManufacturerId;
            phoneService.UpdatePhone(ph);
            return RedirectToAction("Index");
        }

        
        public ActionResult Create()
        {
            return View(new PhoneModel(phoneService.GetManufacturers()));
        }

        [HttpPost]
        public ActionResult Create(PhoneModel model)
        {
            PhoneDto ph = new PhoneDto();
            ph.Name = model.Name;
            ph.Cost = model.Cost;
            ph.ManufacturerId = model.ManufacturerId;

            phoneService.CreatePhone(ph);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            phoneService.DeletePhone(id);
            return RedirectToAction("Index");
        }

    }
}