using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkSMS.Data
{
    public class EmailConfig
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string FromEmail { get; set; }
        public string ToEmail { get; set; }
        public string ServerSMTP { get; set; }
        public int Port { get; set; }
        public bool Ssl { get; set; }
        public string Password { get; set; }
    }
}
