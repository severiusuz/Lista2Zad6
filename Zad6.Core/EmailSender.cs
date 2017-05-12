using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Zad6.Core
{
    public class EmailSender
    {
        private const string Password = "xxx"
;
        public void SendMail(string recipient, string subject, string body, string attachmentPath = null)
        {
            SmtpClient mySmtpClient = new SmtpClient("smtp.gmail.com");

            mySmtpClient.UseDefaultCredentials = false;
            mySmtpClient.Credentials = new System.Net.NetworkCredential("quest.warrior.cancer@gmail.com", Password);
            mySmtpClient.Port = 587;
            mySmtpClient.EnableSsl = true;

            MailAddress from = new MailAddress("quest.warrior.cancer@gmail.com", "TestFromName");
            MailAddress to = new MailAddress(recipient);
            MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

            myMail.Subject = subject;
            myMail.SubjectEncoding = System.Text.Encoding.UTF8;

            myMail.Body = body;
            myMail.BodyEncoding = System.Text.Encoding.UTF8;
            myMail.IsBodyHtml = false;
            mySmtpClient.Send(myMail);
        }
    }
}
