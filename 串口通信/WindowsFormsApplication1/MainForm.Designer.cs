namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReceiveData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntSwitchSP = new System.Windows.Forms.Button();
            this.btnReceiveData = new System.Windows.Forms.Button();
            this.btnSetSP = new System.Windows.Forms.Button();
            this.bntSendData = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.bntSendFile = new System.Windows.Forms.Button();
            this.bntClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送管理";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(69, 37);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(331, 81);
            this.txtSend.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发送数据：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceiveData);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(54, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接受管理";
            // 
            // txtReceiveData
            // 
            this.txtReceiveData.Location = new System.Drawing.Point(69, 44);
            this.txtReceiveData.Multiline = true;
            this.txtReceiveData.Name = "txtReceiveData";
            this.txtReceiveData.Size = new System.Drawing.Size(331, 148);
            this.txtReceiveData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "接受数据：";
            // 
            // bntSwitchSP
            // 
            this.bntSwitchSP.Location = new System.Drawing.Point(206, 25);
            this.bntSwitchSP.Name = "bntSwitchSP";
            this.bntSwitchSP.Size = new System.Drawing.Size(75, 23);
            this.bntSwitchSP.TabIndex = 2;
            this.bntSwitchSP.Text = "打开串口";
            this.bntSwitchSP.UseVisualStyleBackColor = true;
            this.bntSwitchSP.Click += new System.EventHandler(this.bntSwitchSP_Click);
            // 
            // btnReceiveData
            // 
            this.btnReceiveData.Location = new System.Drawing.Point(518, 327);
            this.btnReceiveData.Name = "btnReceiveData";
            this.btnReceiveData.Size = new System.Drawing.Size(75, 23);
            this.btnReceiveData.TabIndex = 3;
            this.btnReceiveData.Text = "接收数据";
            this.btnReceiveData.UseVisualStyleBackColor = true;
            this.btnReceiveData.Click += new System.EventHandler(this.btnReceiveData_Click);
            // 
            // btnSetSP
            // 
            this.btnSetSP.Location = new System.Drawing.Point(43, 26);
            this.btnSetSP.Name = "btnSetSP";
            this.btnSetSP.Size = new System.Drawing.Size(75, 23);
            this.btnSetSP.TabIndex = 4;
            this.btnSetSP.Text = "设置串口";
            this.btnSetSP.UseVisualStyleBackColor = true;
            this.btnSetSP.Click += new System.EventHandler(this.btnSetSP_Click);
            // 
            // bntSendData
            // 
            this.bntSendData.Location = new System.Drawing.Point(518, 112);
            this.bntSendData.Name = "bntSendData";
            this.bntSendData.Size = new System.Drawing.Size(75, 23);
            this.bntSendData.TabIndex = 5;
            this.bntSendData.Text = "发送数据";
            this.bntSendData.UseVisualStyleBackColor = true;
            this.bntSendData.Click += new System.EventHandler(this.bntSendData_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "导出信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(54, 202);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "文件浏览";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // bntSendFile
            // 
            this.bntSendFile.Location = new System.Drawing.Point(518, 230);
            this.bntSendFile.Name = "bntSendFile";
            this.bntSendFile.Size = new System.Drawing.Size(75, 23);
            this.bntSendFile.TabIndex = 8;
            this.bntSendFile.Text = "发送文件";
            this.bntSendFile.UseVisualStyleBackColor = true;
            this.bntSendFile.Click += new System.EventHandler(this.bntSendFile_Click);
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(518, 396);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 9;
            this.bntClear.Text = "清空内容";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(54, 232);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(428, 21);
            this.txtFileName.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(670, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.bntSendFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntSendData);
            this.Controls.Add(this.btnSetSP);
            this.Controls.Add(this.btnReceiveData);
            this.Controls.Add(this.bntSwitchSP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntSwitchSP;
        private System.Windows.Forms.Button btnReceiveData;
        private System.Windows.Forms.Button btnSetSP;
        private System.Windows.Forms.Button bntSendData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button bntSendFile;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtReceiveData;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}

