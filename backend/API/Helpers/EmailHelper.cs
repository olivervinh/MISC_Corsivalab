using System.Net;
using System.Net.Mail;

namespace API.Helpers
{
    public class EmailHelper
    {
        private static readonly string _sendEmailTo = "admin@corsivalab.com"; // default
        private static readonly string _sendEmailsFrom = "system@corsivalab.com";
        private static readonly string _sendEmailsFromPassword = "1qazxsw2#EDC";
        private static readonly string _smtpHost = "smtp.zoho.com";
        private static readonly int _smtpPort = 587;

        public static bool Send(string email, string subject, string message)
        {
            try
            {
                MailMessage mailMessage = new MailMessage()
                {
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true
                };
                // mailMessage.To.Add(email);
                mailMessage.To.Add(email + "," + _sendEmailTo);

                MailAddress mailAddress = new MailAddress("system@corsivalab.com");
                mailMessage.From = mailAddress;

                NetworkCredential networkCredentials = new NetworkCredential(_sendEmailsFrom, _sendEmailsFromPassword);
                SmtpClient mailClient = new SmtpClient(_smtpHost, _smtpPort)
                {
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = networkCredentials,
                };

                mailClient.Send(mailMessage);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}