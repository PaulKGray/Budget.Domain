using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Budget.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {
            ViewBag.Message = "Right its time to get started.";

            return View();
        }


    }
}
