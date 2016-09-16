using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }
            

        public ActionResult GetResume()
        {
            return File("~/ExtraFiles/Paller_David_Resume.docx", "application/docx", ("ResumePaller - " + 
                DateTime.Now.ToShortDateString()));
        }
    }
}