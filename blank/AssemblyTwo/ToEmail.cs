using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace AssemblyTwo
{
    class ToEmail
    {
        internal void SendMail(string message)
        {
            Console.Write("Хотите ли получить посадочный талон на ваш e-mail? да/нет: ");
            string toMailRead = Console.ReadLine();
            if (toMailRead.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Введите e-mail: ");
                string mail = Console.ReadLine();
                MailAddress from = new MailAddress("kotekat73@gmail.com", "AlexandrAir");
                MailAddress to = new MailAddress(mail);
                MailMessage m = new MailMessage(from, to);
                m.Sender = from;
                m.Subject = "Посадочный талон";
                m.Body = $"<h2>{message}<h2>";
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 465);
                smtp.EnableSsl = true;
                smtp.Credentials = (ICredentialsByHost)new NetworkCredential("kotekat73@gmail.com", "21101989");
                //smtp.Send(m); // IOException: Unable to read data from the transport connection: The connection was closed
                Console.Clear();
            }
        }
    }
}
