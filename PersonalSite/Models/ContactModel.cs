using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class ContactModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please provide your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please provide your last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide your email address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You forgot your message... -_-")]
        public string Message { get; set; }
    }
}