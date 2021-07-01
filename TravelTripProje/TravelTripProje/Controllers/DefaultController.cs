﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.OrderByDescending(x => x.ID).Skip(2).Take(1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.OrderBy(x => x.ID).Skip(3).Take(3).ToList();
            return PartialView(deger);
        }
        [HttpGet]
        public ActionResult iletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult iletisim(iletisim i)
        {
            c.iletisims.Add(i);
            c.SaveChanges();
            return View();
        }
    }
}