using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Computer_Ency.Controllers
{
    public class EncyController : Controller
    {
        // GET: Ency
        public ActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "This is the welcome aciton method";
        }
    }
}