using System.Collections.Generic;
using System.Net.Mail;

namespace MailHelper
{
    public interface IBaseHelper
    {
        string Host { get; set; }
        int Port { get; set; }
        bool EnableSsl { get; set; }
        MailAddress From { get; set; }
        List<MailAddress> To { get; set; }
        List<MailAddress> Cc { get; set; }
        List<MailAddress> Bcc { get; set; }
        bool IsBodyHtml { get; set; }
        string Subject { get; set; }
        string Body { get; set; }

        string UserName { get; set; }
        string Password { get; set; }
    }
}