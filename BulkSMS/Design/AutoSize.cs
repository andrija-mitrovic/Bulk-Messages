using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSMS.Design
{
    public class AutoSize
    {
        private List<Rectangle> _arr_control_storage;
        private bool showRowHeader = false;
        private Form form;
        private List<int> control_font_size;
        private List<int> datagrid_columns_size;
        private SizeF _formSize;

        public AutoSize(Form _form)
        {
            form = _form;
            _formSize = _form.ClientSize;
            _arr_control_storage = new List<Rectangle>();
            control_font_size = new List<int>();
            datagrid_columns_size = new List<int>();
        }
        public void _get_initial_size()
        {
            var _controls = _get_all_controls(form);
            foreach(Control control in _controls)
            {
                _arr_control_storage.Add(control.Bounds);
                control_font_size.Add((int)(control.Font.Height));
            }
        }
        private List<int> GetColumnWidth(DataGridView dgv,List<int> datagrid_columns_size)
        {
            for(int i = 0; i<dgv.ColumnCount; i++)
            {
                datagrid_columns_size.Add(dgv.Columns[i].Width);
            }
            return datagrid_columns_size;
        }
        public void _resize()
        {
            if (form.ClientSize.Width > 0 || form.ClientSize.Height > 0)
            {
                double _form_ratio_width = (double)form.ClientSize.Width / (double)_formSize.Width;
                double _form_ratio_height = (double)form.ClientSize.Height / (double)_formSize.Height;
                var _controls = _get_all_controls(form);
                int _pos = 0;


                foreach (Control control in _controls)
                {
                    if (control.GetType() == typeof(DataGridView))
                    {
                        // _dgv_Column_Adjust(((DataGridView)control), showRowHeader);
                        datagrid_columns_size = GetColumnWidth((DataGridView)control, datagrid_columns_size);
                    }
                    //    _pos += 1;
                    Size _controlSize = new Size((int)(_arr_control_storage[_pos].Width * _form_ratio_width),
                        (int)(_arr_control_storage[_pos].Height * _form_ratio_height));

                    Point _controlposition = new Point((int)
                    (_arr_control_storage[_pos].X * _form_ratio_width), (int)(_arr_control_storage[_pos].Y * _form_ratio_height));

                    //Control autoSize
                    control.Bounds = new Rectangle(_controlposition, _controlSize);

                    //Datagrid autoSize
                    if (control.GetType() == typeof(DataGridView))
                        _dgv_Column_Adjust(((DataGridView)control), showRowHeader, _form_ratio_width);

                    //Font autoSize
                    control.Font = new Font(form.Font.FontFamily,
                     (float)(((Convert.ToDouble(control_font_size[_pos]) * _form_ratio_width) / 3.6) +
                      ((Convert.ToDouble(control_font_size[_pos]) * _form_ratio_height) / 3.6)));
                    _pos += 1;
                }
            }
        }
        private void _dgv_Column_Adjust(DataGridView dgv, bool _showRowHeader, double _form_ratio_width)
        {
            dgv.ScrollBars = ScrollBars.None;
            int VScrollBar = 0;
            if (dgv.RowCount != 0)
            {
                if (dgv.RowCount * dgv.Rows[0].Height > dgv.Height)
                {
                   // VScrollBar = 17;
                    dgv.ScrollBars = ScrollBars.Vertical;
                    dgv.FirstDisplayedScrollingRowIndex = dgv.RowCount - 1;
                }

                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    if (dgv.Dock == DockStyle.Fill)
                        dgv.Columns[i].Width = Convert.ToInt32(datagrid_columns_size[i] * _form_ratio_width);
                    else
                    {
                        if (i == (dgv.ColumnCount - 1))
                            dgv.Columns[i].Width = Convert.ToInt32(datagrid_columns_size[i] * _form_ratio_width) - VScrollBar;
                        else
                            dgv.Columns[i].Width = Convert.ToInt32(datagrid_columns_size[i] * _form_ratio_width);
                    }
                }
            }
        }
        private static IEnumerable<Control> _get_all_controls(Control c)
        {
            return c.Controls.Cast<Control>().SelectMany(item =>
                _get_all_controls(item)).Concat(c.Controls.Cast<Control>())
                .Where(control => control.Name != string.Empty);
        }

        public void Resize(object sender, EventArgs e)
        {
            this._resize();
        }
    }
}
