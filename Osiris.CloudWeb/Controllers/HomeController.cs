using Osiris.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Osiris.CloudWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [Osiris.CloudWeb.App_Start.CheckLogin]
        public ActionResult Index()
        {
            ViewData["name"] = Session["UserName"].ToString();
            if (Session["Eare"] != null)
            {
                ViewData["Eare"] = Session["Eare"].ToString();
            }
            else
                ViewData["Eare"] = "上海市";
            return View();
        }
        public ActionResult Main()
        {
            return View();
        }
        public ActionResult EareList()
        {

            if (Session["Eare"] != null)
            {
                ViewData["Eare"] = Session["Eare"].ToString();
            }
               
            return View();
        }
        [HttpPost]
        public ActionResult EareList(string eare)
        { 
               Session["Eare"] = eare; 


                return JavaScript("setEare();");
        }
        public ActionResult Login()
        { 
            return View();
        }
         [HttpPost]
        public ActionResult Login(Osiris.CloudWeb.Models.UserInfo user)
        {
            string uName = user.UserName.Trim();
            string uPassword = Commons.Get_MD5( user.Password.Trim());
            Osiris.BLL.UserInfo bll = new BLL.UserInfo();
            string r = bll.CheckUserInfo(uName, uPassword);
            if (r.Equals("success"))
            {
                Session["UserName"] = uName;
                Session["Eare"] = "上海市";
                return Redirect("/home/index");
            }
            else
            {
                // var scripts = string.Format("alert('{0}');", r);
                // return Content(string.Format("<script>alert('{0}');</script>", r));
                Response.Write(string.Format("<script>alert('{0}');</script>", r));
                return View("login");
            }
        }

         public ActionResult LoginOut()
         {
             Session.Remove("UserName");
             Session.Clear(); 
             return View("login");
         }
    }


}
