using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSecuritySymposium.Controllers
{
    public abstract class ApplicationController : Controller
    {
        protected readonly SymposiumDataContext Db = new SymposiumDataContext();

        public string Message
        {
            set { TempData["Message"] = value; }
        }

        protected override void Dispose(bool disposing)
        {
            Db.Dispose();
            base.Dispose(disposing);
        }
    }
}
