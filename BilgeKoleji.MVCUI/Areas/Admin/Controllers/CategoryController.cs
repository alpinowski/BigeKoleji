using BilgeKoleji.MODEL.Entities;
using BilgeKoleji.MVCUI.Filter;
using BilgeKoleji.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji.MVCUI.Areas.Admin.Controllers
{
    [AuthFilter]
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        CategoryService db = new CategoryService();
        public ActionResult Index()
        {
            var userDetail = Session["login"] as User;
            TempData["User"] = userDetail.UserName + " " + userDetail.Password;
            return View(db.GetAll().ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category model)
        {
            model.ID = Guid.NewGuid();
            db.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            db.Remove(db.GetByID(id));
            return RedirectToAction("Index");
        }
        public ActionResult Update(Guid id)
        {
            return View(db.GetByID(id));
        }
        public ActionResult Update(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Update(model);
                return RedirectToAction("Index");
            }
            return View(); 
            

            
        }
    }
}