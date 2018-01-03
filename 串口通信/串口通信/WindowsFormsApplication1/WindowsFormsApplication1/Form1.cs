using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = Encoding.Unicode.GetBytes(txtSend.Text);
            var str = Convert.ToBase64String(data);
            serialPort1.WriteLine(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            var data = Convert.FromBase64String(serialPort1.ReadLine());
            Invoke(new EventHandler(delegate
            {
                txtReceived.Text = Encoding.Unicode.GetString(data);
            }));
        }
    }
}
