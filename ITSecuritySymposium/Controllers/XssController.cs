using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITSecuritySymposium.Models;

namespace ITSecuritySymposium.Controllers
{
    [Authorize]
    public class XssController : ApplicationController
    {
        //
        // GET: /Xss/
        public ActionResult Index()
        {
            var posts = Db.Posts.OrderByDescending(x=>x.Created).ToList();

            return View(posts);
        }

        /// <summary>
        /// Show post details
        /// </summary>
        public ActionResult Post(int id)
        {
            var postWithComments = Db.Posts.Include("Comments").Where(x => x.Id == id).Single();

            var cookie = new HttpCookie("favorite number", "1077, same as my pin") {HttpOnly = false};

            ControllerContext.HttpContext.Response.AppendCookie(cookie);
            
            return View(postWithComments);
        }

        [ValidateInput(false)]
        public ActionResult CreateComment(int id, string author, string content)
        {
            var post = Db.Posts.Find(id);

            var comment = new Comment {Post = post, Author = author, Content = content};
            post.Comments.Add(comment);

            Db.SaveChanges();

            return RedirectToAction("Post", new {id});
        }

        public ActionResult DeleteComment(int id, int postId)
        {
            var comment = Db.Comments.Find(id);
            
            Db.Comments.Remove(comment);

            Db.SaveChanges();

            return RedirectToAction("Post", new {id = postId});
        }
    }
}
