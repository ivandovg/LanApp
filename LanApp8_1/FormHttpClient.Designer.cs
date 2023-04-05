namespace LanApp8_1
{
    partial class FormHttpClient
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edHttpContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHttpHeaders = new System.Windows.Forms.ListBox();
            this.btnHttpLoad = new System.Windows.Forms.Button();
            this.edHttpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.edHttpContent);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbHttpHeaders);
            this.groupBox2.Controls.Add(this.btnHttpLoad);
            this.groupBox2.Controls.Add(this.edHttpAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 426);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTTP Test";
            // 
            // edHttpContent
            // 
            this.edHttpContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edHttpContent.Location = new System.Drawing.Point(6, 249);
            this.edHttpContent.Multiline = true;
            this.edHttpContent.Name = "edHttpContent";
            this.edHttpContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edHttpContent.Size = new System.Drawing.Size(491, 171);
            this.edHttpContent.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Headers";
            // 
            // lbHttpHeaders
            // 
            this.lbHttpHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHttpHeaders.FormattingEnabled = true;
            this.lbHttpHeaders.Location = new System.Drawing.Point(6, 78);
            this.lbHttpHeaders.Name = "lbHttpHeaders";
            this.lbHttpHeaders.Size = new System.Drawing.Size(491, 134);
            this.lbHttpHeaders.TabIndex = 9;
            // 
            // btnHttpLoad
            // 
            this.btnHttpLoad.Location = new System.Drawing.Point(402, 22);
            this.btnHttpLoad.Name = "btnHttpLoad";
            this.btnHttpLoad.Size = new System.Drawing.Size(75, 23);
            this.btnHttpLoad.TabIndex = 8;
            this.btnHttpLoad.Text = "Load";
            this.btnHttpLoad.UseVisualStyleBackColor = true;
            this.btnHttpLoad.Click += new System.EventHandler(this.btnHttpLoad_Click);
            // 
            // edHttpAddress
            // 
            this.edHttpAddress.Location = new System.Drawing.Point(65, 24);
            this.edHttpAddress.Name = "edHttpAddress";
            this.edHttpAddress.Size = new System.Drawing.Size(331, 20);
            this.edHttpAddress.TabIndex = 7;
            this.edHttpAddress.Text = "https://www.google.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address";
            // 
            // FormHttpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormHttpClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HttpClient test";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edHttpContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbHttpHeaders;
        private System.Windows.Forms.Button btnHttpLoad;
        private System.Windows.Forms.TextBox edHttpAddress;
        private System.Windows.Forms.Label label2;
    }
}

