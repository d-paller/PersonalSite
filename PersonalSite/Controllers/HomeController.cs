using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using PersonalSite.Models;
using System.Text;
using Microsoft.Office;
using Microsoft.Office.Interop.Word;
using System.IO;
//using 

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

        public PartialViewResult PdfResumePartial()
        {
            return PartialView("PdfResumePartial");
        }

        public ActionResult Contact()
        {
                return View();
        }
            

        public ActionResult GetResumeWord()
        {
            return File("~/ExtraFiles/Paller_David_Resume.docx", "application/docx", ("Resume-Paller.docx"));
        }
        public ActionResult GetResumePdf()
        {
            return File("~/ExtraFiles/Paller_David_Resume.pdf", "application/pdf", ("Resume-Paller.pdf"));
        }

        [HttpPost]
        public ActionResult Contact(ContactModel c)
        {
            if (ModelState.IsValid)  //All fields are valid
            {
                try
                {
                    if (Models.Email.sendEmail(c) == true)
                    {
                        return View("Contact/MessageSent");
                    }
                }
                catch (Exception) // If an excpetion is thrown, send the error view
                {
                    return View("Contact/ContactError");
                //return View("Contact/MessageSent");  //For testing
                }
            }
            //if the form is not valid, return the same (current) view
            return View();

        }// Contact 

        


            } // Controller
} // Namespace