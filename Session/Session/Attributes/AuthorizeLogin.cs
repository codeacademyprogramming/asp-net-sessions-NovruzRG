using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session.Attributes
{
    public class AuthorizeLogin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["login"] == null)
            {
                filterContext.Result = new RedirectResult("/Authorize/SignUp");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}