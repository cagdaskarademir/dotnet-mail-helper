using MailHelper;

namespace TestConsoleMail
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // For Yandex Mail Server
            // App Config:  Must - MailFrom
            //              Must - SmtpUserName
            //              Must - SmtpPassword
            IMailHelper yandexMailHelper = new YandexMailHelper();
            yandexMailHelper.AddTo("username@domain.com", "Çağdaş KARADEMİR");
            yandexMailHelper.AddCc("username@domain.com", "Çağdaş KARADEMİR");
            yandexMailHelper.AddBcc("username@domain.com", "Çağdaş KARADEMİR");
            yandexMailHelper.Body =
                @"Quisque velit nisi, pretium ut lacinia in, elementum id enim. Vivamus suscipit tortor eget felis porttitor volutpat. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Donec sollicitudin molestie malesuada. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Donec sollicitudin molestie malesuada. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, auctor sit amet aliquam vel, ullamcorper sit amet ligula.";
            yandexMailHelper.Subject = "Check Email";
            yandexMailHelper.Send();

            // For Gmail Server
            // App Config:  Must - MailFrom
            //              Must - SmtpUserName
            //              Must - SmtpPassword
            IMailHelper gmailHelper = new GmailHelper();
            gmailHelper.AddTo("username@domain.com", "Çağdaş KARADEMİR");
            gmailHelper.AddCc("username@domain.com", "Çağdaş KARADEMİR");
            gmailHelper.AddBcc("username@domain.com", "Çağdaş KARADEMİR");
            gmailHelper.Body =
                @"Quisque velit nisi, pretium ut lacinia in, elementum id enim. Vivamus suscipit tortor eget felis porttitor volutpat. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Donec sollicitudin molestie malesuada. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Donec sollicitudin molestie malesuada. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, auctor sit amet aliquam vel, ullamcorper sit amet ligula.";
            gmailHelper.Subject = "Check Email";
            gmailHelper.Send();

            // For Any Smtp Server
            // App Config:  Must - MailFrom
            //              Must - SmtpUserName
            //              Must - SmtpPassword
            //              Must - SmtpHost
            //              Optional - If SmtpPort Is Not 587 - Ex : 25
            //              Optional - If SmtpIsEnableSsl Is Not true - Ex : false
            //              Optional - If MailIsBodyHtml Is Not true - Ex : false
            IMailHelper smtpMailHelper = new SmtpMailHelper();
            smtpMailHelper.AddTo("username@domain.com", "Çağdaş KARADEMİR");
            smtpMailHelper.AddCc("username@domain.com", "Çağdaş KARADEMİR");
            smtpMailHelper.AddBcc("username@domain.com", "Çağdaş KARADEMİR");
            smtpMailHelper.Body =
                @"Quisque velit nisi, pretium ut lacinia in, elementum id enim. Vivamus suscipit tortor eget felis porttitor volutpat. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Donec sollicitudin molestie malesuada. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Donec sollicitudin molestie malesuada. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, auctor sit amet aliquam vel, ullamcorper sit amet ligula.";
            smtpMailHelper.Subject = "Check Email";
            smtpMailHelper.Send();
        }
    }
}