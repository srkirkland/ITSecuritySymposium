using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSecuritySymposium.Controllers
{
    public class CookieController : Controller
    {
        //
        // GET: /Cookie/

        public ActionResult Index()
        {
            var cookie = new HttpCookie("demo1", "Down with hypnotoad!");
            var cookie2 = new HttpCookie("demo2", "All glory to the hypnotoad.");

            // prevent client scripts from reading the cookie
            cookie.HttpOnly = true;

            HttpContext.Response.Cookies.Add(cookie);
            HttpContext.Response.Cookies.Add(cookie2);

            return View();
        }

    }
}
