using BilgeKoleji.COMMON.Tools;
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
        public class ProfileController : Controller
        {
            UserService db = new UserService();
            public ActionResult Index()
            {
                return View(db.GetByID(((User)Session["login"]).ID));
            }

            public ActionResult Edit()
            {
                return View(db.GetByID(((User)Session["login"]).ID));
            }

            [HttpPost]
            public ActionResult Edit(User model, HttpPostedFileBase ImagePath)
            {
                //todo: kullanıcı adı ve email null geldiği için güncelleme yapılmıyor.
                if (ImagePath == null)
                {
                    model.ImagePath = db.GetByID(model.ID).ImagePath;
                }
                else
                {
                    model.ImagePath = ImageUploader.UploadSingleImage("~/Uploads/Users", ImagePath);
                }
                var user = db.GetByID(model.ID);
                user.ImagePath = model.ImagePath;
                db.Update(user);
                return RedirectToAction("Index");
            }

            [HttpPost]
            public ActionResult ChangePwd(string OldPassword, string Password)
            {
                User user = db.GetByID(((User)Session["login"]).ID);

                if (user.Password != OldPassword)
                {
                    TempData["ErrPass"] = "Mevcut şifreniz yanlış";
                    return RedirectToAction("Edit");
                }

                user.Password = Password;
                db.Update(user);

                return RedirectToAction("Index");
            }
        }
    }
