namespace MailHelper
{
    public class YandexMailHelper : SmtpMailHelper
    {
        public YandexMailHelper()
        {
            Host = Host ?? "smtp.yandex.com";
        }
    }
}