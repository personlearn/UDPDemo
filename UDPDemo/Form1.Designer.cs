namespace UDPDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStartAttence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSensivity = new System.Windows.Forms.TextBox();
            this.BtnSetSensivity = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStartAttence
            // 
            this.BtnStartAttence.Location = new System.Drawing.Point(88, 21);
            this.BtnStartAttence.Name = "BtnStartAttence";
            this.BtnStartAttence.Size = new System.Drawing.Size(75, 23);
            this.BtnStartAttence.TabIndex = 0;
            this.BtnStartAttence.Text = "开始考勤";
            this.BtnStartAttence.UseVisualStyleBackColor = true;
            this.BtnStartAttence.Click += new System.EventHandler(this.BtnStartAttence_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "设置灵敏度";
            // 
            // TxtSensivity
            // 
            this.TxtSensivity.Location = new System.Drawing.Point(123, 63);
            this.TxtSensivity.Name = "TxtSensivity";
            this.TxtSensivity.Size = new System.Drawing.Size(100, 21);
            this.TxtSensivity.TabIndex = 2;
            // 
            // BtnSetSensivity
            // 
            this.BtnSetSensivity.Location = new System.Drawing.Point(263, 61);
            this.BtnSetSensivity.Name = "BtnSetSensivity";
            this.BtnSetSensivity.Size = new System.Drawing.Size(75, 23);
            this.BtnSetSensivity.TabIndex = 3;
            this.BtnSetSensivity.Text = "确定";
            this.BtnSetSensivity.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(212, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "停止考勤";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 404);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnSetSensivity);
            this.Controls.Add(this.TxtSensivity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStartAttence);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartAttence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSensivity;
        private System.Windows.Forms.Button BtnSetSensivity;
        private System.Windows.Forms.Button btnClose;
    }
}

