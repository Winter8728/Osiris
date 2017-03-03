using System;

using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Osiris.CloudWeb.App_Start
{
    public class CheckLogin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session != null)
            {
                if (filterContext.HttpContext.Session.IsNewSession)
                {
                    var sessionCookie = filterContext.HttpContext.Request.Headers["Cookie"];
                    if (HttpContext.Current.Session["UserName"] == null)
                    {
                        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "LoginOut" }));
                    }
                    if ((sessionCookie != null) && (sessionCookie.IndexOf("ASP.NET_SessionId", StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "LoginOut" }));
                    }
                }
                else
                {
                    if (HttpContext.Current.Session["UserName"] == null)
                    {
                        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "LoginOut" }));
                    }
                }
            }
        }
    }
}