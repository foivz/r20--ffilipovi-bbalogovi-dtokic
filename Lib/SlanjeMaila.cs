using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class SlanjeMaila
    {
        public static void PosaljiMail(string email, string header, string content)
        {
            SmtpClient klijent = new SmtpClient("smtp.gmail.com", 25);
            NetworkCredential podaci = new NetworkCredential("pi.projekt.031@gmail.com", "foiPI1234");
            MailMessage poruka = new MailMessage();
            poruka.From = new MailAddress("pi.projekt.031@gmail.com");
            poruka.To.Add(email);
            poruka.Subject = header;
            poruka.Body = content;
            klijent.Credentials = podaci;
            klijent.EnableSsl = true;
            klijent.Send(poruka);
        }
    }
}
