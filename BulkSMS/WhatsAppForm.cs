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
using WhatsAppApi;

namespace BulkSMS
{
    public partial class WhatsAppForm : Form
    {
        private ICustomerRepository _repo;
        private ISend _send;
        private DataTable _dt;
        private AutoSize _form_resize;
        public WhatsAppForm(ICustomerRepository repo, ISend send)
        {
            InitializeComponent();
            FormDesign.SetColor(this);
            _form_resize = new AutoSize(this);

            _repo = repo;
            _send = send;
            _dt = _repo.GetCustomers();

            this.Load += FormLoad;
            this.send.Click += SendClick;
        }
        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
        private void SendClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var whatsAppConfig = new WhatsAppConfig
            {
                Nickname = nickname.Text,
                Phone = nickname.Text,
                Password = nickname.Text
            };

            _send.SendWhatsAppMessage(whatsAppConfig);
            this.Close();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            this.Resize += _Resize;
            Cursor.Current = Cursors.WaitCursor;
            messageText.Text = Messaging.textMessage;

            nickname.Validating += Valid.TextValidating;
            phone.Validating += Valid.TextValidating;
            password.Validating += Valid.TextValidating;

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
            gridView.Columns[9].Width = 50;
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
