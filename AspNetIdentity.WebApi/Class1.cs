using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetIdentity.WebApi
{

    //public class EmailService : IIdentityMessageService
    //{
    //    public async Task SendAsync(IdentityMessage message)
    //    {
    //        await configSendSmtp(message);
    //        //await configSendGridasync(message);
    //    }
    //    private async Task configSendSmtp(IdentityMessage message)
    //    {
    //        using (System.Net.Mail.MailMessage MailSetup = new System.Net.Mail.MailMessage())
    //        {
    //            NetworkCredential loginInfo = new NetworkCredential("tuemail", "tupass");
    //            MailSetup.Subject = message.Subject;
    //            MailSetup.To.Add(message.Destination);
    //            MailSetup.From = new System.Net.Mail.MailAddress("tramites@valledupar.gov.co", "Avanzar es Posible!!!");
    //            MailSetup.Body = message.Body;
    //            using (System.Net.Mail.SmtpClient SMTP = new System.Net.Mail.SmtpClient("smtp.live.com"))
    //            {
    //                SMTP.Port = 587;
    //                SMTP.EnableSsl = true;
    //                SMTP.Credentials = loginInfo;
    //                await SMTP.SendMailAsync(MailSetup);
    //            }
    //        }


        //}
    }
 