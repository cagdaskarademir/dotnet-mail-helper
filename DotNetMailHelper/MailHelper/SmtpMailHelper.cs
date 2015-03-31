using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MailHelper
{
    public class SmtpMailHelper : IMailHelper
    {
        public SmtpMailHelper()
        {
            Host = string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("SmtpHost"))
                ? null
                : ConfigurationManager.AppSettings.Get("SmtpHost");

            Port = ConfigurationManager.AppSettings.Get("SmtpPort") == null
                ? 587
                : int.Parse(ConfigurationManager.AppSettings.Get("SmtpPort"));

            EnableSsl = ConfigurationManager.AppSettings.Get("SmtpIsEnableSsl") == null || bool.Parse(ConfigurationManager.AppSettings.Get("SmtpIsEnableSsl"));

            UserName = string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("SmtpUserName"))
                ? null
                : ConfigurationManager.AppSettings.Get("SmtpUserName");

            Password = string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("SmtpPassword"))
                ? null
                : ConfigurationManager.AppSettings.Get("SmtpPassword");

            From = string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("MailFrom"))
                ? null
                : new MailAddress(ConfigurationManager.AppSettings.Get("MailFrom"));

            IsBodyHtml = string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("MailIsBodyHtml")) ||
                         bool.Parse(ConfigurationManager.AppSettings.Get("IsBodyHtml"));
        }

        public string Host { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public MailAddress From { get; set; }
        public List<MailAddress> To { get; set; }
        public List<MailAddress> Cc { get; set; }
        public List<MailAddress> Bcc { get; set; }
        public bool IsBodyHtml { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void AddTo(string emailAdress, string displayName)
        {
            if (To != null)
                To.Add(new MailAddress(emailAdress, displayName));
            else
                To = new List<MailAddress>
                {
                    new MailAddress(emailAdress, displayName)
                };
        }

        public void AddCc(string emailAdress, string displayName)
        {
            if (Cc != null)
                Cc.Add(new MailAddress(emailAdress, displayName));
            else
                Cc = new List<MailAddress>
                {
                    new MailAddress(emailAdress, displayName)
                };
        }

        public void AddBcc(string emailAdress, string displayName)
        {
            if (Bcc != null)
                Bcc.Add(new MailAddress(emailAdress, displayName));
            else
                Bcc = new List<MailAddress>
                {
                    new MailAddress(emailAdress, displayName)
                };
        }

        public virtual void Send()
        {
            try
            {
                var mail = new MailMessage
                {
                    From = From,
                    IsBodyHtml = IsBodyHtml,
                    Subject = Subject,
                    BodyEncoding = Encoding.UTF8,
                    Body = Body
                };

                if (To != null)
                    To.ForEach(address => mail.To.Add(address));

                var smtpClient = new SmtpClient
                {
                    Host = Host,
                    Port = Port,
                    EnableSsl = EnableSsl,
                    Credentials = new NetworkCredential(UserName, Password)
                };

                smtpClient.Send(mail);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}