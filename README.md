# .Net Mail Helper

## Projelerde kullanabileceğiniz basit ve işlevsel bir mail sınıfıdır. 

Yandex, Google ve Diğer Smtp mail sunucuları ile uyumludur. 

Eğer kendi mail sınıfınızı yazmak isterseniz; sınıfınızı IMailHelper implement etmeniz yeterli olacaktır. AddTo,AddCc,AddBcc ve Send metodlarını override edip kodları özelleştirebilirsiniz.

Test edilmiştir. 

http://www.cagdaskarademir.com

http://tr.aspnet.solutions/

http://blog.cagdaskarademir.com/


Özellikler
=========

Yandex Mail Kullanmak İçin: 

```C#
    <add key="MailFrom" value="username@domain.com" />
    <add key="SmtpUserName" value="username@domain.com" />
    <add key="SmtpPassword" value="password" />
```    
Alanlarını girmeniz yeterli olacaktır. 

Gmail Kullanmak İçin:

```C#
    <add key="MailFrom" value="username@domain.com" />
    <add key="SmtpUserName" value="username@domain.com" />
    <add key="SmtpPassword" value="password" />
```     
Alanlarını girmeniz yeterli olacaktır.

Eğer kendi smtp ayarlarınızı kullanacaksanız:
```C#
    <add key="MailFrom" value="username@domain.com" />
    <add key="SmtpUserName" value="username@domain.com" />
    <add key="SmtpPassword" value="password" />
    
    <add key="SmtpHost" value="smtp.mailserver.com" />
    <add key="SmtpPort" value="587" />
    <add key="SmtpIsEnableSsl" value="false" />
    <add key="MailIsBodyHtml" value="true" />
```    
Alanlarını girerek özelleştirebilirsiniz. 

Örnek Kodlar Yandex : 
=========
```C#
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
``` 

Örnek Kodlar Gmail : 
=========
```C#
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
```

Örnek Kodlar Smtp : 
=========
```C#
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
```
