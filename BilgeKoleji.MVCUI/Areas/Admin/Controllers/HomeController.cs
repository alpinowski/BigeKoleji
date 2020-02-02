using BilgeKoleji.MODEL.Entities;
using BilgeKoleji.MVCUI.Areas.Admin.Models;
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
    public class HomeController : Controller
    {
        TodoService tododb = new TodoService();
        ArticleService articledb = new ArticleService();
        TagService tagdb = new TagService();
        UserService userdb = new UserService();
        CommentService commentdb = new CommentService();
        RegisterService registerdb = new RegisterService();
        StudentService studentdb = new StudentService();
        ManagementRegisterService managementregisterdb= new ManagementRegisterService();
        TeachersService teacherdb = new TeachersService();
        CategoryService categorydb = new CategoryService();



        public ActionResult OgretmenIndex()
        {
            HomeVM home = new HomeVM();
            home.Todos = (tododb.GetActive().Where(x => x.RegisterId == ((User)Session["login"]).ID && x.IsComplete == false).ToList());
            home.UserCount = userdb.GetActive().Count();
            home.TagCount = tagdb.GetActive().Count();
            home.Articles = articledb.GetActive();
            home.Comments = commentdb.GetActive();

            return View(home);
        }
    }
}