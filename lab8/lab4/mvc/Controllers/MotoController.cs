using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Interfaces.Services;
using mvc.Models;


namespace mvc.Controllers
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
        public ActionResult EditP(MotoModel model)
        {
            MotoDto ph = new MotoDto();
            ph.Id = model.Id;
            ph.Brand_name = model.Brand_name;
            ph.Model_name = model.Model_name;
            ph.Cost = model.Cost;
            ph.Color = model.Color;
            ph.id_Type_FK = model.id_Type_FK;
            motoService.UpdateMoto(ph);
            return RedirectToAction("Index");
        }

       
        public ActionResult Create()
        {
            return View(new MotoModel(motoService.GetTypes()));
        }

        [HttpPost]
        public ActionResult CreateP(MotoModel model)
        {
            if (model != null)
            {
                MotoDto ph = new MotoDto();
                ph.Id = model.Id;
                ph.Brand_name = model.Brand_name;
                ph.Model_name = model.Model_name;
                ph.Cost = model.Cost;
                ph.Color = model.Color;
                ph.id_Type_FK = model.id_Type_FK;

                motoService.CreateMoto(ph);

                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }

        public ActionResult Delete(int id)
        {
            motoService.DeleteMoto(id);
            return RedirectToAction("Index");
        }

    }
}