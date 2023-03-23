namespace LanApp3_2TcpClient
{
    partial class MainFormTcpClient
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
            this.grSendMessage = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.lsMessages = new System.Windows.Forms.ListBox();
            this.grConnection = new System.Windows.Forms.GroupBox();
            this.edRemoteAddress = new System.Windows.Forms.TextBox();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grSendMessage.SuspendLayout();
            this.grConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            this.SuspendLayout();
            // 
            // grSendMessage
            // 
            this.grSendMessage.Controls.Add(this.btnSend);
            this.grSendMessage.Controls.Add(this.edMessage);
            this.grSendMessage.Enabled = false;
            this.grSendMessage.Location = new System.Drawing.Point(12, 399);
            this.grSendMessage.Name = "grSendMessage";
            this.grSendMessage.Size = new System.Drawing.Size(389, 57);
            this.grSendMessage.TabIndex = 4;
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
            this.lsMessages.Location = new System.Drawing.Point(12, 136);
            this.lsMessages.Name = "lsMessages";
            this.lsMessages.Size = new System.Drawing.Size(389, 251);
            this.lsMessages.TabIndex = 3;
            // 
            // grConnection
            // 
            this.grConnection.Controls.Add(this.edRemoteAddress);
            this.grConnection.Controls.Add(this.edRemotePort);
            this.grConnection.Controls.Add(this.label3);
            this.grConnection.Controls.Add(this.label2);
            this.grConnection.Location = new System.Drawing.Point(12, 12);
            this.grConnection.Name = "grConnection";
            this.grConnection.Size = new System.Drawing.Size(389, 79);
            this.grConnection.TabIndex = 0;
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
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(23, 97);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(287, 97);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(108, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(152, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainFormTcpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 467);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.grSendMessage);
            this.Controls.Add(this.lsMessages);
            this.Controls.Add(this.grConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFormTcpClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test TCP Client Connection";
            this.grSendMessage.ResumeLayout(false);
            this.grSendMessage.PerformLayout();
            this.grConnection.ResumeLayout(false);
            this.grConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grSendMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.ListBox lsMessages;
        private System.Windows.Forms.GroupBox grConnection;
        private System.Windows.Forms.TextBox edRemoteAddress;
        private System.Windows.Forms.NumericUpDown edRemotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClear;
    }
}

