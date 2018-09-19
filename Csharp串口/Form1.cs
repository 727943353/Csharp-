using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenSreial_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                try
                {
                    //串口号
                    string serialName = cbSerialName.SelectedItem.ToString();
                    sp.PortName = serialName;
                    sp.BaudRate = Convert.ToInt32(cbBaudRate.Text);   //波特率
                    sp.DataBits = Convert.ToInt32(cbDataBits.Text);   //数据位

                    switch (cbStop.Text)           //停止位
                    {
                        case "1":
                            sp.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            sp.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            sp.StopBits = StopBits.Two;
                            break;
                        default:
                            break;
                    }

                    switch (cbParity.Text)             //校验位
                    {
                        case "无":
                            sp.Parity = Parity.None;
                            break;
                        case "奇校验":
                            sp.Parity = Parity.Odd;
                            break;
                        case "偶校验":
                            sp.Parity = Parity.Even;
                            break;
                        default:
                            break;
                    }

                    if (sp.IsOpen == true)   //如果是开着的，先关一下，再开，直接打开可能会出问题
                    {
                        sp.Close();
                    }

                    sp.Open();
                    btnOpenSreial.Text = "关闭串口";
                    //打开串口之后，把串口配置选项都禁用掉
                    cbSerialName.Enabled = false;
                    cbBaudRate.Enabled = false;
                    cbDataBits.Enabled = false;
                    cbParity.Enabled = false;
                    cbStop.Enabled = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
            else
            {
                //关闭串口
                sp.Close();
                btnOpenSreial.Text = "打开串口";
                //启用配置选项
                cbSerialName.Enabled = true;
                cbStop.Enabled = true;
                cbParity.Enabled = true;
                cbDataBits.Enabled = true;
                cbBaudRate.Enabled = true;
            }
        }

        private void btnClearSend_Click(object sender, EventArgs e)
        {
            textBoxSend.Text = "";   //清空发送数据文本框
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  //退出按钮
        }

        private void btnClearRcv_Click(object sender, EventArgs e)
        {
            textBoxRcv.Text = "";  //清空接收数据文本框
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("请先打开串口！！！");
                return;
            }

            string strSend = textBoxSend.Text;

            if (rb16Send.Checked)         //以16进制格式进行发送
            {
                string strBuf = strSend;
                string sendnoNull = strBuf.Trim();      //去掉空格
                string[] sendArray = strBuf.Split(' ');  //以空格分割

                byte[] b = new byte[sendArray.Length];
                //逐个将字符转为16进制字节数据
                for (int i = 0; i < sendArray.Length; i++)
                {
                    b[i] = Convert.ToByte(sendArray[i], 16);
                }

                sp.Write(b, 0, b.Length);
            }
            else              //以字符串格式发送
            {
                sp.WriteLine(textBoxSend.Text);
            }
        }


        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp.IsOpen)
            {
                //输出当前时间
                //DateTime dt = DateTime.Now;
                //textBoxRcv.Text += dt.GetDateTimeFormats('f')[0].ToString() + "\r\n";
                try
                {
                    Byte[] receivedData = new Byte[sp.BytesToRead];        //创建接收字节数组
                    sp.Read(receivedData, 0, receivedData.Length);         //读取数据,读取到receivedData中的是字符的ASCII码
                    sp.DiscardInBuffer();                                  //清空SerialPort控件的Buffer
                    //以字符串显示
                    if (rbStrRcv.Checked)
                    {
                        string strRcv = null;
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            strRcv += ((char)Convert.ToInt32(receivedData[i]));//把字节转换成整型，再强转成char
                        }
                        textBoxRcv.Text += strRcv + "\r\n";             //显示信息
                    }
                    //以16进制显示
                    if (rb16Rcv.Checked)
                    {
                        string strRcv = null;
                        //int decNum = 0;//存储十进制
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            strRcv += receivedData[i].ToString("X2");  //16进制显示
                        }
                        textBoxRcv.Text += strRcv + "\r\n";
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "出错提示");
                    textBoxSend.Text = "";
                }
            }
            else
            {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
        }

        private void textBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb16Send.Checked == true)      //以16进制格式发送数据时，只能输入特定字符
            {
                //正则匹配
                string patten = "[0-9a-fA-F]|\b|0x|0X| "; //“\b”：退格键
                Regex r = new Regex(patten);
                Match m = r.Match(e.KeyChar.ToString());

                if (m.Success)//&&(txtSend.Text.LastIndexOf(" ") != txtSend.Text.Length-1))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取所有串口名称
            string[] serialName = SerialPort.GetPortNames();
            foreach (string s in serialName)
            {
                //把串口名称添加到Combox
                cbSerialName.Items.Add(s);
            }
            //初始化设置，设置默认值
            cbSerialName.SelectedIndex = 0;
            cbBaudRate.SelectedIndex = 5;
            cbParity.SelectedIndex = 0;
            cbStop.SelectedIndex = 0;
            rb16Send.Select();
            rb16Rcv.Checked = true;
            cbDataBits.SelectedIndex = 3;
            Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
        }
    }
}
