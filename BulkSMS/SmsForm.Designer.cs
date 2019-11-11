namespace BulkSMS
{
    partial class SmsForm
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
            this.sendSMS = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this._apiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._sender = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messageText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendSMS
            // 
            this.sendSMS.Location = new System.Drawing.Point(41, 686);
            this.sendSMS.Name = "sendSMS";
            this.sendSMS.Size = new System.Drawing.Size(139, 38);
            this.sendSMS.TabIndex = 1;
            this.sendSMS.Text = "Send";
            this.sendSMS.UseVisualStyleBackColor = true;
            // 
            // gridView
            // 
            this.gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(40, 199);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(1216, 462);
            this.gridView.TabIndex = 11;
            // 
            // _apiKey
            // 
            this._apiKey.Location = new System.Drawing.Point(106, 43);
            this._apiKey.Name = "_apiKey";
            this._apiKey.Size = new System.Drawing.Size(401, 22);
            this._apiKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "API KEY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sender:";
            // 
            // _sender
            // 
            this._sender.Location = new System.Drawing.Point(106, 75);
            this._sender.Name = "_sender";
            this._sender.Size = new System.Drawing.Size(401, 22);
            this._sender.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._apiKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._sender);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messaging";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(44, 34);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(440, 107);
            this.messageText.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageText);
            this.groupBox2.Location = new System.Drawing.Point(731, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 168);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compose";
            // 
            // SmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendSMS);
            this.Controls.Add(this.gridView);
            this.Name = "SmsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Sending";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sendSMS;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox _apiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _sender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}