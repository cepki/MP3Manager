using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MP3Manager.Core.Repository;

namespace MP3Manager.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository myRepo = new Repository();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            myRepo.nesto();
            return View();
        }
    }
}
