using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReportForm : Form
    {
        private ReportDocument _cizv;
        private string _cime;
        private DataTable _dt;
        private string[] _ipar;
        public ReportForm(string cime, DataTable dt)
        {
            InitializeComponent();

            _cime = cime;
            _dt = dt;
            _cizv = new ReportDocument();
            this.Load += cizvLoad;
        }
        public ReportForm(string cime, DataTable dt, string[] ipar)
            :this(cime,dt)
        {
            _ipar = ipar;
        }
        private void cizvLoad(object sender, EventArgs e)
        {
            try
            {
                _cizv.Load(_cime);
                _cizv.SetDataSource(_dt);

                if (_ipar != null)
                {
                    for (int i = 0; i < _ipar.Length; i++)
                    {
                        _cizv.SetParameterValue("p_p" + (i + 1).ToString(), _ipar[i]);
                    }
                }

                crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                crystalReportViewer.ReportSource = _cizv;
                crystalReportViewer.Zoom(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
