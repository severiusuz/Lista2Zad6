using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad6.Core;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            var to = "hubertmatan@gmail.com";
            var subject = "subject";
            var body = "body";

            var emailSender = new EmailSender();
            emailSender.SendMail(to, subject, body);
        }
    }
}
