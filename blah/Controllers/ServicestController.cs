using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blah.Controllers
{
    public class ServicestController : Controller
    {
        // GET: Servicest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() {
            return View();
        }
    }
}