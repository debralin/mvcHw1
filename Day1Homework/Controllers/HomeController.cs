using Day1Homework.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        static List<ListViewModel> list = new List<ListViewModel>();

        [HttpPost]
        public ActionResult Index(ListViewModel pageData)
        {
            list.Add(new ListViewModel
            {
                Category = pageData.Category,
                Money = pageData.Money,
                Date = pageData.Date,
                Description = pageData.Description
            });

            //return View(list);
            //因為 return 要秀的model資料是放在record,
            return View();
        }

        public ActionResult Record()
        {
            return View(list);
        }

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