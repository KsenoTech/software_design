using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Interfaces.Services;
using mvc.Models;

namespace mvc.Controllers
{
    public class ReportsController : Controller
    {
        IReportService reportService;
        IMotoService motoService;
        public ReportsController(IReportService reportservice, IMotoService phServ)
        {
            reportService = reportservice;
            motoService = phServ;
        }

        public ActionResult LinqReport()
        {
            return View(new LinqReportModel() { TypeList = motoService.GetTypes() });
        }
        [HttpPost]
        public ActionResult LinqReport(LinqReportModel model)
        {
            model.ReportSQLData = reportService.ReportMotosOfType(model.SelectedTypeId);
            model.TypeList = motoService.GetTypes();
            return View(model);
        }

        public ActionResult SPReport()
        {
            return View(new SPReportModel() { SelectedHaveMoney = 10, SelectedHaveInShop = 0 });
        }
        [HttpPost]
        public ActionResult SPReport(SPReportModel model)
        {
            model.ReportSQLData = reportService.ExecuteSP(model.SelectedHaveMoney, model.SelectedHaveInShop);
            return View(model);
        }
    }
}