namespace COM_Port
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
            this.btn_open = new System.Windows.Forms.Button();
            this.comboBox_selectCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtbx_receiverData = new System.Windows.Forms.TextBox();
            this.Com = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(380, 322);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(85, 23);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_selectCOM
            // 
            this.comboBox_selectCOM.FormattingEnabled = true;
            this.comboBox_selectCOM.Location = new System.Drawing.Point(428, 53);
            this.comboBox_selectCOM.Name = "comboBox_selectCOM";
            this.comboBox_selectCOM.Size = new System.Drawing.Size(121, 21);
            this.comboBox_selectCOM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select COM:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtbx_receiverData
            // 
            this.txtbx_receiverData.Location = new System.Drawing.Point(50, 33);
            this.txtbx_receiverData.Multiline = true;
            this.txtbx_receiverData.Name = "txtbx_receiverData";
            this.txtbx_receiverData.Size = new System.Drawing.Size(320, 264);
            this.txtbx_receiverData.TabIndex = 3;
            // 
            // Com
            // 
            this.Com.PortName = "COM";
            this.Com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Com_DataReceived);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Received data";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_status.Location = new System.Drawing.Point(89, 322);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(73, 13);
            this.lb_status.TabIndex = 5;
            this.lb_status.Text = "Disconnected";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(428, 109);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BaudRate.TabIndex = 6;
            this.comboBox_BaudRate.TextChanged += new System.EventHandler(this.comboBox_BaudRate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Baud Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(480, 322);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(83, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 366);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_BaudRate);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_receiverData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_selectCOM);
            this.Controls.Add(this.btn_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ComboBox comboBox_selectCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtbx_receiverData;
        private System.IO.Ports.SerialPort Com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
    }
}

