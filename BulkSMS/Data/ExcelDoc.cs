using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSMS.Data
{
    public class ExcelDoc
    {
        private const int _fontSize = 8;
        private const string _fontName = "Tahoma";
        private string creationPath;
        public void CreateExcelDocument(DataTable dtexcel)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    creationPath = fbd.SelectedPath + "\\Customers-"
                + (new Random().Next(1, 100)).ToString() + ".XLSX";
                }
            }

            Cursor.Current = Cursors.Default;
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;
            workSheet.Name = "Customers";
            workSheet.Rows.Font.Name = _fontName;
            workSheet.Rows.Font.Size = _fontSize;

            workSheet.Cells[4, 1] = "Customers";

            int k = 6;
            int t = 1;
            workSheet.Cells[k, 1] = "Id";
            workSheet.Cells[k, 2] = "First Name";
            workSheet.Cells[k, 3] = "Last Name";
            workSheet.Cells[k, 4] = "Gender";
            workSheet.Cells[k, 5] = "Adress";
            workSheet.Cells[k, 6] = "City";
            workSheet.Cells[k, 7] = "Country";
            workSheet.Cells[k, 8] = "Telephone";
            workSheet.Cells[k, 9] = "Email";
            workSheet.Cells[k, 10] = "Debt";

            k = k + 1;
            for (var i = 0; i < dtexcel.Rows.Count; i++)
            {
                for (var j = 0; j < dtexcel.Columns.Count; j++)
                {
                    workSheet.Cells[k, t] = dtexcel.Rows[i][j];
                    t = t + 1;
                }
                k = k + 1;
                t = 1;
                workSheet.Columns.AutoFit();
            }

            try
            {
                workSheet.SaveAs(creationPath);
                excelApp.Quit();
                System.Diagnostics.Process.Start(creationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention!");
            }
        }
    }
}
