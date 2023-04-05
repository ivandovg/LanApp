namespace LanApp8_2Smtp
{
    partial class MainFormSendMail
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
            this.edServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edSubject = new System.Windows.Forms.TextBox();
            this.cbIsHtml = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).BeginInit();
            this.SuspendLayout();
            // 
            // edServer
            // 
            this.edServer.Location = new System.Drawing.Point(87, 16);
            this.edServer.Name = "edServer";
            this.edServer.Size = new System.Drawing.Size(174, 20);
            this.edServer.TabIndex = 0;
            this.edServer.Text = "smtp.gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // edPort
            // 
            this.edPort.Location = new System.Drawing.Point(372, 16);
            this.edPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edPort.Name = "edPort";
            this.edPort.Size = new System.Drawing.Size(120, 20);
            this.edPort.TabIndex = 2;
            this.edPort.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // edLogin
            // 
            this.edLogin.Location = new System.Drawing.Point(87, 56);
            this.edLogin.Name = "edLogin";
            this.edLogin.Size = new System.Drawing.Size(174, 20);
            this.edLogin.TabIndex = 5;
            this.edLogin.Text = "user1@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(372, 56);
            this.edPassword.Name = "edPassword";
            this.edPassword.PasswordChar = '*';
            this.edPassword.Size = new System.Drawing.Size(165, 20);
            this.edPassword.TabIndex = 7;
            this.edPassword.Text = "1234";
            this.edPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "To";
            // 
            // edTo
            // 
            this.edTo.Location = new System.Drawing.Point(87, 95);
            this.edTo.Name = "edTo";
            this.edTo.Size = new System.Drawing.Size(174, 20);
            this.edTo.TabIndex = 9;
            this.edTo.Text = "user2@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subject";
            // 
            // edSubject
            // 
            this.edSubject.Location = new System.Drawing.Point(372, 95);
            this.edSubject.Name = "edSubject";
            this.edSubject.Size = new System.Drawing.Size(165, 20);
            this.edSubject.TabIndex = 11;
            this.edSubject.Text = "theme";
            // 
            // cbIsHtml
            // 
            this.cbIsHtml.AutoSize = true;
            this.cbIsHtml.Location = new System.Drawing.Point(12, 131);
            this.cbIsHtml.Name = "cbIsHtml";
            this.cbIsHtml.Size = new System.Drawing.Size(67, 17);
            this.cbIsHtml.TabIndex = 13;
            this.cbIsHtml.Text = "Is HTML";
            this.cbIsHtml.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Content";
            // 
            // edContent
            // 
            this.edContent.Location = new System.Drawing.Point(12, 191);
            this.edContent.Multiline = true;
            this.edContent.Name = "edContent";
            this.edContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edContent.Size = new System.Drawing.Size(534, 132);
            this.edContent.TabIndex = 14;
            this.edContent.Text = "test message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(462, 329);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainFormSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 361);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edContent);
            this.Controls.Add(this.cbIsHtml);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edServer);
            this.Name = "MainFormSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Mail Sender";
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edSubject;
        private System.Windows.Forms.CheckBox cbIsHtml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edContent;
        private System.Windows.Forms.Button btnSend;
    }
}

