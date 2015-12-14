using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;

namespace DrawNet.Core.Utilities
{
    public class Emailer
    {
        public string SmtpHostName { get; set; } = "smtp.mailgun.org";
        public int SmtpPort { get; set; } = 587;
        public string SmtpUsername { get; set; } = "support@mg.deitytechnology.com";
        public string SmtpPassword { get; set; } = "Dr@wNet!";
        public string FromRecipient { get; set; } = Common.Email.SupportMailGun;
        public bool IsHtml { get; set; } = true;
        public bool EnableSsl { get; set; } = true;

        public bool SendEmail( string toRecipient, string subjectMessage, string bodyMessage )
        {
            MailMessage mail = new MailMessage(FromRecipient, toRecipient, subjectMessage, bodyMessage)
            {
                IsBodyHtml = IsHtml
            };

            var smtpClient = new SmtpClient(SmtpHostName, SmtpPort)
            {
                EnableSsl = EnableSsl,
                Credentials = new NetworkCredential(SmtpUsername, SmtpPassword),
            };

            try
            {
                smtpClient.Send( mail );
            }
            catch ( Exception e )
            {
                //Log error here
                return false;
            }

            return true;
        }
    }

    public class BetterMailMessage : MailMessage
    {
    }
}