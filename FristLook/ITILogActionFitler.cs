using System.IO;
using System.Web.Mvc;

namespace FristLook
{
    public class ItiLogActionFitlerAttribute :ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null)
            {
                File.AppendAllText(filterContext.HttpContext.Server.MapPath("~/Log.txt"), filterContext.Exception.ToString());
            }
        }
    }
}