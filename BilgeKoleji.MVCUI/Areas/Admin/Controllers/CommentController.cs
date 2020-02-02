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
    public class CommentController : Controller
    {
        // GET: Admin/Comment
        CommentService cs = new CommentService();
        public ActionResult Index()
        {
            
            return View(cs.GetAll());
        }

        public ActionResult Update(Guid Id)
        {
            return View(cs.GetByID(Id));
        }

        [HttpPost]
        public ActionResult Update(Comment model)
        {
            if (ModelState.IsValid)
            {
                cs.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
                                   
        }
        public ActionResult Delete(Guid Id)
        {
            cs.Remove(cs.GetByID(Id));
            return RedirectToAction("Index");
        }
        public ActionResult ActiveComment(Guid Id)
        {
            Comment comment = cs.GetByID(Id);
            comment.IsActive = true;
            cs.Update(comment);

            return RedirectToAction("Index");
        }
    }
}