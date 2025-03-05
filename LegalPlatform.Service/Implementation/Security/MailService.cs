using System.Net;
using System.Net.Mail;
using GraduationProjectStore.Service.Abstraction.Security;
using GraduationProjectStore.Service.Implementation.Security.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace GraduationProjectStore.Service.Implementation.Security
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _config; 
        public MailService(IConfiguration config)
        {
            this._config = config;
        }

        public async ValueTask<string> SendMail(string email, string subject, string message)
        {
            // for use get u must install microsoft.extensions.binder
            var smtpOptions = _config.GetSection("SMTP").Get<SMTPOptions>();

            if (email == null || subject == null || message == null)
                return "Invalid Data Message";

            if (!(int.TryParse(smtpOptions.Port, out int PortNumber)))
                return "Invalid Port Number";

            using (var client = new SmtpClient(smtpOptions.Server, PortNumber))
            {
                client.Credentials = new NetworkCredential(smtpOptions.Username, smtpOptions.Password);
                client.EnableSsl = true;

                var mailMessage = new MailMessage()
                {
                    From = new MailAddress(smtpOptions.Username),
                    Body = message,
                    IsBodyHtml = true,
                    Subject = subject
                };

                mailMessage.To.Add(email);
                await client.SendMailAsync(mailMessage);
            }

            return "Successfully";
        }
    }
}
