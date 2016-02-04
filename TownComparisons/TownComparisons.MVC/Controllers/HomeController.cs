﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TownComparisons.Domain;
using TownComparisons.Domain.Abstract;
using TownComparisons.Domain.Entities;

namespace TownComparisons.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IService _service;

        public HomeController()
            : this(new Service())
        {
            //Empty
        }
        public HomeController(IService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            //just to get the database initializer runned
            List<OrganisationalUnitInfo> ouInfos = _service.GetOrganisationalUnitInfos();
            ouInfos = ouInfos;

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


        //(exempel):
        public ActionResult TownOperators()
        {
            //_service.GetTownOperators(...) osv.

            return View();
        }
    }
}