using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnologyCourseSystem.Models
{
    public class SendEmailViewModel
    {
        [Display(Name = "Your Email Address")]
        [Required(ErrorMessage = "Please enter an email address.")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter the contents")]
        public string Contents { get; set; }
    }
}