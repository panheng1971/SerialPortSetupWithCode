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
namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        SerialPort[] SerialPorts;

        string[] SerialPortNames = SerialPort.GetPortNames();



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SerialPortNames = SerialPort.GetPortNames();
            SerialPorts = new SerialPort[SerialPortNames.Length];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int num = 0; num < SerialPortNames.Length; num++)
            {

             
                SerialPorts[num] = new SerialPort();
                SerialPorts[num].DataReceived += new SerialDataReceivedEventHandler(recievedata);//绑定事件
                SerialPorts[num].PortName = SerialPortNames[num];
                SerialPorts[num].BaudRate = 115200;
                SerialPorts[num].Parity = Parity.None;
                SerialPorts[num].DataBits = 8;
                SerialPorts[num].StopBits = StopBits.One;
                SerialPorts[num].Open();
            }
        }






        private byte[] strToHexByte(string hexString)             //字符串转换为byte[]
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0) hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }



        public void recievedata(object sender, SerialDataReceivedEventArgs e)                 //接收读取数据
        {

            byte[] ReDatas = new byte[((SerialPort)sender).BytesToRead];
            ((SerialPort)sender).Read(ReDatas, 0, ReDatas.Length);//读取数据

            MessageBox.Show("serial port "+ ((SerialPort)sender).PortName.ToString()+" recieved data: "+ReDatas[0].ToString());

        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x9 };
          
            for (int num = 0; num < SerialPortNames.Length; num++)
            {
                if (SerialPorts[num].IsOpen)
                {
                    try
                    {
                        SerialPorts[num].Write(data, 0, data.Length);//发送数据

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
    


    

