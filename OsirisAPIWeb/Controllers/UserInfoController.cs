using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http; 
using OsirisAPIWeb.Models;

namespace OsirisAPIWeb.Controllers
{
    /// <summary>
    /// 用户登录相关
    /// </summary>
    public class UserInfoController : ApiController
    { 
        /// <summary>
        /// 用户登录 {"username":"admin","password":""} *密码为32位md5
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]  
        [System.Web.Http.HttpPost]
        public HttpResponseMessage Login([FromBody]RequestObject requestObject)
        {
            StringBuilder strJson = new StringBuilder();
            strJson.Append("{\"code\":200,");
            strJson.Append(" \"msg\":\"");   
          
            Osiris.BLL.UserInfo userbll = new Osiris.BLL.UserInfo();
            string msg = userbll.CheckUserInfo(requestObject.username, requestObject.password);

            strJson.Append(msg);
            strJson.Append("\"}");
            //ResponseObject robj = new ResponseObject()
            //{
            //    code = 200,
            //    msg = msg
            //};
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(strJson.ToString(), Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;

           // return robj;
        }
    }
}
