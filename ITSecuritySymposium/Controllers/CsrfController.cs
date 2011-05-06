﻿using System.Linq;
using System.Web.Mvc;
using System;

namespace ITSecuritySymposium.Controllers
{
    [Authorize]
    public class CsrfController : ApplicationController
    {
        //
        // GET: /Csrf/
        public ActionResult Index()
        {
            var balances = Db.Balances.ToList();

            return View(balances);
        }

        public ActionResult Transfer()
        {
            var balance = Db.Balances.Where(x => x.UserName == User.Identity.Name).Single();

            return View(balance);
        }

        public ActionResult TransferMoney(string from, string to, double amount)
        {
            //Make sure the money is coming from the current user and is a positive amount 
            //if (!User.Identity.Name.Equals(from) || amount < 0) throw new ArgumentException();

            var balanceFrom = Db.Balances.Where(x => x.UserName == from).Single();
            var balanceTo = Db.Balances.Where(x => x.UserName == to).Single();

            balanceFrom.Amount -= amount;
            balanceTo.Amount += amount;

            Db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}