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
            if (ModelState.IsValid)  //Al lfields are valid
            {
                try
                {
                    // Setup
                    System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    MailAddress from = new MailAddress(c.Email.ToString());
                    StringBuilder sb = new StringBuilder();

                    // Setup message details
                    msg.To.Add("dpaller94@gmail.com");
                    msg.Subject = "Contact Me";
                    msg.IsBodyHtml = false;

                    // Setup SMTP 
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new System.Net.NetworkCredential("dpaller94@gmail.com", "Password");

                    // Build the email body
                    sb.Append("Name: " + c.FirstName + " " + c.LastName + Environment.NewLine);
                    sb.Append("Email: " + c.Email + Environment.NewLine);
                    sb.Append("Message: " + c.Message);

                    msg.Body = sb.ToString();

                    // Send message
                    smtp.Send(msg);
                    msg.Dispose();

                    // Return the sucess view
                    return View("Contact/MessageSent");

                } catch (Exception) // If an excpetion is thrown, send the error view
                {
                    // return View("Contact/Error");
                    return View("Contact/MessageSent");  //For testing
                }
            }
            //if the form is not valid, return the same (current) view
            return View();
        } // Contact

        //public ActionResult err400()
        //{
        //    if ()
        //}

    } // Controller
} // Namespace