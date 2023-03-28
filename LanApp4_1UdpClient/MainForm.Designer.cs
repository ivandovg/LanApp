namespace LanApp4_1UdpClient
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grSendMessage = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.lsMessages = new System.Windows.Forms.ListBox();
            this.grConnection = new System.Windows.Forms.GroupBox();
            this.edRemoteAddress = new System.Windows.Forms.TextBox();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edLocalPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grSendMessage.SuspendLayout();
            this.grConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLocalPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(152, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(287, 123);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(108, 23);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(23, 123);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grSendMessage
            // 
            this.grSendMessage.Controls.Add(this.btnSend);
            this.grSendMessage.Controls.Add(this.edMessage);
            this.grSendMessage.Enabled = false;
            this.grSendMessage.Location = new System.Drawing.Point(12, 399);
            this.grSendMessage.Name = "grSendMessage";
            this.grSendMessage.Size = new System.Drawing.Size(389, 57);
            this.grSendMessage.TabIndex = 10;
            this.grSendMessage.TabStop = false;
            this.grSendMessage.Text = "Send Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(275, 17);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(11, 19);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(258, 20);
            this.edMessage.TabIndex = 5;
            // 
            // lsMessages
            // 
            this.lsMessages.FormattingEnabled = true;
            this.lsMessages.Location = new System.Drawing.Point(12, 149);
            this.lsMessages.Name = "lsMessages";
            this.lsMessages.Size = new System.Drawing.Size(389, 238);
            this.lsMessages.TabIndex = 9;
            // 
            // grConnection
            // 
            this.grConnection.Controls.Add(this.edLocalPort);
            this.grConnection.Controls.Add(this.label1);
            this.grConnection.Controls.Add(this.edRemoteAddress);
            this.grConnection.Controls.Add(this.edRemotePort);
            this.grConnection.Controls.Add(this.label3);
            this.grConnection.Controls.Add(this.label2);
            this.grConnection.Location = new System.Drawing.Point(12, 12);
            this.grConnection.Name = "grConnection";
            this.grConnection.Size = new System.Drawing.Size(389, 105);
            this.grConnection.TabIndex = 6;
            this.grConnection.TabStop = false;
            this.grConnection.Text = "Connection info";
            // 
            // edRemoteAddress
            // 
            this.edRemoteAddress.Location = new System.Drawing.Point(128, 16);
            this.edRemoteAddress.Name = "edRemoteAddress";
            this.edRemoteAddress.Size = new System.Drawing.Size(234, 20);
            this.edRemoteAddress.TabIndex = 0;
            this.edRemoteAddress.Text = "127.0.0.1";
            // 
            // edRemotePort
            // 
            this.edRemotePort.Location = new System.Drawing.Point(128, 44);
            this.edRemotePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edRemotePort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edRemotePort.Name = "edRemotePort";
            this.edRemotePort.Size = new System.Drawing.Size(120, 20);
            this.edRemotePort.TabIndex = 1;
            this.edRemotePort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remote Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remote Port";
            // 
            // edLocalPort
            // 
            this.edLocalPort.Location = new System.Drawing.Point(128, 72);
            this.edLocalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edLocalPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edLocalPort.Name = "edLocalPort";
            this.edLocalPort.Size = new System.Drawing.Size(120, 20);
            this.edLocalPort.TabIndex = 6;
            this.edLocalPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Local Port";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 465);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.grSendMessage);
            this.Controls.Add(this.lsMessages);
            this.Controls.Add(this.grConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test UDP Client";
            this.grSendMessage.ResumeLayout(false);
            this.grSendMessage.PerformLayout();
            this.grConnection.ResumeLayout(false);
            this.grConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLocalPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grSendMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.ListBox lsMessages;
        private System.Windows.Forms.GroupBox grConnection;
        private System.Windows.Forms.NumericUpDown edLocalPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edRemoteAddress;
        private System.Windows.Forms.NumericUpDown edRemotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

