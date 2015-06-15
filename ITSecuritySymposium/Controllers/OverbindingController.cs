using System.Linq;
using System.Web.Mvc;
using ITSecuritySymposium.Models;

namespace ITSecuritySymposium.Controllers
{
    [Authorize]
    public class OverbindingController : ApplicationController
    {
        public ActionResult Index()
        {
            var members = Db.Members.ToList();

            return View(members);
        }

        public ActionResult AddMember(Member member)
        {
            Db.Members.Add(member);

            Db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}