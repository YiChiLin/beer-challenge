﻿using System.Threading.Tasks;
using System.Web.Mvc;

namespace BeerChallenge.Controllers
{
    public class HomeController : Controller
    {
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

        public async Task<ActionResult> Index()
        {
            return View();
        }
    }
}