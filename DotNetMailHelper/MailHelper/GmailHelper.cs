namespace MailHelper
{
    public class GmailHelper : SmtpMailHelper
    {
        public GmailHelper()
        {
            Host = Host ?? "smtp.gmail.com";
        }
    }
}