using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Interfaces.Services;
using lab5mvc.Models;

namespace lab5mvc.Controllers
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
            model.ReportData = reportService.ReportMotosOfType(model.SelectedTypeId);
            model.TypeList = motoService.GetTypes();
            return View(model);
        }

        public ActionResult SPReport()
        {
            return View(new SPReportModel() { SelectedMonth = 10, SelectedYear = 2019 });
        }
        [HttpPost]
        public ActionResult SPReport(SPReportModel model)
        {
            model.ReportSQLData = reportService.ExecuteSP(model.SelectedMonth, model.SelectedYear);
            return View(model);
        }
    }
}