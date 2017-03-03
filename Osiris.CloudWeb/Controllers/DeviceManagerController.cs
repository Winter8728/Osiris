using Osiris.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Osiris.CloudWeb.Controllers
{
    public class DeviceManagerController : Controller
    {
         
        Osiris.BLL.DeviceInfo bll = new BLL.DeviceInfo();
        [Osiris.CloudWeb.App_Start.CheckLogin]
        public ActionResult Index()
        {
            ViewData["pageCount"] = bll.GetDeviceCount("");
            return View();
        }


        [HttpPost]
        public string AllDeviceList(string index, string pageSize)
        {
            string str = string.Empty;

            //具体的页面数
            int pageIndex = 0;
            int.TryParse(index, out  pageIndex);

            //页面显示条数
            int size = Convert.ToInt32(pageSize);

            if (pageIndex == 0)
            {
                pageIndex = 1;
            }
           
            int count;
            List<Osiris.Model.DeviceInfo> list = bll.GetDeviceInfoList(size, pageIndex, "", out count);

            StringBuilder sb = new StringBuilder();
            foreach (Osiris.Model.DeviceInfo p in list)
            {
                sb.Append("<tr><td>");
                sb.Append(p.DeviceId);
                sb.Append("</td><td>");
                sb.Append(p.Brightness);
                sb.Append("</td><td>");
                sb.Append(p.Temperature);
                sb.Append("</td><td>");
                sb.Append(p.Powerwaste);
                sb.Append("</td><td>");
                sb.Append(p.ViewModel);
                sb.Append("</td><td>");
                sb.Append(p.Gyroscope);
                sb.Append("</td><td>");
                sb.Append(p.Switch=="0"?"<img src='/content/images/icon_green.png'/>":"<img src='/content/images/icon_gray.png'/>");
                sb.Append("</td><td>");
                sb.Append(p.Lon);
                sb.Append("</td><td>");
                sb.Append(p.Lat);
                sb.Append("</td><td>");
                sb.Append(p.IsLock == false ? "正常" : "<span class='red'>锁定</span>"); 
                sb.Append("</td><td>");
                sb.Append(p.CreateTime.ToString());
                sb.Append("</td><td>");
                sb.Append(p.Creator);
                sb.Append("</td><td>");
                sb.Append("<div class=\"table-fun table-option\"><a href='/DeviceManager/Edit/" + p.Id + "'>修改</a> <a href='/DeviceManager/DeleteDevie/" + p.Id + "'>删除</a></div>");
                sb.Append("</td></tr>");
            }
            str = sb.ToString();
            return str;
        }



        public ActionResult Edit(int id = 0)
        {
            DeviceInfo dev = new DeviceInfo();
            dev.Id = id;
            if (id != 0)
            {
                dev = bll.GetModel(id);
            }
            return View(dev);
        }
        [HttpPost]
        public ActionResult Edit(DeviceInfo d)
        {
            if (Request.Form["IsLock"] == null)
                d.IsLock = false;
            else
                d.IsLock = true;
            if (Request.Form["switch"] == null)
                d.Switch = "1";
            else
                d.Switch = "0";
            if (Session["UserName"] != null)
                d.Creator = Session["UserName"].ToString();
            d.Remark = "云端添加";
            //新增
            if (d.Id == 0)
            {

                bll.Add(d);
            }
            else
            {
                
                bll.Update(d);
            }

            return Redirect("/DeviceManager/Index");
        }


        public ActionResult DeleteDevie(int id)
        {
            bool flag = bll.Delete(id);
            return Redirect("/DeviceManager/Index");
        }
        [HttpPost]
        public JsonResult ExistsDevice(string deviceId)
        {
            bool flag = bll.Exists(deviceId);
            return Json(new { result = flag == true ? 1 : 0 });
        }
    }
}
