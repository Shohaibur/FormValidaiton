﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Web.UI.WebControls;
using FormValidaiton.Models;

namespace FormValidaiton.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login l)
        {
            return View(l);
        }
        [HttpGet]
        public ActionResult Signup()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Signup(Signup s)
        {
            
            return View(s);
        }
    }
}