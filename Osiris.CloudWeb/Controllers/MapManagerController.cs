using Osiris.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Osiris.Model;

namespace Osiris.CloudWeb.Controllers
{
    public class MapManagerController : Controller
    {
        Osiris.BLL.Coordinate bll = new BLL.Coordinate();
        private static string BaiduAK = System.Configuration.ConfigurationManager.AppSettings["BaiduAK"];
        [Osiris.CloudWeb.App_Start.CheckLogin]
        public ActionResult Index()
        {
            ViewData["BaiduAK"] = BaiduAK;
            if (Session["Eare"] != null)
            {
                ViewData["Eare"] = Session["Eare"].ToString();
                ViewData["Coordinate"] = bll.GetCoordinateByeare(Session["Eare"].ToString());
            }


            return View();
        }
        [HttpPost]
        public JsonResult GetCurrentEareDevice(string eare)
        {
            var res = new JsonResult();
            StringBuilder jsonText = new StringBuilder();
            Osiris.BLL.DeviceInfo dbll = new BLL.DeviceInfo();
            List<Osiris.Model.DeviceInfo> list = dbll.GetDeviceInfoAllList();
            string url = string.Empty;

            jsonText.Append("{\"result\":[");
            foreach (Osiris.Model.DeviceInfo m in list)
            {
                
                string newl = m.Lat + "," + m.Lon;
                url = string.Format("http://api.map.baidu.com/geocoder/v2/?output=json&ak={0}&location={1}", BaiduAK, newl);
                string returnStr = HttpHelper.GetResponseString(HttpHelper.CreateGetHttpResponse(url, null));

                JObject jo = (JObject)JsonConvert.DeserializeObject(returnStr);
                string district = jo["result"]["addressComponent"]["district"].ToString();
                string formatted_address = jo["result"]["formatted_address"].ToString();
                string sematic_description = jo["result"]["sematic_description"].ToString();
                if (eare.Equals("上海市"))
                {
                    jsonText.Append("{");
                    jsonText.Append(string.Format("\"id\":{0},", m.Id));
                    jsonText.Append(string.Format("\"deviceid\":\"{0}\",", m.DeviceId));
                    jsonText.Append(string.Format("\"lon\":\"{0}\",", m.Lon));
                    jsonText.Append(string.Format("\"lat\":\"{0}\",", m.Lat));
                    jsonText.Append(string.Format("\"district\":\"{0}\",", district));
                    jsonText.Append(string.Format("\"formatted_address\":\"{0}\",", formatted_address));
                    jsonText.Append(string.Format("\"sematic_description\":\"{0}\"", sematic_description));
                    jsonText.Append("},");
                }
                else
                {
                    if (eare.Equals(district))
                    {
                        jsonText.Append("{");
                        jsonText.Append(string.Format("\"id\":{0},", m.Id));
                        jsonText.Append(string.Format("\"deviceid\":\"{0}\",", m.DeviceId));
                        jsonText.Append(string.Format("\"lon\":\"{0}\",", m.Lon));
                        jsonText.Append(string.Format("\"lat\":\"{0}\",", m.Lat));
                        jsonText.Append(string.Format("\"district\":\"{0}\",", district));
                        jsonText.Append(string.Format("\"formatted_address\":\"{0}\",", formatted_address));
                        jsonText.Append(string.Format("\"sematic_description\":\"{0}\"", sematic_description));
                        jsonText.Append("},");
                    }
                }
            }
            jsonText.Remove(jsonText.Length - 1, 1);
            jsonText.Append("]}");

            res.Data = jsonText.ToString();

            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;//允许使用GET方式获取，否则用GET获取是会报错。  
            return res;
        }


        public ActionResult Coordinate()
        {
            ViewData["pageCount"] = bll.GetRecordCount("");
            return View();
        }
        /// <summary>
        /// 获取地区
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string GetCurrentEare()
        {
            if (Session["Eare"] != null)
            {
                return Session["Eare"].ToString();
            }
            else
                return "上海市"; //出错时.返回上海市
        }

        [HttpPost]
        public string GetCurrentCoordinate()
        {
            if (Session["Eare"] != null)
            {
                return bll.GetCoordinateByeare(Session["Eare"].ToString());
            }
            else
                return "121.48,31.23"; //出错时.返回上海市坐标
        }
        [HttpPost]
        public string AllCoordinateList(string index, string pageSize)
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
            List<Osiris.Model.Coordinate> list = bll.GetCoordinateList(size, pageIndex, "", out count);

            StringBuilder sb = new StringBuilder();
            foreach (Osiris.Model.Coordinate p in list)
            {
                sb.Append("<tr><td>");
                sb.Append(p.Id);
                sb.Append("</td><td>");
                sb.Append(p.Eare);
                sb.Append("</td><td>");
                sb.Append(string.IsNullOrEmpty(p.LogoName) ? "" : StringHelper.ClipString(p.LogoName, 10));
                sb.Append("</td><td>");
                sb.Append(p.Lon);
                sb.Append("</td><td>");
                sb.Append(p.Lat);
                sb.Append("</td><td>");
                sb.Append(p.CreateTime.ToString());
                sb.Append("</td><td>");
                sb.Append(p.Creator);
                sb.Append("</td><td>");
                sb.Append("<div class=\"table-fun table-option\"><a href='/MapManager/CoorEdit/" + p.Id + "'>修改</a><a href='/MapManager/Delete/" + p.Id + "'>删除</a></div>");
                sb.Append("</td></tr>");
            }
            str = sb.ToString();
            return str;
        }

        public ActionResult CoorEdit(int id = 0)
        {
            Coordinate dev = new Coordinate();
            dev.Id = id;
            if (id != 0)
            {
                dev = bll.GetModel(id);
            }
            return View(dev);
        }
        [HttpPost]
        public ActionResult CoorEdit(Coordinate d)
        {
            
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

            return Redirect("/MapManager/Coordinate");
        }


        public ActionResult Delete(int id)
        {
            bool flag = bll.Delete(id);
            return Redirect("/MapManager/Coordinate");
        }

        [HttpPost]
        public JsonResult Exists(string eare)
        {
            bool flag = bll.Exists(eare);
            return Json(new { result = flag == true ? 1 : 0 });
        }
    }
}
