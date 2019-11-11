using BulkSMS.Data;
using BulkSMS.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSMS
{
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
            FormDesign.SetColor(this);
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var import = new ImportForm(new CustomerRepository(new Connection()));
            import.Show();
        }

        private void getCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customers = new CustomerForm(new CustomerRepository(new Connection()));
            customers.Show();
        }

        private void sendSMSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sms = new SmsForm(new CustomerRepository(new Connection()),new Messaging());
            sms.Show();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var email = new EmailForm(new CustomerRepository(new Connection()),new Messaging());
            email.Show();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var email = new WhatsAppForm(new CustomerRepository(new Connection()), new Messaging());
            email.Show();
        }
    }
}
