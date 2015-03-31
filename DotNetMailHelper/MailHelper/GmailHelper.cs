using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MailHelper
{
    public class GmailHelper : SmtpMailHelper
    {
        public GmailHelper()
        {
            Host = Host ?? "smtp.gmail.com";
        }

        public override void Send()
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

                if (Cc != null)
                    Cc.ForEach(address => mail.To.Add(address));

                if (Bcc != null)
                    Bcc.ForEach(address => mail.To.Add(address));

                var smtpClient = new SmtpClient
                {
                    Host = Host,
                    Port = Port,
                    EnableSsl = EnableSsl,
                    Credentials = new NetworkCredential(UserName, Password),
                    DeliveryMethod = SmtpDeliveryMethod.Network
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