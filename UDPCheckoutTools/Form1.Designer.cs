namespace UDPCheckoutTools
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSrcIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxSrcPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxDestIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxDestPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxRec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxHistotry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "源IP";
            // 
            // txtboxSrcIP
            // 
            this.txtboxSrcIP.Location = new System.Drawing.Point(76, 14);
            this.txtboxSrcIP.Name = "txtboxSrcIP";
            this.txtboxSrcIP.Size = new System.Drawing.Size(110, 21);
            this.txtboxSrcIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "源端口";
            // 
            // txtboxSrcPort
            // 
            this.txtboxSrcPort.Location = new System.Drawing.Point(267, 14);
            this.txtboxSrcPort.Name = "txtboxSrcPort";
            this.txtboxSrcPort.Size = new System.Drawing.Size(57, 21);
            this.txtboxSrcPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "目标IP";
            // 
            // txtboxDestIP
            // 
            this.txtboxDestIP.Location = new System.Drawing.Point(76, 46);
            this.txtboxDestIP.Name = "txtboxDestIP";
            this.txtboxDestIP.Size = new System.Drawing.Size(110, 21);
            this.txtboxDestIP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "目标端口";
            // 
            // txtboxDestPort
            // 
            this.txtboxDestPort.Location = new System.Drawing.Point(268, 45);
            this.txtboxDestPort.Name = "txtboxDestPort";
            this.txtboxDestPort.Size = new System.Drawing.Size(56, 21);
            this.txtboxDestPort.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "发送报文";
            // 
            // txtboxSend
            // 
            this.txtboxSend.Location = new System.Drawing.Point(90, 83);
            this.txtboxSend.Name = "txtboxSend";
            this.txtboxSend.Size = new System.Drawing.Size(234, 21);
            this.txtboxSend.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(138, 121);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "返回报文";
            // 
            // txtboxRec
            // 
            this.txtboxRec.Location = new System.Drawing.Point(30, 177);
            this.txtboxRec.Multiline = true;
            this.txtboxRec.Name = "txtboxRec";
            this.txtboxRec.ReadOnly = true;
            this.txtboxRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxRec.Size = new System.Drawing.Size(313, 77);
            this.txtboxRec.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "异常";
            // 
            // txtboxHistotry
            // 
            this.txtboxHistotry.Location = new System.Drawing.Point(30, 285);
            this.txtboxHistotry.Multiline = true;
            this.txtboxHistotry.Name = "txtboxHistotry";
            this.txtboxHistotry.ReadOnly = true;
            this.txtboxHistotry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxHistotry.Size = new System.Drawing.Size(313, 126);
            this.txtboxHistotry.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 423);
            this.Controls.Add(this.txtboxHistotry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxRec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtboxSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxDestPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxDestIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxSrcPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxSrcIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UDP测试工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSrcIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxSrcPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxDestIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxDestPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxRec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxHistotry;
    }
}

