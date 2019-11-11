namespace BulkSMS
{
    partial class WhatsAppForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messageText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nickname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.messageText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messaging";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(506, 39);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(366, 125);
            this.messageText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message:";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(34, 706);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(119, 35);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // gridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridView.Location = new System.Drawing.Point(34, 242);
            this.gridView.Name = "gridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(1212, 438);
            this.gridView.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(95, 74);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(255, 22);
            this.phone.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(95, 112);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(255, 22);
            this.password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(95, 39);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(255, 22);
            this.nickname.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nickname:";
            // 
            // WhatsAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 763);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.gridView);
            this.Name = "WhatsAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sending WhatsApp message";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label label4;
    }
}