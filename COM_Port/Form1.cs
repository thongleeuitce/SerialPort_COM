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
using System.IO;

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
            comboBox_BaudRate.Text = Convert.ToString(Baud[4]);
            Com.BaudRate = Convert.ToInt16(comboBox_BaudRate.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_status.Text.Equals("Disconnected"))
            {
                Com.PortName = comboBox_selectCOM.Text;
                Com.Open();
                btn_open.Text = "Close";
                lb_status.Text = "Connected";
            }
            else
            {
                Com.Close();
                btn_open.Text = "Open";
                lb_status.Text = "Disconnected";               
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

        private void comboBox_BaudRate_TextChanged(object sender, EventArgs e)
        {
            Com.BaudRate = Convert.ToInt16(comboBox_BaudRate.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            FileInfo data = new FileInfo(@"D:\data.txt");
            StreamWriter data_wr = data.CreateText();
            data_wr.WriteLine(txtbx_receiverData.Text);
            data_wr.Close();
            txtbx_receiverData.Clear();
        }
    }
}
