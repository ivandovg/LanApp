namespace LanApp9_1
{
    partial class MainFormFtp
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
            this.edAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.cbEnableSsl = new System.Windows.Forms.CheckBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edLogin = new System.Windows.Forms.TextBox();
            this.edPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grConnection
            // 
            this.grConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grConnection.Controls.Add(this.edPassword);
            this.grConnection.Controls.Add(this.label3);
            this.grConnection.Controls.Add(this.edLogin);
            this.grConnection.Controls.Add(this.label2);
            this.grConnection.Controls.Add(this.cbEnableSsl);
            this.grConnection.Controls.Add(this.btnGetFiles);
            this.grConnection.Controls.Add(this.edAddress);
            this.grConnection.Controls.Add(this.label1);
            this.grConnection.Location = new System.Drawing.Point(12, 12);
            this.grConnection.Name = "grConnection";
            this.grConnection.Size = new System.Drawing.Size(570, 86);
            this.grConnection.TabIndex = 3;
            this.grConnection.TabStop = false;
            this.grConnection.Text = "Connection Info";
            // 
            // edAddress
            // 
            this.edAddress.Location = new System.Drawing.Point(77, 25);
            this.edAddress.Name = "edAddress";
            this.edAddress.Size = new System.Drawing.Size(406, 20);
            this.edAddress.TabIndex = 4;
            this.edAddress.Text = "ftp://ftp.intel.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(489, 23);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(75, 23);
            this.btnGetFiles.TabIndex = 5;
            this.btnGetFiles.Text = "Get files";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // cbEnableSsl
            // 
            this.cbEnableSsl.AutoSize = true;
            this.cbEnableSsl.Location = new System.Drawing.Point(21, 53);
            this.cbEnableSsl.Name = "cbEnableSsl";
            this.cbEnableSsl.Size = new System.Drawing.Size(82, 17);
            this.cbEnableSsl.TabIndex = 6;
            this.cbEnableSsl.Text = "Enable SSL";
            this.cbEnableSsl.UseVisualStyleBackColor = true;
            // 
            // lbFiles
            // 
            this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(12, 111);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(570, 329);
            this.lbFiles.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login";
            // 
            // edLogin
            // 
            this.edLogin.Location = new System.Drawing.Point(168, 51);
            this.edLogin.Name = "edLogin";
            this.edLogin.Size = new System.Drawing.Size(100, 20);
            this.edLogin.TabIndex = 8;
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(357, 51);
            this.edPassword.Name = "edPassword";
            this.edPassword.Size = new System.Drawing.Size(100, 20);
            this.edPassword.TabIndex = 10;
            this.edPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // MainFormFtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 457);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.grConnection);
            this.Name = "MainFormFtp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Test Client";
            this.grConnection.ResumeLayout(false);
            this.grConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grConnection;
        private System.Windows.Forms.TextBox edPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbEnableSsl;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.TextBox edAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFiles;
    }
}

