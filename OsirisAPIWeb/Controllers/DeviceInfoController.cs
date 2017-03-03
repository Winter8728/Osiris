using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using OsirisAPIWeb.Models;
using System.Data;
using Osiris.Tools;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace OsirisAPIWeb.Controllers
{
    public class DeviceInfoController : ApiController
    {
        /// <summary>
        /// get 构造方法
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// get 接口
        /// </summary>
        /// <param name="id">id内容</param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 控制设置
        /// </summary>
        /// <param name="value">传的value</param>
        public HttpResponseMessage ControlDevice([FromBody]RequestUpdateObject obj )
        {
            StringBuilder strJson = new StringBuilder();
            strJson.Append("{\"code\":200,");
            strJson.Append(" \"msg\":\"");
            if (obj == null)
            {
                strJson.Append(" Post请求错误 \",");
                strJson.Append(" \"payload\":{}");
            }
            else
            {

                //第一步,修改deviceinfo
                Osiris.Model.DeviceInfo model = new Osiris.Model.DeviceInfo();
                Osiris.BLL.DeviceInfo bll = new Osiris.BLL.DeviceInfo();
                try
                {
                    model.DeviceId = obj.deviceid;
                    model.Brightness = obj.deviceinfo.lightness;
                    model.Temperature = obj.deviceinfo.temperature;
                    model.Powerwaste = obj.deviceinfo.powerWaste;
                    model.ViewModel = obj.deviceinfo.displayMode;

                    model.Lon = obj.latlng.lng;
                    model.Lat = obj.latlng.lat;
                    model.UpdateTime = DateTime.Now;
                    model.Gyroscope = obj.deviceinfo.gyroscope;

                    
                    bll.Update(model);
                }
                catch (Exception ex)
                {
                    strJson.Append(" 数据更新失败 \",");
                    strJson.Append(" \"payload\":{}");
                    strJson.Append("}");
                    HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(strJson.ToString(), Encoding.GetEncoding("UTF-8"), "application/json") };
                    return result; 
                }
                //第二步,根据坐标计算地区并返回广告  
                string BaiduAK = System.Configuration.ConfigurationManager.AppSettings["BaiduAK"];
                string lng =obj.latlng.lat + "," + obj.latlng.lng; 
                string url = string.Format("http://api.map.baidu.com/geocoder/v2/?output=json&ak={0}&location={1}", BaiduAK, lng);
                string returnStr = HttpHelper.GetResponseString(HttpHelper.CreateGetHttpResponse(url, null));
                JObject jo = (JObject)JsonConvert.DeserializeObject(returnStr);
                string district = jo["result"]["addressComponent"]["district"].ToString();

                if (string.IsNullOrEmpty(district))
                {
                    strJson.Append(" 未获取到地区数据,请检查GPS数据! \",");
                    strJson.Append(" \"payload\":{}");
                    strJson.Append("}");
                    HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(strJson.ToString(), Encoding.GetEncoding("UTF-8"), "application/json") };
                    return result; 
                }

		//第三步,根据地区读取广告.
                Osiris.BLL.DeviceAd bllad = new Osiris.BLL.DeviceAd();
                string returnValue;
                DataSet ds = bllad.GetAdByEareTime(obj.deviceid, district,out returnValue);
                DataRow dr = null;
                try
                {
                    dr = ds.Tables[0].Rows[0];
                    model = bll.GetModel(obj.deviceid);
                }
                catch (Exception ex)
                {
                    strJson.Append(" 未设置广告 \",");
                    strJson.Append(" \"payload\":{}");
                    strJson.Append("}");
                    HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(strJson.ToString(), Encoding.GetEncoding("UTF-8"), "application/json") };
                    return result; 
                }
                strJson.Append("success\",");
                strJson.Append(" \"payload\":{\"deviceCmds\":{ ");
                strJson.Append(string.Format("\"lightness\":\"{0}\",",model.Brightness));
                strJson.Append(string.Format("\"on\":\"{0}\",", model.Switch));
                strJson.Append(string.Format("\"displayMode\":\"{0}\",", model.ViewModel));
                strJson.Append(string.Format("\"lock\":\"{0}\"", model.IsLock));
                strJson.Append(" },\"adCmd\":{\"ad\":{ ");
                strJson.Append(string.Format("\"id\":\"{0}\",", dr[0]));
                strJson.Append(string.Format("\"type\":\"{0}\",", dr[1]));
                strJson.Append(string.Format("\"text\":\"{0}\",", dr[2]));
                strJson.Append(string.Format("\"url\":\"{0}\",", dr[3]));
                strJson.Append(string.Format("\"thumbUrl\":\"{0}\"", dr[4]));
                strJson.Append(" },");
                strJson.Append(string.Format("\"repeatCount\":\"{0}\",", dr[5]));
                strJson.Append(string.Format("\"activeStartTime\":{0},", Commons.DateTimeToUnixTimestamp( Convert.ToDateTime( dr[7]))));
                strJson.Append(string.Format("\"activeEndTime\":{0}", Commons.DateTimeToUnixTimestamp(Convert.ToDateTime(dr[8]))));
                strJson.Append(" }}");
            } 
            strJson.Append("}");
            HttpResponseMessage results = new HttpResponseMessage { Content = new StringContent(strJson.ToString(), Encoding.GetEncoding("UTF-8"), "application/json") };
            return results;  
        }

        /// <summary>  
        /// GET请求与获取结果  
        /// </summary>  
        private string HttpGet(string postDataStr)
        {
           string BaiduAK = System.Configuration.ConfigurationManager.AppSettings["BaiduAK"];
           string url = string.Format("http://api.map.baidu.com/geocoder/v2/?output=json&ak={0}&location={1}", BaiduAK, postDataStr);

           HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }  

        /// <summary>
        /// put 接口
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// delete 删除接口
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}