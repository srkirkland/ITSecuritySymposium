using System.Web;
using System.Web.Mvc;

namespace ITSecuritySymposium.Controllers
{
    public class CookieController : Controller
    {
        private string _demo1 = "All hail hypnotoad!";
        private string _demo2 = "All glory to the hypnotoad!";

        private const string _demo1Key = "demo1";
        private const string _demo2Key = "demo2";

        //
        // GET: /Cookie/

        public ActionResult Index()
        {
            var cookie = new HttpCookie(_demo1Key, _demo1);
            var cookie2 = new HttpCookie(_demo2Key, _demo2);

            // prevent client scripts from reading the cookie
            cookie.HttpOnly = true;

            HttpContext.Response.Cookies.Add(cookie);
            HttpContext.Response.Cookies.Add(cookie2);

            return View();
        }

        [HttpPost]
        public ActionResult Index(int? useless)
        {
            // copy the values right back into cookies
            Response.Cookies.Add(new HttpCookie(_demo1Key, ReplaceChars(Request.Cookies[_demo1Key].Value)) { HttpOnly = true });
            Response.Cookies.Add(new HttpCookie(_demo2Key, ReplaceChars(Request.Cookies[_demo2Key].Value)));

            return View();
        }

        /// <summary>
        /// Replaces spaces and exclamation mark codes back to the actual char
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string ReplaceChars(string value)
        {
            value = value.Replace("%20", " ");
            value = value.Replace("%21", "!");

            return value;
        }
    }
}
