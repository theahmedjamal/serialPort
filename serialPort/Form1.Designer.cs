namespace serialPort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.cBoxDatabits = new System.Windows.Forms.ComboBox();
            this.cBoxStopbits = new System.Windows.Forms.ComboBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxBaudrate);
            this.groupBox1.Controls.Add(this.cBoxDatabits);
            this.groupBox1.Controls.Add(this.cBoxStopbits);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Communication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Parity Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stop Bit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // cBoxBaudrate
            // 
            this.cBoxBaudrate.FormattingEnabled = true;
            this.cBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "57600",
            "115200",
            "230400",
            "460800",
            ""});
            this.cBoxBaudrate.Location = new System.Drawing.Point(90, 47);
            this.cBoxBaudrate.Name = "cBoxBaudrate";
            this.cBoxBaudrate.Size = new System.Drawing.Size(171, 21);
            this.cBoxBaudrate.TabIndex = 0;
            this.cBoxBaudrate.Text = "9600";
            // 
            // cBoxDatabits
            // 
            this.cBoxDatabits.FormattingEnabled = true;
            this.cBoxDatabits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDatabits.Location = new System.Drawing.Point(90, 74);
            this.cBoxDatabits.Name = "cBoxDatabits";
            this.cBoxDatabits.Size = new System.Drawing.Size(171, 21);
            this.cBoxDatabits.TabIndex = 0;
            this.cBoxDatabits.Text = "8";
            // 
            // cBoxStopbits
            // 
            this.cBoxStopbits.FormattingEnabled = true;
            this.cBoxStopbits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopbits.Location = new System.Drawing.Point(90, 101);
            this.cBoxStopbits.Name = "cBoxStopbits";
            this.cBoxStopbits.Size = new System.Drawing.Size(171, 21);
            this.cBoxStopbits.TabIndex = 0;
            this.cBoxStopbits.Text = "One";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(90, 128);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(171, 21);
            this.cBoxParityBits.TabIndex = 0;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(90, 20);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(171, 21);
            this.cBoxComPort.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 21);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendData);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(21, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(168, 32);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(74, 46);
            this.btnSendData.TabIndex = 1;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(83, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 28);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(61, 25);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(306, 13);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(209, 281);
            this.tBoxDataOut.TabIndex = 2;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 305);
            this.Controls.Add(this.tBoxDataOut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Serial Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxBaudrate;
        private System.Windows.Forms.ComboBox cBoxDatabits;
        private System.Windows.Forms.ComboBox cBoxStopbits;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

