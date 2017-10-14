using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ComSet : Form
    {
        public ComSet()
        {
            InitializeComponent();
        }

        private void ComSet_Load(object sender, EventArgs e)
        {
            //串口
            var ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                cmbPort.Items.Add(port);
            }
            cmbPort.SelectedIndex = 0;

            //波特率
            cmbBaudRate.Items.Add("110");
            cmbBaudRate.Items.Add("300");
            cmbBaudRate.Items.Add("1200");
            cmbBaudRate.Items.Add("2400");
            cmbBaudRate.Items.Add("4800");
            cmbBaudRate.Items.Add("9600");
            cmbBaudRate.Items.Add("19200");
            cmbBaudRate.Items.Add("38400");
            cmbBaudRate.Items.Add("57600");
            cmbBaudRate.Items.Add("115200");
            cmbBaudRate.Items.Add("230400");
            cmbBaudRate.Items.Add("460800");
            cmbBaudRate.Items.Add("921600");
            cmbBaudRate.SelectedIndex = 5;

            //数据位
            cmbDataBits.Items.Add("5");
            cmbDataBits.Items.Add("6");
            cmbDataBits.Items.Add("7");
            cmbDataBits.Items.Add("8");
            cmbDataBits.SelectedIndex = 3;

            //停止位
            cmbStopBit.Items.Add("1");
            cmbStopBit.SelectedIndex = 0;

            //校验位
            cmbParity.Items.Add("无");
            cmbParity.SelectedIndex = 0;
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            MainForm.strProtName = cmbPort.Text;
            MainForm.strBaudRate = cmbBaudRate.Text;
            MainForm.strDataBits = cmbDataBits.Text;
            MainForm.strStopBits = cmbStopBit.Text;
            DialogResult = DialogResult.OK;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
