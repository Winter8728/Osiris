using Osiris.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Osiris.CloudWeb.Controllers
{
    public class UserManagerController : Controller
    {
        Osiris.BLL.UserInfo bll = new BLL.UserInfo();
        [Osiris.CloudWeb.App_Start.CheckLogin]
        public ActionResult Index()
        {
            ViewData["pageCount"] = bll.GetUserCount("");
            return View();
        }

        [HttpPost]
        public string AllUserList(string index, string pageSize)
        {
            string str = string.Empty;

            //具体的页面数
            int pageIndex=0;
            int.TryParse(index, out  pageIndex);

            //页面显示条数
            int size = Convert.ToInt32(pageSize);

            if (pageIndex == 0)
            {
                pageIndex = 1;
            }
           
            int count;
            List<Osiris.Model.UserInfo> list = bll.GetUserInfoList(size, pageIndex, "", out count);

            StringBuilder sb = new StringBuilder();
            foreach (Osiris.Model.UserInfo p in list)
            {
                sb.Append("<tr><td>");
                sb.Append(p.Id.ToString());
                sb.Append("</td><td>");
                sb.Append("<a href='/UserManager/Edit/"+p.Id+"'>");
                sb.Append(p.UserName);
                sb.Append("</a></td><td>");
                sb.Append(p.IsLock == 0 ? "正常" : "<span class='red'>锁定</span>");
                sb.Append("</td><td>");
                sb.Append(p.IsAdmin==false?"否":"是");
                sb.Append("</td><td>");
                sb.Append(p.CreateTime.ToString());
                sb.Append("</td><td>");
                sb.Append(p.Creator);
                sb.Append("</td><td>");
                sb.Append("<div class=\"table-fun table-option\"><a href=\"/UserManager/Edit/" + p.Id + "\">修改</a> <a href='/UserManager/DeleteUser/" + p.Id + "' id='btnDel'>删除</a></div>");
                sb.Append("</td></tr>");
            }
            str = sb.ToString();
            return str;
        }

        public ActionResult Edit(int id=0)
        {
            UserInfo user =  new UserInfo();
            user.Id = id;
            if (id != 0)
            {  
                user = bll.GetModel(id);
            }
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(UserInfo u)
        {
            if (Request.Form["IsLock"] == null)
                u.IsLock = 0;
            else
                u.IsLock = 1;
            if (Request.Form["IsAdmin"] == null)
                u.IsAdmin = false;
            else
                u.IsAdmin = true;
            if (Session["UserName"] != null)
                u.Creator = Session["UserName"].ToString();
            u.Remark = "云端添加";
            //新增
            if (u.Id == 0)
            {
                u.Password = Tools.Commons.Get_MD5(u.Password);
                bll.AddUserInfo(u);
            }
            else
            {
                if (u.Password.Equals("$%^&**&^%$"))
                    u.Password = null;
                else
                    u.Password = Tools.Commons.Get_MD5(u.Password);
                bll.UpdateUserInfo(u);
            }

            return Redirect("/UserManager/Index");
        }

        
        public ActionResult DeleteUser(int id)
        {
            bool flag = bll.DeleteUserInfo(id);
            return Redirect("/UserManager/Index");
        }
        [HttpPost]
        public JsonResult ExistsUser(string userName)
        {
            bool flag = bll.Exists(userName);
            return Json(new { result = flag==true?1:0});
        }
    }
}
