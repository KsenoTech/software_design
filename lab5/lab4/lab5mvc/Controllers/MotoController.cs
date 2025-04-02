using DTO;
using lab5mvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Interfaces.Services;

namespace lab5mvc.Controllers
{
    public class MotoController : Controller
    {
        IMotoService motoService;
        public MotoController(IMotoService mootoServ)
        {
            motoService = mootoServ;
        }

        // GET: Motos
        public ActionResult Index()
        {
            List<TypeDto> mList = motoService.GetTypes();
            var items = motoService.GetAllMotos().Select(i => new MotoModel(i, mList));
            return View("List", items);
        }

        public ActionResult Edit(int id)
        {
            List<TypeDto> mnfs = motoService.GetTypes();
            MotoModel p = new MotoModel(motoService.GetMoto(id), mnfs);
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(MotoModel model)
        {
            MotoDto ph = new MotoDto();
            ph.id_Motorcycle = model.id_Motorcycle;
            ph.Brand_name = model.Brand_name;
            ph.Model = model.Model;
            ph.Cost = model.Cost;
            ph.id_Type_FK = model.id_Type_FK;
            motoService.UpdateMoto(ph);
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {
            return View(new MotoModel(motoService.GetTypes()));
        }

        [HttpPost]
        public ActionResult Create(MotoModel model)
        {
            MotoDto ph = new MotoDto();
            ph.id_Motorcycle = model.id_Motorcycle;
            ph.Brand_name = model.Brand_name;
            ph.Model = model.Model;
            ph.Cost = model.Cost;
            ph.id_Type_FK = model.id_Type_FK;

            motoService.CreateMoto(ph);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            motoService.DeleteMoto(id);
            return RedirectToAction("Index");
        }

    }
}