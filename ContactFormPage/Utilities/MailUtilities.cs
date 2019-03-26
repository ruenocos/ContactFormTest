using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ContactFormPage.Utilities
{
    public class MailUtilities
    {
        public static SmtpClient client;
        public static MailAddress from;

        public static void LoginMail(string email, string password, string displayName = "", int port = 587, string host = "smtp.gmail.com")
        {
            client = new SmtpClient();
            client.Credentials = new NetworkCredential(email, password);
            client.Host = host;
            client.Port = port;
            client.EnableSsl = true;

            from = new MailAddress(email, displayName, Encoding.UTF8);
        }

        public static void SendMail(string to, string subject, string body)
        {
            MailMessage mail = new MailMessage();

            mail.To.Add(to);
            mail.From = from;

            mail.Subject = subject;
            mail.SubjectEncoding = Encoding.UTF8;

            mail.Body = body;
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;

            client.Send(mail);
        }

        internal static void SendMail(string v1, string v2, Func<string> toString)
        {
            throw new NotImplementedException();
        }
    }
}
