using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Interfaces.Services;
using Lab5AspnetMVC.Models;

namespace Lab5AspnetMVC.Controllers
{
    public class ReportsController : Controller
    {
        IReportService reportService;
        IPhoneService phoneService;
        public ReportsController(IReportService reportservice, IPhoneService phServ)
        {
            reportService = reportservice;
            phoneService = phServ;
        }

        public ActionResult LinqReport()
        {
            return View(new LinqReportModel() {ManufList= phoneService.GetManufacturers()});
        }
        [HttpPost]
        public ActionResult LinqReport(LinqReportModel model)
        {
            model.ReportData = reportService.ReportPhonesOfMunufacturer(model.SelectedManufId);
            model.ManufList = phoneService.GetManufacturers();
            return View(model);
        }

        public ActionResult SPReport()
        {
            return View(new SPReportModel() { SelectedMonth=10, SelectedYear=2019} );
        }
        [HttpPost]
        public ActionResult SPReport(SPReportModel model)
        {
            model.ReportData = reportService.ExecuteSP(model.SelectedMonth,model.SelectedYear);
            return View(model);
        }
    }
}