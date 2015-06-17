using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSecuritySymposium.Controllers
{
    public class CasController : Controller
    {
        public ActionResult Index()
        {
            return CasMvc.LoginAndRedirect();
        }
    }
}