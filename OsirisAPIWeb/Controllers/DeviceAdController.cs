using OsirisAPIWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Osiris.Tools;

namespace OsirisAPIWeb.Controllers
{
    /// <summary>
    /// 设备广告相关接口
    /// </summary>
    public class DeviceAdController : ApiController
    {
        /// <summary>
        /// 获取广告 {"username":"","deviceid":"","actiontype":"all/last/current"}
        /// </summary>
        /// <param name="m">request对象</param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]  
        [System.Web.Http.HttpPost]
        public HttpResponseMessage Post([FromBody]RequestObject m)
        {
            StringBuilder strJson = new StringBuilder();
            strJson.Append("{\"code\":200,");
            strJson.Append("\"msg\":\"");
            Osiris.BLL.DeviceAd bll = new Osiris.BLL.DeviceAd();
            string returnValue;
            DataSet ds = null;
            string actionType = m.actiontype.ToLower();
            if (actionType.Equals("all"))
                ds = bll.UserAllAd(m.username, m.deviceid, out returnValue);
            else if (actionType.Equals("current"))
                ds = bll.UserCurrentAd(m.deviceid, out returnValue);
            else
            {
                ds = bll.UserAllLast(m.username, m.deviceid, out returnValue);
            }
            switch (returnValue)
            {
                case "0": strJson.Append("success"); break;
                case "1": strJson.Append("终端未绑定"); break;
                case "2": strJson.Append("用户不存在"); break;
                case "3": strJson.Append("当前用户未上传广告"); break;
                default: strJson.Append("未知错误"); break;
            }
            strJson.Append("\",");

            strJson.Append("\"playload\":{");
            switch (actionType) {
                case "all":
                    strJson.Append("\"ads\":[");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            strJson.Append("{");
                            strJson.Append(" \"id\":\"" + dr[0] + "\",");
                            strJson.Append(" \"type\":\"" + dr[1] + "\",");
                            strJson.Append(" \"text\":\"" + dr[2] + "\",");
                            strJson.Append(" \"url\":\"" + dr[3] + "\",");
                            strJson.Append(" \"thumbUrl\":\"" + dr[4] + "\"");
                            strJson.Append("},");
                        }
                        strJson.Remove(strJson.Length - 1, 1);
                    }
                    strJson.Append("]}}");                     
                break;
                case "current":
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        { 
                            strJson.Append("\"adCmd\":{");
                            strJson.Append("\"ad\":{");
                            strJson.Append(" \"id\":\"" + dr[0] + "\",");
                            strJson.Append(" \"type\":\"" + dr[1] + "\",");
                            strJson.Append(" \"text\":\"" + dr[2] + "\",");
                            strJson.Append(" \"url\":\"" + dr[3] + "\",");
                            strJson.Append(" \"thumbUrl\":\"" + dr[4] + "\""); 
                            strJson.Append("},");
                            strJson.Append(" \"repeatCount\":\"" + dr[5] + "\",");
                            strJson.Append(" \"activeStartTime\":" + Commons.DateTimeToUnixTimestamp(Convert.ToDateTime(dr[7])) + ",");
                            strJson.Append(" \"activeEndTime\":" + Commons.DateTimeToUnixTimestamp(Convert.ToDateTime(dr[8])) + "");
                            strJson.Append("},");
                            strJson.Append("\"user\":{");
                            strJson.Append(" \"username\":\"" + dr[13] + "\",");
                            strJson.Append(" \"headImage\":\"" + dr[14] + "\"");
                            strJson.Append("}");
                        } 
                    }
                    strJson.Append("}}"); 
                break;

        }
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(strJson.ToString(), Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }
    }
}
