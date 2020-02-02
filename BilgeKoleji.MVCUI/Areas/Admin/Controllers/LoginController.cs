using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji.MVCUI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Ogretmen()
        {
            return View();
        }

        public ActionResult Ogrenci(string tc, string pass)
        {
            //var ogr = db.ögr.where(i=>i.Tcno==tc && i.password==pass).firstordefault
            //session['ögrenci']=ogr;
            return View();
        }
    }
}