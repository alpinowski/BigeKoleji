using BilgeKoleji.MVCUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji.MVCUI.Controllers
{
    public class KarneController : Controller
    {
        // GET: Karne
        public ActionResult KarneGoruntu()
        {
            //notların girildiği form 
            return View();
        }

        [HttpPost]
        public ActionResult KarneGoruntu(Karne model)
        {
            //int matharf;
            //var matOrt = (model.mat1 * 40 / 100) + (model.mat2 * 60 / 100);

            //if (30>matOrt>50)
            //{
            //    matharf = 2;
            //}

            return View();
        }
    }
}