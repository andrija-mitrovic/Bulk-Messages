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
    public partial class CustomerForm : Form
    {
        private ICustomerRepository _repo;
        private DataTable _dt;
        private AutoSize _form_resize;

        public CustomerForm(ICustomerRepository repo)
        {
            InitializeComponent();
            _repo = repo;
            _form_resize = new AutoSize(this);

            _delete.Click += deleteClick;
            _report.Click += reportClick;
            _excel.Click += excelClick;
            this.Load += formLoad;

            FormDesign.SetColor(this);
        }
        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
        private void formLoad(object sender, EventArgs e)
        {
            this.Resize += _Resize;

            _dt = _repo.GetCustomers();
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

        private void excelClick(object sender, EventArgs e)
        {
            ExcelDoc excel = new ExcelDoc();
            excel.CreateExcelDocument(_dt);
        }

        private void reportClick(object sender, EventArgs e)
        {
            //_dt.WriteXmlSchema("dscustomers.xsd");
            Form F = new ReportForm("customers.rpt", _dt);
            F.Show();
        }

        private void deleteClick(object sender, EventArgs e)
        {
            if (gridView.RowCount > 0)
            {
                int selectedIndex = gridView.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    _repo.DeleteCustomer(Convert.ToInt32(gridView.Rows[selectedIndex].Cells["Id"].Value));
                }
                gridView.DataSource = _repo.GetCustomers();
            }
        }
    }
}
