using System.Net;
using System.Net.Mail;
namespace SendEmailWithGoogleSMTP
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromMail = "shruthinaligeshi0201@gmail.com";
            string fromPassword = "tmfpwmjmmeuoomxz";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Greetings";
            message.Body = "Good Afternoon";
            message.To.Add(new MailAddress("sdawood@ariqt.com"));
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }
    }
}


//ethereal