using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace BulkSMS.Data
{
    public class Messaging:ISend
    {
        public static string textMessage = "Dear Customer, your debt on date: " + DateTime.Today.ToShortDateString() +
               " to our company is {amount} dolars and we would appriciate if you could pay it in fue days. Thanks in advance";

        public void SendEmail(DataTable dt, EmailConfig emailConfig)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Timeout = 30000;
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                BodyBuilder builder = new BodyBuilder();

                MimeMessage mail = new MimeMessage();
                mail.Subject = emailConfig.Subject;

                client.Connect(emailConfig.ServerSMTP, emailConfig.Port, emailConfig.Ssl);
                client.Authenticate(emailConfig.FromEmail, emailConfig.Password);

                foreach (DataRow row in dt.Rows)
                {
                    builder.HtmlBody = EnterAmountOfDebth(row["Debt"].ToString());
                    mail.Body = builder.ToMessageBody();
                    emailConfig.ToEmail = row["Email"].ToString();
                    mail.From.Add(new MailboxAddress(emailConfig.FromEmail));
                    mail.To.Add(new MailboxAddress(emailConfig.ToEmail));
                    client.Send(mail);
                }

                client.Disconnect(true);

                MessageBox.Show("Successfully sent");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SendSMS(DataTable dt, ProviderConfig providerConfig)
        {
            try
            {
                foreach (DataRow row in dt.Rows)
                {

                    providerConfig.Numbers = dt.Columns["Telephone"].ToString();
                    //"38267011132"; // in a comma seperated list
                    //068 ne radi 067, 069 radi
                    providerConfig.Message = EnterAmountOfDebth(row["debt"].ToString());
                      // string sender = "Cistoca HN";
                      // string message = "";
                       String url = "https://api.txtlocal.com/send/?apikey=" + providerConfig.ApiKey 
                            + "&numbers=" + providerConfig.Numbers + "&message=" + providerConfig.Message 
                            + "&sender=" + providerConfig.Sender;

                       StreamWriter myWriter = null;
                       HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

                       objRequest.Method = "POST";
                       objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
                       objRequest.ContentType = "application/x-www-form-urlencoded";
                       try
                       {
                           myWriter = new StreamWriter(objRequest.GetRequestStream());
                           myWriter.Write(url);
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show(null, "Error is " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       finally
                       {
                           myWriter.Close();
                       }

                       HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                       using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                       {
                           var result = sr.ReadToEnd();
                           sr.Close();
                       }        
                }

                MessageBox.Show("Messages successfully sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SendWhatsAppMessage(WhatsAppConfig whatsAppConfig)
        {
            WhatsApp whatsApp = new WhatsApp(whatsAppConfig.Phone, whatsAppConfig.Password,
                whatsAppConfig.Nickname,false,false);
            whatsApp.OnConnectSuccess += () =>
            {
                MessageBox.Show("Connected to whatsapp...");
                whatsApp.OnLoginSuccess += (phoneNumber, data) =>
                {
                    whatsApp.SendMessage(whatsAppConfig.Phone, whatsAppConfig.Message);
                    MessageBox.Show("Message Sent...");
                };

                whatsApp.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("Login failed: {0}",data);
                };

                whatsApp.Login();
            };
            whatsApp.OnConnectFailed += (ex) =>
            {
                MessageBox.Show("Connected Failed...");
            };

            whatsApp.Connect();
        }

        private string EnterAmountOfDebth(string i)
        {
            string text = "";
            string amount = "{amount}";
            if (textMessage.Contains(amount))
            {
                text = textMessage.Replace("{amount}", i);
            }
            return text;
        }
    }
}
