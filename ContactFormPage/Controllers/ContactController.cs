using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ContactFormPage.Models;
using ContactFormPage.Utilities;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ContactFormPage.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult MessageList()
        {
            using (var db = new MessageContext())
            {
                ViewBag.Messages = db.Messages.ToList<SavedMessage>();
            }

            return View();
        }

        [HttpPost]
        public HttpResponseMessage Submit(Contact PostData)
        {
            // Save our model
            using (var db = new MessageContext())
            {
                db.Messages.Add(new SavedMessage
                {
                    FirstName = PostData.FirstName,
                    LastName = PostData.LastName,
                    Email = PostData.Email,
                    Phone = PostData.Phone,
                    Subject = PostData.Subject,
                    Body = PostData.Message
                });
                db.SaveChanges();
            }

            // Send our email
            MailUtilities.LoginMail("mailtestwessel@gmail.com" , "J!qHvpQ~j8`;<MuF", "ContactBot");

            StringBuilder MailBuilder = new StringBuilder();
            MailBuilder.Append($"Name: {PostData.FirstName} {PostData.LastName}<br>");
            MailBuilder.Append($"Email: {PostData.Email}<br>");
            MailBuilder.Append($"Telephone number:{PostData.Phone}<br>");
            MailBuilder.Append($"onderwerp: {PostData.Subject}<br>");
            MailBuilder.Append($"<pre>{PostData.Message}</pre>");

            MailUtilities.SendMail("markdehaan@gmail.com", $"Message from {PostData.FirstName} {PostData.LastName}", MailBuilder.ToString()); 

            var response = new HttpResponseMessage(HttpStatusCode.Created);
            Response.Redirect("/Contact/thankyou");
            return response;

            
        }
    }
}
