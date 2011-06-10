using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSecuritySymposium.Controllers
{
    public class Html5Controller : Controller
    {
        //
        // GET: /Html5/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InputTypes()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InputTypes(string inputs)
        {
            ViewBag.Message = "Values Posted Successfully";

            return View();
        }

        public ActionResult Constraints()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Constraints(string inputs)
        {
            ViewBag.Message = "Values Posted Successfully";

            return View();
        }

        public ActionResult CustomConstraints()
        {
            return View();
        }

        public ActionResult PolyfillRequired()
        {
            return View();
        }

        public ActionResult PolyfillSlider()
        {
            return View();
        }

        public ActionResult PolyfillSliderDynamicLoad()
        {
            return View();
        }

        public ActionResult PolyfillPlaceholder()
        {
            return View();
        }
    }
}
