using BilgeKoleji.DAL.Model.Context;
using BilgeKoleji.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult HomePage()
        {
         
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
       
        public ActionResult About()
        {
            return View();
        }
    }
}
