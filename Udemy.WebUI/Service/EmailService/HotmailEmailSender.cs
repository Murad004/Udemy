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
            var client = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_userName, _password),
                EnableSsl = _enableSSL,
                UseDefaultCredentials=false
            };


            return client.SendMailAsync(
                  new MailMessage(this._userName, email, subject, htmlMessage)
                  {
                      IsBodyHtml=true
                  }
                );
        }
    }
}
