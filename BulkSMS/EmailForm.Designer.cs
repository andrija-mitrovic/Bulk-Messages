namespace BulkSMS
{
    partial class EmailForm
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
            this.subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(219, 23);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(366, 22);
            this.subject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(219, 59);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(366, 125);
            this.messageText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email body (HTML):";
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
            this.gridView.Location = new System.Drawing.Point(36, 233);
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
            this.gridView.Size = new System.Drawing.Size(1212, 438);
            this.gridView.TabIndex = 4;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(36, 697);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(119, 35);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Server IP/Name:";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(809, 26);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(255, 22);
            this.server.TabIndex = 2;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(809, 61);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(255, 22);
            this.port.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(809, 98);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(255, 22);
            this.user.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "User:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(808, 134);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(255, 22);
            this.password.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password:";
            // 
            // ssl
            // 
            this.ssl.AutoSize = true;
            this.ssl.Location = new System.Drawing.Point(1079, 28);
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(56, 21);
            this.ssl.TabIndex = 3;
            this.ssl.Text = "SSL";
            this.ssl.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ssl);
            this.groupBox1.Controls.Add(this.messageText);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.server);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1212, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messaging";
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 763);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.gridView);
            this.Name = "EmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sending Email";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ssl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}