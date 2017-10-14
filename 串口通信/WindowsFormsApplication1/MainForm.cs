using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Thread getRecevice;
        protected Boolean stop = false;
        protected Boolean conState = false;
        private StreamReader sRead;
        string strRecieve;
        bool bAccpet = false;

        SerialPort sp = new SerialPort();//实例化串口通讯类
        //以下定义4个公有变量，用于参数传递
        public static string strProtName = "";
        public static string strBaudRate = "";
        public static string strDataBits = "";
        public static string strStopBits = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            this.toolStripStatusLabel1.Text = "端口号：端口未打开 | ";
            this.toolStripStatusLabel2.Text = "波特率：端口未打开 | ";
            this.toolStripStatusLabel3.Text = "数据位：端口未打开 | ";
            this.toolStripStatusLabel4.Text = "停止位：端口未打开 | ";
            this.toolStripStatusLabel5.Text = "";
        }

        //串口设计
        private void btnSetSP_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            sp.Close();
            ComSet dlg = new ComSet();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sp.PortName = strProtName;//串口号
                sp.BaudRate = int.Parse(strBaudRate);//波特率
                sp.DataBits = int.Parse(strDataBits);//数据位
                sp.StopBits = (StopBits)int.Parse(strStopBits);//停止位
                sp.ReadTimeout = 500;//读取数据的超时时间，引发ReadExisting异常
            }
        }

        //打开/关闭串口
        private void bntSwitchSP_Click(object sender, EventArgs e)
        {
            if (bntSwitchSP.Text == "打开串口")
            {
                if (strProtName != "" && strBaudRate != "" && strDataBits != "" && strStopBits != "")
                {
                    try
                    {
                        if (sp.IsOpen)
                        {
                            sp.Close();
                            sp.Open();//打开串口
                        }
                        else
                        {
                            sp.Open();//打开串口
                        }
                        bntSwitchSP.Text = "关闭串口";
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = true;
                        this.toolStripStatusLabel1.Text = "端口号：" + sp.PortName + " | ";
                        this.toolStripStatusLabel2.Text = "波特率：" + sp.BaudRate + " | ";
                        this.toolStripStatusLabel3.Text = "数据位：" + sp.DataBits + " | ";
                        this.toolStripStatusLabel4.Text = "停止位：" + sp.StopBits + " | ";
                        this.toolStripStatusLabel5.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误：" + ex.Message, "C#串口通信");
                    }
                }
                else
                {
                    MessageBox.Show("请先设置串口！", "RS232串口通信");
                }
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                bntSwitchSP.Text = "打开串口";
                if (sp.IsOpen)
                    sp.Close();
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                this.toolStripStatusLabel1.Text = "端口号：端口未打开 | ";
                this.toolStripStatusLabel2.Text = "波特率：端口未打开 | ";
                this.toolStripStatusLabel3.Text = "数据位：端口未打开 | ";
                this.toolStripStatusLabel4.Text = "停止位：端口未打开 | ";
                this.toolStripStatusLabel5.Text = "";
            }
        }

        //发送数据
        private void bntSendData_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.Encoding = System.Text.Encoding.GetEncoding("GB2312");
                    sp.Write(txtSend.Text);//发送数据
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("错误：{0}", ex.Message));
                }
            }
            else
            {
                MessageBox.Show(@"请先打开串口！");
            }
        }

        //选择文件
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c\\";
            open.RestoreDirectory = true;
            open.FilterIndex = 1;
            open.Filter = "txt文件(*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (open.OpenFile() != null)
                    {
                        txtFileName.Text = open.FileName;
                    }
                }
                catch (Exception err1)
                {
                    MessageBox.Show("文件打开错误!  " + err1.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //发送文件内容
        private void bntSendFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();
            if (fileName == "")
            {
                MessageBox.Show("请选择要发送的文件！", "Error");
                return;
            }
            else
            {
                //sRead = new StreamReader(fileName);
                sRead = new StreamReader(fileName, Encoding.Default);//解决中文乱码问题
            }
            timer1.Start();
        }

        //发送文件时钟
        private void timer1_Tick(object sender, EventArgs e)
        {
            string str1;
            str1 = sRead.ReadLine();
            if (str1 == null)
            {
                timer1.Stop();
                sRead.Close();
                MessageBox.Show("文件发送成功！", "C#串口通讯");
                this.toolStripStatusLabel5.Text = "";
                return;
            }
            byte[] data = Encoding.Default.GetBytes(str1);
            sp.Write(data, 0, data.Length);
            this.toolStripStatusLabel5.Text = "   文件发送中...";
        }

        //接收数据
        private void btnReceiveData_Click(object sender, EventArgs e)
        {
            if (btnReceiveData.Text == "接收数据")
            {
                sp.Encoding = Encoding.GetEncoding("GB2312");
                if (sp.IsOpen)
                {
                    //timer2.Enabled = true; //使用主线程进行

                    //使用委托以及多线程进行
                    bAccpet = true;
                    getRecevice = new Thread(new ThreadStart(testDelegate));
                    //getRecevice.IsBackground = true;
                    getRecevice.Start();
                    btnReceiveData.Text = "停止接收";
                }
                else
                {
                    MessageBox.Show("请先打开串口");
                }
            }
            else
            {
                //timer2.Enabled = false;
                bAccpet = false;
                try
                {   //停止主监听线程
                    if (null != getRecevice)
                    {
                        if (getRecevice.IsAlive)
                        {
                            if (!getRecevice.Join(100))
                            {
                                //关闭线程
                                getRecevice.Abort();
                            }
                        }
                        getRecevice = null;
                    }
                }
                catch { }
                btnReceiveData.Text = "接收数据";
            }
        }
        private void testDelegate()
        {
            reaction r = new reaction(fun);
            r();
        }

        //用于接收数据的定时时钟
        private void timer2_Tick(object sender, EventArgs e)
        {
            string str = sp.ReadExisting();
            string str2 = str.Replace("\r", "\r\n");
            txtReceiveData.AppendText(str2);
            txtReceiveData.ScrollToCaret();
        }

        //下面用到了接收信息的代理功能，此为设计的要点之一
        delegate void DelegateAcceptData();
        void fun()
        {
            while (bAccpet)
            {
                AcceptData();
            }
        }

        delegate void reaction();
        void AcceptData()
        {
            if (txtReceiveData.InvokeRequired)
            {
                try
                {
                    DelegateAcceptData ddd = new DelegateAcceptData(AcceptData);
                    this.Invoke(ddd, new object[] { });
                }
                catch { }
            }
            else
            {
                try
                {
                    strRecieve = sp.ReadExisting();
                    txtReceiveData.AppendText(strRecieve);
                }
                catch (Exception ex) { }
            }
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtReceiveData.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\output.txt";
                string content = this.txtReceiveData.Text;
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter write = new StreamWriter(fs);
                write.Write(content);
                write.Flush();
                write.Close();
                fs.Close();
                MessageBox.Show("接收信息导出在:" + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
