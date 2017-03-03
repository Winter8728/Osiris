using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OsirisAPIWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Osiris.BLL.DeviceAd bll = new Osiris.BLL.DeviceAd();
            string returnValue;
            DataSet ds = bll.UserAllAd("admin", "11-22-33-44-55", out returnValue);

            //Osiris.BLL.UserInfo bll = new Osiris.BLL.UserInfo();            
            //string str = bll.CheckUserInfo("admin", "11-22-33-44-55" );

            return View();
        }
    }
}
