﻿using System;
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
        private int ports_length = 0;
        private String Time_start;
        private String Time_end;
        public Form1()
        {
            InitializeComponent();
            comboBox_BaudRate.Text = Convert.ToString(Com.BaudRate);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_status.Text.Equals("Disconnected"))
            {
                Com.PortName = comboBox_selectCOM.Text;
                txtbx_receiverData.Clear();
                Time_start = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
                txtbx_receiverData.Text = Time_start;
                txtbx_receiverData.Text += "\r\n";
                Com.Open();
                Com.WriteLine("1");
                btn_open.Text = "Close";
                lb_status.Text = "Connected";
               
            }
            else
            {
                Com.Close();
                Com.WriteLine("0");
                Time_end = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
                txtbx_receiverData.Text += Time_end;
                txtbx_receiverData.Text += "\r\n";
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
            if (lb_status.Text.Equals("Connected")) 
            {
                Time_end = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
                txtbx_receiverData.Text += Time_end;
                txtbx_receiverData.Text += "\r\n";                
            }
            FileInfo data = new FileInfo(@"D:\" + Time_start + ".txt");
            StreamWriter data_wr = data.CreateText();
            data_wr.WriteLine(txtbx_receiverData.Text);
            data_wr.Close();
            txtbx_receiverData.Clear();
            Time_start = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
            txtbx_receiverData.Text += Time_start;
            txtbx_receiverData.Text += "\r\n";
        }
    }
}
