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
            this.label1 = new System.Windows.Forms.Label();
            this.edDateQuery = new System.Windows.Forms.DateTimePicker();
            this.btnLoadCourseXml = new System.Windows.Forms.Button();
            this.btnSaveCourseXml = new System.Windows.Forms.Button();
            this.btnLoadCourseJson = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLoadCourseJson);
            this.groupBox2.Controls.Add(this.btnSaveCourseXml);
            this.groupBox2.Controls.Add(this.btnLoadCourseXml);
            this.groupBox2.Controls.Add(this.edDateQuery);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.edHttpContent);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbHttpHeaders);
            this.groupBox2.Controls.Add(this.btnHttpLoad);
            this.groupBox2.Controls.Add(this.edHttpAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 426);
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
            this.edHttpContent.Size = new System.Drawing.Size(551, 171);
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
            this.label3.Location = new System.Drawing.Point(14, 75);
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
            this.lbHttpHeaders.Location = new System.Drawing.Point(6, 91);
            this.lbHttpHeaders.Name = "lbHttpHeaders";
            this.lbHttpHeaders.Size = new System.Drawing.Size(551, 121);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Course UAH";
            // 
            // edDateQuery
            // 
            this.edDateQuery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edDateQuery.Location = new System.Drawing.Point(86, 50);
            this.edDateQuery.Name = "edDateQuery";
            this.edDateQuery.Size = new System.Drawing.Size(179, 20);
            this.edDateQuery.TabIndex = 15;
            this.edDateQuery.Value = new System.DateTime(2023, 4, 5, 0, 0, 0, 0);
            // 
            // btnLoadCourseXml
            // 
            this.btnLoadCourseXml.Location = new System.Drawing.Point(271, 47);
            this.btnLoadCourseXml.Name = "btnLoadCourseXml";
            this.btnLoadCourseXml.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCourseXml.TabIndex = 16;
            this.btnLoadCourseXml.Tag = "xml";
            this.btnLoadCourseXml.Text = "Load Xml";
            this.btnLoadCourseXml.UseVisualStyleBackColor = true;
            this.btnLoadCourseXml.Click += new System.EventHandler(this.btnLoadCourseXml_Click);
            // 
            // btnSaveCourseXml
            // 
            this.btnSaveCourseXml.Location = new System.Drawing.Point(433, 47);
            this.btnSaveCourseXml.Name = "btnSaveCourseXml";
            this.btnSaveCourseXml.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCourseXml.TabIndex = 17;
            this.btnSaveCourseXml.Text = "Save";
            this.btnSaveCourseXml.UseVisualStyleBackColor = true;
            this.btnSaveCourseXml.Click += new System.EventHandler(this.btnSaveCourseXml_Click);
            // 
            // btnLoadCourseJson
            // 
            this.btnLoadCourseJson.Location = new System.Drawing.Point(352, 47);
            this.btnLoadCourseJson.Name = "btnLoadCourseJson";
            this.btnLoadCourseJson.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCourseJson.TabIndex = 18;
            this.btnLoadCourseJson.Tag = "json";
            this.btnLoadCourseJson.Text = "Load Json";
            this.btnLoadCourseJson.UseVisualStyleBackColor = true;
            this.btnLoadCourseJson.Click += new System.EventHandler(this.btnLoadCourseXml_Click);
            // 
            // FormHttpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
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
        private System.Windows.Forms.Button btnSaveCourseXml;
        private System.Windows.Forms.Button btnLoadCourseXml;
        private System.Windows.Forms.DateTimePicker edDateQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadCourseJson;
    }
}

