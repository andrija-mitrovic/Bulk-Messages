using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSMS.Design
{
    public class FormDesign
    {
        private static Color col1 = Color.FromArgb(41, 57, 85); //  boja podloge 
        private static Color col2 = Color.FromArgb(255, 255, 255); // bijela
        private static Color col3 = Color.FromArgb(0, 0, 0); // crna
        private static Color col4 = Color.FromArgb(153, 31, 72); // boja aktivnih dugmadi
        private static Color col5 = Color.FromArgb(255, 0, 85); // boja prelaz preko aktivnog dugmeta

        public static void SetColor(Control cont)
        {
            if (cont is MenuStrip)
            {
                var menuStrip = (MenuStrip)cont;
                menuStrip.BackColor = col1;
                menuStrip.ForeColor = col2;
                menuStrip.Renderer = new MenuStripRenderer();
                foreach (ToolStripMenuItem mainMenu in menuStrip.Items)
                {
                    string gmime = mainMenu.Name;
                    SetToolStripItems(mainMenu.DropDownItems, gmime);
                }
            }
            if (cont is Form)
            {
                var form = (Form)cont;
                form.BackColor = col1;
                form.KeyPreview = true;
            }
            if (cont is Label)
            {
                cont.BackColor = col1;
                cont.ForeColor = col2;
            }
            if (cont is TextBox)
            {
                var textbox = (TextBox)cont;
                textbox.BorderStyle = BorderStyle.FixedSingle;
                textbox.BackColor = col2;
                textbox.ForeColor = col3;
                textbox.EnabledChanged += TexBox_EnabledChanged;
            }
            if (cont is GroupBox)
            {
                var groupbox = (GroupBox)cont;
                groupbox.BackColor = col1;
                groupbox.ForeColor = col2;
            }
            if (cont is TabPage)
            {
                var TabPage = (TabPage)cont;
                TabPage.BackColor = col1;
                TabPage.ForeColor = col2;
                TabPage.BorderStyle = BorderStyle.FixedSingle;
            }

            if (cont is ComboBox)
            {
                var ComboBox = (ComboBox)cont;
                ComboBox.BackColor = col2;
                ComboBox.ForeColor = col3;
            }

            if (cont is Button)
            {
                Button button = (Button)cont;
                button.BackColor = col1;
                button.ForeColor = col2;
                button.FlatAppearance.MouseOverBackColor = col5;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.EnabledChanged += Button_EnabledChanged;
                if (button.Enabled)
                {
                    button.BackColor = col4;
                    button.ForeColor = col2;
                }          
            }   
            if (cont is DataGridView)
            {
                var DataG = (DataGridView)cont;
                DataG.ForeColor = col3;
                DataG.AllowUserToResizeColumns = false;
                DataG.AllowUserToResizeRows = false;
                DataG.BorderStyle = BorderStyle.Fixed3D;
                DataG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                DataG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                DataG.BackgroundColor = col2;
                DataG.DefaultCellStyle.SelectionBackColor = col4;
                DataG.DefaultCellStyle.SelectionForeColor = col2;
                DataG.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                DataG.RowTemplate.Height = 25;
                DataG.DefaultCellStyle.Font = new Font("Tahoma", 10);
                DataG.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
                DataG.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                DataG.ColumnHeadersHeight = 35;
                DataG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 31, 72);
                DataG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                DataG.EnableHeadersVisualStyles = false;
            }

            foreach (Control contn in cont.Controls)
                SetColor(contn);
        }

        private static void TexBox_EnabledChanged(System.Object sender, System.EventArgs e)
        {
            ((TextBox)sender).BackColor = col2;
            ((TextBox)sender).ForeColor = col3;
        }
        private static void Button_EnabledChanged(System.Object sender, System.EventArgs e)
        {
            if (((Button)sender).Enabled)
            {
                ((Button)sender).BackColor = col4;
                ((Button)sender).ForeColor = col2;
            }
            else
            {
                ((Button)sender).BackColor = col1;
                ((Button)sender).ForeColor = col2;
            }
        }
        private class MenuStripRenderer : ToolStripProfessionalRenderer
        {
            public MenuStripRenderer() : base(new MenuStripColors()) { }
        }
        private class MenuStripColors : ProfessionalColorTable
        {
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(41, 57, 85); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(41, 57, 85); }
            }
        }

        private static void SetToolStripItems(ToolStripItemCollection dropDownItems, string gmimed)
        {
            foreach (object obj in dropDownItems)
            {
                Type tobj = obj.GetType();
                if (tobj.Equals(typeof(ToolStripMenuItem)))
                {
                    ToolStripMenuItem subMenu = (ToolStripMenuItem)obj;

                    if (subMenu.HasDropDownItems) 
                    {
                        subMenu.BackColor = col1;
                        subMenu.ForeColor = col2;
                        SetToolStripItems(subMenu.DropDownItems, gmimed);
                    }
                    else
                    {
                        ToolStripMenuItem menu = (ToolStripMenuItem)obj;
                        menu.BackColor = col1;
                        menu.ForeColor = col2;
                    }
                }
                if (tobj.Equals(typeof(ToolStripSeparator)))
                {
                    ToolStripSeparator tss = (ToolStripSeparator)obj;
                    tss.BackColor = col1;
                    tss.ForeColor = col2;
                }

            }
        }
    }
}
