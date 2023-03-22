namespace LanApp2_1Udp
{
    partial class MainFormUdp
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
            this.grConnection = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.edlocalPort = new System.Windows.Forms.NumericUpDown();
            this.edRemoteAddress = new System.Windows.Forms.TextBox();
            this.btnStartReceive = new System.Windows.Forms.Button();
            this.lsMessages = new System.Windows.Forms.ListBox();
            this.grSendMessage = new System.Windows.Forms.GroupBox();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edlocalPort)).BeginInit();
            this.grSendMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grConnection
            // 
            this.grConnection.Controls.Add(this.btnStartReceive);
            this.grConnection.Controls.Add(this.edRemoteAddress);
            this.grConnection.Controls.Add(this.edlocalPort);
            this.grConnection.Controls.Add(this.edRemotePort);
            this.grConnection.Controls.Add(this.label3);
            this.grConnection.Controls.Add(this.label2);
            this.grConnection.Controls.Add(this.label1);
            this.grConnection.Location = new System.Drawing.Point(12, 12);
            this.grConnection.Name = "grConnection";
            this.grConnection.Size = new System.Drawing.Size(389, 106);
            this.grConnection.TabIndex = 0;
            this.grConnection.TabStop = false;
            this.grConnection.Text = "Connection info";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Port";
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
            // edlocalPort
            // 
            this.edlocalPort.Location = new System.Drawing.Point(128, 69);
            this.edlocalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edlocalPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edlocalPort.Name = "edlocalPort";
            this.edlocalPort.Size = new System.Drawing.Size(120, 20);
            this.edlocalPort.TabIndex = 2;
            this.edlocalPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // edRemoteAddress
            // 
            this.edRemoteAddress.Location = new System.Drawing.Point(128, 16);
            this.edRemoteAddress.Name = "edRemoteAddress";
            this.edRemoteAddress.Size = new System.Drawing.Size(234, 20);
            this.edRemoteAddress.TabIndex = 0;
            this.edRemoteAddress.Text = "127.0.0.1";
            // 
            // btnStartReceive
            // 
            this.btnStartReceive.Location = new System.Drawing.Point(254, 66);
            this.btnStartReceive.Name = "btnStartReceive";
            this.btnStartReceive.Size = new System.Drawing.Size(108, 23);
            this.btnStartReceive.TabIndex = 3;
            this.btnStartReceive.Text = "Start Receive";
            this.btnStartReceive.UseVisualStyleBackColor = true;
            this.btnStartReceive.Click += new System.EventHandler(this.btnStartReceive_Click);
            // 
            // lsMessages
            // 
            this.lsMessages.FormattingEnabled = true;
            this.lsMessages.Location = new System.Drawing.Point(12, 123);
            this.lsMessages.Name = "lsMessages";
            this.lsMessages.Size = new System.Drawing.Size(389, 264);
            this.lsMessages.TabIndex = 1;
            // 
            // grSendMessage
            // 
            this.grSendMessage.Controls.Add(this.btnSend);
            this.grSendMessage.Controls.Add(this.edMessage);
            this.grSendMessage.Enabled = false;
            this.grSendMessage.Location = new System.Drawing.Point(12, 399);
            this.grSendMessage.Name = "grSendMessage";
            this.grSendMessage.Size = new System.Drawing.Size(389, 57);
            this.grSendMessage.TabIndex = 2;
            this.grSendMessage.TabStop = false;
            this.grSendMessage.Text = "Send Message";
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(11, 19);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(258, 20);
            this.edMessage.TabIndex = 5;
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
            // MainFormUdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 468);
            this.Controls.Add(this.grSendMessage);
            this.Controls.Add(this.lsMessages);
            this.Controls.Add(this.grConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFormUdp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP Test Application";
            this.grConnection.ResumeLayout(false);
            this.grConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edlocalPort)).EndInit();
            this.grSendMessage.ResumeLayout(false);
            this.grSendMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grConnection;
        private System.Windows.Forms.Button btnStartReceive;
        private System.Windows.Forms.TextBox edRemoteAddress;
        private System.Windows.Forms.NumericUpDown edlocalPort;
        private System.Windows.Forms.NumericUpDown edRemotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsMessages;
        private System.Windows.Forms.GroupBox grSendMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox edMessage;
    }
}

