using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BadGuy.Controllers
{
    public class CsrfController : Controller
    {
        //
        // GET: /Csrf/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetForgeryPage()
        {
            return View();
        }

        public ActionResult PostForgeryPage()
        {
            return View();
        }
    }
}
