namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearRcv = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.textBoxRcv = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.rbStrRcv = new System.Windows.Forms.RadioButton();
            this.rb16Rcv = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rb16Send = new System.Windows.Forms.RadioButton();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnOpenSreial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSerialName = new System.Windows.Forms.ComboBox();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "波特率";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(145, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearRcv
            // 
            this.btnClearRcv.Location = new System.Drawing.Point(22, 431);
            this.btnClearRcv.Name = "btnClearRcv";
            this.btnClearRcv.Size = new System.Drawing.Size(75, 23);
            this.btnClearRcv.TabIndex = 36;
            this.btnClearRcv.Text = "清空";
            this.btnClearRcv.UseVisualStyleBackColor = true;
            this.btnClearRcv.Click += new System.EventHandler(this.btnClearRcv_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(251, 212);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 35;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClearSend
            // 
            this.btnClearSend.Location = new System.Drawing.Point(44, 212);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(75, 23);
            this.btnClearSend.TabIndex = 34;
            this.btnClearSend.Text = "清空";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // textBoxRcv
            // 
            this.textBoxRcv.Location = new System.Drawing.Point(22, 44);
            this.textBoxRcv.Multiline = true;
            this.textBoxRcv.Name = "textBoxRcv";
            this.textBoxRcv.Size = new System.Drawing.Size(209, 367);
            this.textBoxRcv.TabIndex = 33;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(27, 44);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(319, 148);
            this.textBoxSend.TabIndex = 32;
            // 
            // rbStrRcv
            // 
            this.rbStrRcv.AutoSize = true;
            this.rbStrRcv.Location = new System.Drawing.Point(159, 20);
            this.rbStrRcv.Name = "rbStrRcv";
            this.rbStrRcv.Size = new System.Drawing.Size(71, 16);
            this.rbStrRcv.TabIndex = 31;
            this.rbStrRcv.TabStop = true;
            this.rbStrRcv.Text = "字符串收";
            this.rbStrRcv.UseVisualStyleBackColor = true;
            // 
            // rb16Rcv
            // 
            this.rb16Rcv.AutoSize = true;
            this.rb16Rcv.Location = new System.Drawing.Point(21, 20);
            this.rb16Rcv.Name = "rb16Rcv";
            this.rb16Rcv.Size = new System.Drawing.Size(71, 16);
            this.rb16Rcv.TabIndex = 30;
            this.rb16Rcv.TabStop = true;
            this.rb16Rcv.Text = "16进制收";
            this.rb16Rcv.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(134, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "字符串发";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rb16Send
            // 
            this.rb16Send.AutoSize = true;
            this.rb16Send.Location = new System.Drawing.Point(27, 22);
            this.rb16Send.Name = "rb16Send";
            this.rb16Send.Size = new System.Drawing.Size(71, 16);
            this.rb16Send.TabIndex = 28;
            this.rb16Send.TabStop = true;
            this.rb16Send.Text = "16进制发";
            this.rb16Send.UseVisualStyleBackColor = true;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(251, 139);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(95, 20);
            this.cbDataBits.TabIndex = 27;
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(249, 82);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(98, 20);
            this.cbStop.TabIndex = 26;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(67, 139);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(95, 20);
            this.cbParity.TabIndex = 25;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(67, 82);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(95, 20);
            this.cbBaudRate.TabIndex = 24;
            // 
            // btnOpenSreial
            // 
            this.btnOpenSreial.Location = new System.Drawing.Point(235, 32);
            this.btnOpenSreial.Name = "btnOpenSreial";
            this.btnOpenSreial.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSreial.TabIndex = 23;
            this.btnOpenSreial.Text = "打开串口";
            this.btnOpenSreial.UseVisualStyleBackColor = true;
            this.btnOpenSreial.Click += new System.EventHandler(this.btnOpenSreial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "串口名称";
            // 
            // cbSerialName
            // 
            this.cbSerialName.FormattingEnabled = true;
            this.cbSerialName.Location = new System.Drawing.Point(67, 34);
            this.cbSerialName.Name = "cbSerialName";
            this.cbSerialName.Size = new System.Drawing.Size(95, 20);
            this.cbSerialName.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRcv);
            this.groupBox1.Controls.Add(this.rb16Rcv);
            this.groupBox1.Controls.Add(this.rbStrRcv);
            this.groupBox1.Controls.Add(this.btnClearRcv);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(401, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 468);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStop);
            this.groupBox2.Controls.Add(this.cbSerialName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnOpenSreial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbBaudRate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbParity);
            this.groupBox2.Controls.Add(this.cbDataBits);
            this.groupBox2.Location = new System.Drawing.Point(24, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 183);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSend);
            this.groupBox3.Controls.Add(this.rb16Send);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.btnClearSend);
            this.groupBox3.Location = new System.Drawing.Point(24, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 249);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearRcv;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.RadioButton rbStrRcv;
        private System.Windows.Forms.RadioButton rb16Rcv;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rb16Send;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Button btnOpenSreial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSerialName;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

