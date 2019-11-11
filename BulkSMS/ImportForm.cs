using BulkSMS.Data;
using BulkSMS.Design;
using BulkSMS.Models;
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
    public partial class ImportForm : Form
    {
        private ICustomerRepository _repo;
        public ImportForm(ICustomerRepository repo)
        {
            InitializeComponent();
            _repo = repo;
            FormDesign.SetColor(this);

            this.KeyPreview = true;

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.firstName.Validating += Valid.TextValidating;
            this.lastName.Validating += Valid.TextValidating;
            this.gender.Validating += Valid.TextValidating;
            this.address.Validating += Valid.TextValidating;
            this.city.Validating += Valid.TextValidating;
            this.country.Validating += Valid.TextValidating;
            this.telephone.Validating += Valid.TextValidating;
            this.email.Validating += Valid.EmailValidation;
            this.debt.Validating += Valid.DecimalValidating;
            this.KeyUp += Valid._KeyUp;

            this._accept.Click += AcceptClick;
        }

        private void AcceptClick(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Gender = gender.Text,
                Address = address.Text,
                City = city.Text,
                Country = country.Text,
                Telephone = telephone.Text,
                Email = email.Text,
                Debt = Convert.ToInt32(debt.Text)
            };

            _repo.AddCustomer(customer);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) 
                AutoValidate = AutoValidate.Disable;
            base.WndProc(ref m);
        }
    }
}
