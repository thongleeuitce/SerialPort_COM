using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace COM_Port
{
    public partial class Form1 : Form
    {
        int ports_length = 0;
        public Form1()
        {
            InitializeComponent();
            init_Baund();
        }
        private void init_Baund()
        {
            int[] Baud = new int[] { 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200 };
            comboBox_BaudRate.Items.Clear();
            for (int i = 0; i < Baud.Length; i++)
                comboBox_BaudRate.Items.Add(Baud[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_status.Text.Equals("Disconnect"))
            {
                Com.PortName = comboBox_selectCOM.Text;
                Com.Open();
                btn_open.Text = "Close";
                lb_status.Text = "Connect";
            }
            else
            {
                Com.Close();
                btn_open.Text = "Open";
                lb_status.Text = "Disconnect";               
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int i;
            String[] ports = SerialPort.GetPortNames();
            if (ports_length != ports.Length)
            {
                ports_length = ports.Length;
                comboBox_selectCOM.Items.Clear();
                for (i = 0 ; i < ports_length; i++)
                    comboBox_selectCOM.Items.Add(ports[i]);
            }
        }

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String result = Com.ReadExisting();
            Display(result);
        }

        private delegate void DlDisplay(string s);
        private void Display(string s)
        {
            
            if (txtbx_receiverData.InvokeRequired)
            {
                DlDisplay sd = new DlDisplay(Display);
                txtbx_receiverData.Invoke(sd, new object[] {s});
            }
            else
            {
                txtbx_receiverData.Text += s;   
            }
        }
    }
}
