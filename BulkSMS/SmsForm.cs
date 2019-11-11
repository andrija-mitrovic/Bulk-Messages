using BulkSMS.Data;
using BulkSMS.Design;
using BulkSMS.Validation;
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

    public partial class SmsForm : Form
    {
        private ProviderConfig _config;
        private ICustomerRepository _repo;
        private ISend _send;
        private DataTable _dt;
        private AutoSize _form_resize;

        public SmsForm(ICustomerRepository repo,ISend send)
        {
            InitializeComponent();
            FormDesign.SetColor(this);
            _form_resize = new AutoSize(this);

            _repo = repo;
            _send = send;

            _apiKey.Validating += Valid.TextValidating;
            _sender.Validating += Valid.TextValidating;

            _dt = _repo.GetCustomers();
            _config = new ProviderConfig
            {
                ApiKey = _apiKey.Text,
                Sender = _sender.Text
            };
            this.Load += FormLoad;
            sendSMS.Click += senderClick;
        }
        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
        private void senderClick(object sender, EventArgs e)
        {
            Messaging.textMessage = this.messageText.Text;
            _send.SendSMS(_dt,_config);
            this.Close();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            this.Resize += _Resize;

            Cursor.Current = Cursors.WaitCursor;
            this.messageText.Text = Messaging.textMessage;

            gridView.DataSource = _dt;
            gridView.Columns[0].Width = 50;
            gridView.Columns[1].Width = 100;
            gridView.Columns[2].Width = 100;
            gridView.Columns[3].Width = 100;
            gridView.Columns[4].Width = 106;
            gridView.Columns[5].Width = 100;
            gridView.Columns[6].Width = 100;
            gridView.Columns[7].Width = 100;
            gridView.Columns[8].Width = 100;
            gridView.Columns[9].Width = 53;
            gridView.AllowUserToAddRows = false;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            _form_resize._get_initial_size();
            _form_resize._resize();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10)
                AutoValidate = AutoValidate.Disable;
            base.WndProc(ref m);
        }
    }
}
