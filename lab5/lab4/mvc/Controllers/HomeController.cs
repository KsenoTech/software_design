using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //ctrl + shift+ пробел
        {
            return View();//url работает только с get
        }//типом запроса мы сами управляем
        //но стандарт - post, тк данных много, длинны строки может не хватить ,поэтому get не подройдет - он ограниченный


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}