using System.Net;
using System.Net.Mail;

namespace Udemy.WebUI.Service.EmailService
{
    public class HotmailEmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;

        public HotmailEmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            _userName = userName;
            _password = password;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient();

            client.Host = "smtp.office365.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("sadikhov377@gmail.com", "0775966907m");
            

            return client.SendMailAsync(
                  new MailMessage("sadikhov377@gmail.com", email, subject, htmlMessage)
                  {
                      IsBodyHtml=true
                  }
                );
        }
    }
}
