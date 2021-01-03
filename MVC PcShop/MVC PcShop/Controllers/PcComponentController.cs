using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PcShop.Models;

namespace MVC_PcShop.Controllers
{
    public class PcComponentController : Controller
    {

        public ActionResult Index()
        {
            PcComponentModel pccomponentModel = new PcComponentModel();
            ViewBag.ComponentList = pccomponentModel.findAll();
            return View();
        }
    }
}