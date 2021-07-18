using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LightTest
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            //关闭跨线程访问检查
            CheckForIllegalCrossThreadCalls = false;
        }

        #region 命令转换
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        private void SendInstruction(string s)
        {
            byte[] buffer = HexStringToByteArray(s);
            serialPort.Write(buffer, 0, buffer.Length);
        }
        #endregion

        #region 发送命令
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string s = "A5 06 01 A0 ff ff ff EE 5A";
            SendInstruction(s);
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            button9_Click(sender, e);
            Thread.Sleep(100);
            string s = "A5 06 01 A0 00 00 00 EE 5A";
            SendInstruction(s);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            string s = "A5 06 01 A0 00 00 ff EE 5A";
            SendInstruction(s);
        }
        private void buttonGreen_Click(object sender, EventArgs e)
        {
            string s = "A5 06 01 A0 00 ff 00 EE 5A";
            SendInstruction(s);
        }
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            string s = "A5 06 01 A0 00 ff ff EE 5A";
            SendInstruction(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 01 EE 5A";
            SendInstruction(s);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 02 EE 5A";
            SendInstruction(s);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 03 EE 5A";
            SendInstruction(s);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 04 EE 5A";
            SendInstruction(s);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 05 EE 5A";
            SendInstruction(s);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 06 EE 5A";
            SendInstruction(s);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 07 EE 5A";
            SendInstruction(s);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 08 EE 5A";
            SendInstruction(s);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            string s = "A5 07 01 A8 7D 04 00 09 EE 5A";
            SendInstruction(s);
        }
        #endregion

        #region 连接串口
        private void Form_Load(object sender, EventArgs e)
        {
            string[] names = System.IO.Ports.SerialPort.GetPortNames();
            if (names.Length != 0)
            {
                comboBoxCom.Items.AddRange(names);
                comboBoxCom.SelectedIndex = 0;
            }
            else comboBoxCom.Text = "";
        }

        private void buttonOpenCom_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = comboBoxCom.Text;
                serialPort.Open();
                EnableButton(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口打开失败; \r\n" + ex.Message);
            }
        }

        private void buttonCloseCom_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            EnableButton(false);
        }

        private void EnableButton(bool on)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is GroupBox)
                {
                    foreach (Control ctrl in ctl.Controls)
                    {
                        if (ctrl is Button)
                        {
                            Button btn = ctrl as Button;
                            btn.Enabled = on;
                        }
                    }
                }
            }
            buttonCloseCom.Enabled = on;
            buttonOpenCom.Enabled = !on;
        }
        #endregion

        #region 接收数据
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] recivedDate = ReceiveData();
            string recivedString = ByteArrayToHexString(recivedDate);
            textBoxRecived.AppendText("\r\n响应: " + recivedString);
        }
        private string ByteArrayToHexString(byte[] bytes)
        {
            string s = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                s += bytes[i].ToString("X2") + " ";
            }
            return s;
        }
        private byte[] ReceiveData()
        {
            byte[] byteData = new byte[this.serialPort.BytesToRead];
            this.serialPort.Read(byteData, 0, serialPort.BytesToRead);
            return byteData;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRecived.Clear();
        }
        #endregion
    }
}
