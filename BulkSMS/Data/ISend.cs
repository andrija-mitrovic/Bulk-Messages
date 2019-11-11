using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkSMS.Data
{
    public interface ISend
    {
        void SendSMS(DataTable dt, ProviderConfig smsConfig);
        void SendEmail(DataTable dt, EmailConfig emailConfig);
        void SendWhatsAppMessage(WhatsAppConfig whatsAppConfig);
    }
}
