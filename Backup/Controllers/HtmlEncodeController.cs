using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSecuritySymposium.Controllers
{
    public class HtmlEncodeController : Controller
    {
        //
        // GET: /HtmlEncode/

        public ActionResult Index()
        {
            return View(string.Empty);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(string txt)
        {
            ViewData["txt"] = txt;

            return View();
        }
    }
}
