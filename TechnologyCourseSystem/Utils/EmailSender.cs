using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TechnologyCourseSystem.Utils
{
    public class EmailSender
    {
        private const String API_KEY = "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";

        //public void Send(String email, String subject, String contents)
        //{
        //    var client = new SendGridClient(API_KEY);
        //    var from = new EmailAddress("zising0127@gmail.com", "Training Tomorrow's Tech");
        //    var to = new EmailAddress("zising0127@163.com", "");
        //    var plainTextContent = contents;
        //    var htmlContent = "<p>" + "Email: " + email + "</p>" + "<p>" + "Question: " + contents + "</p>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var attachment = System.Web.HttpContext.Current.Server.MapPath(@"~\Files\Logo.png");
        //    var bytes = File.ReadAllBytes(attachment);
        //    var file = Convert.ToBase64String(bytes);
        //    msg.AddAttachment("Logo.png", file);
        //    var response = client.SendEmailAsync(msg);
        //}

        public void Send(String email, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("zising0127@gmail.com", "Training Tomorrow's Tech"),
                Subject = subject,
                HtmlContent = "<p>" + "Email: " + email + "</p>" + "<p>" + "Question: " + contents + "</p>",
                Personalizations = new List<Personalization>
                {
                     new Personalization
                     {
                          Tos = new List<EmailAddress>
                          {
                               new EmailAddress("zising0127@163.com", ""),
                               new EmailAddress("zlim0045@student.monash.edu", "")
                          }
                     }
                 }
            };
            var attachment = System.Web.HttpContext.Current.Server.MapPath(@"~\Files\Logo.png");
            var bytes = File.ReadAllBytes(attachment);
            var file = Convert.ToBase64String(bytes);
            msg.AddAttachment("Logo.png", file);
            var response = client.SendEmailAsync(msg);
        }
    }
}