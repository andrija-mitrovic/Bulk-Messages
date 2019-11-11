namespace BulkSMS
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this._excel = new System.Windows.Forms.Button();
            this._report = new System.Windows.Forms.Button();
            this._delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // gridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.Location = new System.Drawing.Point(35, 85);
            this.gridView.Name = "gridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(1212, 573);
            this.gridView.TabIndex = 1;
            // 
            // _excel
            // 
            this._excel.Location = new System.Drawing.Point(320, 681);
            this._excel.Name = "_excel";
            this._excel.Size = new System.Drawing.Size(119, 35);
            this._excel.TabIndex = 7;
            this._excel.Text = "Export Excel";
            this._excel.UseVisualStyleBackColor = true;
            // 
            // _report
            // 
            this._report.Location = new System.Drawing.Point(179, 681);
            this._report.Name = "_report";
            this._report.Size = new System.Drawing.Size(119, 35);
            this._report.TabIndex = 8;
            this._report.Text = "Report";
            this._report.UseVisualStyleBackColor = true;
            // 
            // _delete
            // 
            this._delete.Location = new System.Drawing.Point(35, 681);
            this._delete.Name = "_delete";
            this._delete.Size = new System.Drawing.Size(119, 35);
            this._delete.TabIndex = 9;
            this._delete.Text = "Delete";
            this._delete.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 740);
            this.Controls.Add(this._delete);
            this.Controls.Add(this._report);
            this.Controls.Add(this._excel);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Form";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button _excel;
        private System.Windows.Forms.Button _report;
        private System.Windows.Forms.Button _delete;
    }
}