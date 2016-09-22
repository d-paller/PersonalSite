using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalSite.Controllers
{
    public abstract class BaseController : Controller
    {
        // GET: Error
        protected ActionResult Http404(string errorMessage)
        {
            Response.StatusCode = 400;
            return View(errorMessage);
        }

        protected ActionResult Http500(string errorMessage)
        {
            Response.StatusCode = 500;
            return View(errorMessage);
        }
    }
}