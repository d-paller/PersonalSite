using System;
using System.Net.Mail;
using System.Text;
using System.Web.Mvc;
using PersonalSite.Controllers;
using PersonalSite.Models;

namespace PersonalSite.Models
{
    
    public class Email 
    {
        public static bool sendEmail(ContactModel c) { // WHy does this have to be static?
              
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
            // There is currently no password included and will therfore always have an error.
            smtp.Credentials = new System.Net.NetworkCredential("dpaller94@gmail.com", "Password");

            // Build the email body
            sb.Append("Name: " + c.FirstName + " " + c.LastName + Environment.NewLine);
            sb.Append("Email: " + c.Email + Environment.NewLine);
            sb.Append("Message: " + c.Message);

            msg.Body = sb.ToString();

            // Send message
            smtp.Send(msg);
            msg.Dispose();

            return true;
        } // Contact

    }
}