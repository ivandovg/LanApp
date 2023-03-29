namespace LanApp5_2ScreenClient
{
    partial class MainFormScreenClient
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
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.btnGetScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edIPAddress = new System.Windows.Forms.TextBox();
            this.edPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScreen
            // 
            this.pbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScreen.Location = new System.Drawing.Point(12, 12);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(520, 436);
            this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScreen.TabIndex = 1;
            this.pbScreen.TabStop = false;
            // 
            // btnGetScreen
            // 
            this.btnGetScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetScreen.Location = new System.Drawing.Point(551, 106);
            this.btnGetScreen.Name = "btnGetScreen";
            this.btnGetScreen.Size = new System.Drawing.Size(75, 23);
            this.btnGetScreen.TabIndex = 2;
            this.btnGetScreen.Text = "GetScreen";
            this.btnGetScreen.UseVisualStyleBackColor = true;
            this.btnGetScreen.Click += new System.EventHandler(this.btnGetScreen_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // edIPAddress
            // 
            this.edIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edIPAddress.Location = new System.Drawing.Point(538, 28);
            this.edIPAddress.Name = "edIPAddress";
            this.edIPAddress.Size = new System.Drawing.Size(100, 20);
            this.edIPAddress.TabIndex = 5;
            this.edIPAddress.Text = "127.0.0.1";
            // 
            // edPort
            // 
            this.edPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edPort.Location = new System.Drawing.Point(538, 80);
            this.edPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edPort.Name = "edPort";
            this.edPort.Size = new System.Drawing.Size(100, 20);
            this.edPort.TabIndex = 6;
            this.edPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // MainFormScreenClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 460);
            this.Controls.Add(this.edPort);
            this.Controls.Add(this.edIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetScreen);
            this.Controls.Add(this.pbScreen);
            this.Name = "MainFormScreenClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Remote Screen over TCP";
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScreen;
        private System.Windows.Forms.Button btnGetScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edIPAddress;
        private System.Windows.Forms.NumericUpDown edPort;
    }
}

