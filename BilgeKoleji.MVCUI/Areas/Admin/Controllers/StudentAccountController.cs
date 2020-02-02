using BilgeKoleji.COMMON.Tools;
using BilgeKoleji.MODEL.Entities;
using BilgeKoleji.MODEL.Enums;
using BilgeKoleji.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji.MVCUI.Areas.Admin.Controllers
{
    public class StudentAccountController : Controller
    {
        UserService db;

        public StudentAccountController()
        {
            if (db == null)
            {
                db = new UserService();
            }
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User model)
        {
            try
            {
                if (model.Password != null && model.UserName != string.Empty)
                {
                    if (db.CheckUser(model.UserName, model.Password))
                    {
                        var user = db.GetByDefault(x => x.UserName == model.OgrenciTCKimlikNumarasi);
                        Session["login"] = user;
                        var userDetail = Session["login"] as User;
                        TempData["User"] = userDetail.OgrenciTCKimlikNumarasi + " " + userDetail.OkulNumarasi;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["Error"] = "Giriş bilgileri hatalı";
                    }
                }
                else
                {
                    TempData["Error"] = "Lütfen boş alan bırakmayınız";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost, ActionName("Register")]
        public ActionResult RegisterComplete(User model, HttpPostedFileBase ImagePath)
        {
            if (ModelState.IsValid)
            {
                if (db.Any(x => x.UserName == model.OgrenciTCKimlikNumarasi))
                {
                    ViewBag.ExistsUser = "Üye adı daha önce alınmış";
                    return View();
                }
                else if (db.Any(x => x.Password == model.OkulNumarasi.ToString()))
                {
                    ViewBag.ExistsPassword = "Parola daha önce girilmiş";
                    return View();
                }
                else
                {
                    model.ID = Guid.NewGuid();
                    model.ActivationCode = Guid.NewGuid();
                    model.IsActive = false;
                    model.ImagePath = ImageUploader.UploadSingleImage("~/Uploads/Users/", ImagePath);
                    db.Add(model);

                    string message = $"Hoşgeldin {model.UserName},\n\nKayıt işlemini tamamlamak için lütfen aşağıdaki bağlantıya tıklayın.\n\n{Request.Url.Scheme}{System.Uri.SchemeDelimiter}{Request.Url.Authority}/Admin/Account/Complete/{model.ActivationCode}";

                    MailSender.SendEmail(model.Email, "Kayıt talebiniz alındı", message);
                    return RedirectToAction("Success,Account");

                }

            }
            else
            {
                return View();
            }
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Complete(Guid Id)
        {
            if (db.Any(x => x.ActivationCode == Id))
            {
                User activeUser = db.GetByDefault(x => x.ActivationCode == Id);
                activeUser.IsActive = true;
                activeUser.ActivationCode = Guid.NewGuid();
                db.Update(activeUser);
                ViewBag.ActivationStatus = 1;
            }
            else
            {
                ViewBag.ActivationStatus = 0;
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Remove("login");
            return RedirectToAction("Index");
        }
    }
}