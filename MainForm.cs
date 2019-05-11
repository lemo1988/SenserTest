using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UpperComputer
{
    public partial class MainForm : Form
    {
        byte[] OkOne = { 0x04, 0x01, 0x01, 0x01, 0x07 };//未遮挡前，测试OK，上位机发送数据
        public byte[] OkTwo = { 0x04, 0x01, 0x01, 0x02, 0x08 };//遮挡后，测试OK，上位机发送数据
        byte[] NgData ={ 0x04, 0x01, 0x01, 0x03, 0x09 };//测试fail,发送数据
        public static MainForm pCurrentWin = null;//定义一个静态变量
        private Int16 intRecdata=0;//组合接收到的数据
        private Int32 intProCount = 0; //总数
        private Int32 intProFail = 0;  //fail数
        public   SeriaPortMl SeriaPortLm;
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//窗体显示在屏幕的中央
            pCurrentWin = this;//将主窗体赋值给变量
            XDocument document = XDocument.Load("password.XML");
            XElement root = document.Root;
            XElement proCount = root.Element("proCount");//读取表格产量数据
            XElement failCount = root.Element("failCount");//读取不良数据
            textBox_POfAmount.Text = proCount.Value.ToString();
            textBoxProductionOfFail.Text = failCount.Value.ToString();
        }
        /// <summary>
        /// 串口设置和初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PortSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelPortset.Visible == false)
            {
                try
                {
                    panelPortset.Visible = true;
                    panelPortset.Show();
                    comboBox_PortName.Items.Clear();
                    foreach (var item in SerialPort.GetPortNames())
                    {
                        comboBox_PortName.Items.Add(item);
                    }
                    comboBox_PortName.Text = comboBox_PortName.Items[0].ToString();
                }
                catch (Exception )
                {
                    MessageBox.Show("没有检测到可以使用的串口！");
                }
            }
           else
            {
                panelPortset.Visible = false;
                panelPortset.Hide();
                SeriaPortLm = new SeriaPortMl(comboBox_PortName.Text,int.Parse(comboBox_PortBadurate.Text),
                    comboBox_Portparity.Text,int.Parse(comboBox_Portdatebits.Text),comboBox_PortStopbits.Text);
            }
        }
        /// <summary>
        /// 启动测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SeriaPortLm.IsOpen)
                {
                    SeriaPortLm.Open();
                    this.Invoke(new Action(() =>
                    {
                        ButtonStart.Text = "停止";
                    }));
                    SeriaPortLm.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);//启动监听
                    SeriaPortLm.ReceivedBytesThreshold = 1;
                    SeriaPortLm.Encoding = Encoding.Default;

                }
                else if (SeriaPortLm.IsOpen)
                {
                    SeriaPortLm.Close();
                    this.Invoke(new Action(() =>
                    {
                        ButtonStart.Text = "开始";
                    }));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("串口异常，请检查！");
            }
        }
        /// <summary>
        /// 提示栏清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClean_Click(object sender, EventArgs e)
        {
            textBoxMonitor.Clear();
        }

        HELP helpForm;
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path =@"help.txt";
            if (helpForm==null||helpForm.IsDisposed)
            {
                helpForm = new HELP();
                helpForm.Show();
                helpForm.textBoxHelp.AppendText(File.ReadAllText(path));
            }
            else
            {
                helpForm.Activate();//激活已经打开的窗口
            }
        }
        /// <summary>
        /// 串口接收数据处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        Byte[] Recdata = new Byte[6]; 
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {          
            SerialPort sp = (SerialPort)sender;
            int n = sp.BytesToRead;//只有接收数据等于6个时，才将数据放入数组中
            if (n == 6) { sp.Read(Recdata, 0, sp.BytesToRead); }
            if (Recdata[1] == 0x06)
            {
                intProCount = Int32.Parse(textBox_POfAmount.Text);
                intProCount++;
                this.Invoke(new Action(() =>
                {
                    textBox_POfAmount.Text = intProCount.ToString();
                }));
            }
            if ((Recdata[0]==0x58))//判断接收数据是否正确
            {
                if (Recdata[4] == (((Recdata[0]+ Recdata[1]+ Recdata[2]+ Recdata[3]) & 0XFF00)>> 8)&&
                   (Recdata[5] == ((Recdata[0] + Recdata[1] + Recdata[2] + Recdata[3]) & 0X00FF)))
                    {
                        intRecdata = Recdata[2];
                        intRecdata = (Int16)(Recdata[2] * 4 + Recdata[3]);
                     }
            } 
            this.Invoke(new Action(() =>
            {
                textBoxMonitor.AppendText(DateTime.Now+": 接收到的数据 "+ intRecdata + "\r\n");              
            }));
            Date_ProcessHandle();
        }
        /// <summary>
        /// 接收数据处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        limitForm tgklimitForm;
        private void Date_ProcessHandle()
        {
            DataCompare(intRecdata);
            try
            {
                if ((intRecdata == 1023)&& (Recdata[1] == 6))
                { 
                     SeriaPortLm.Write(OkOne, 0, 5);
                     this.Invoke(new Action(() =>
                        {
                            labelResult.BackColor = Color.Green;
                            labelResult.Text = "测试OK";
                     }));

                }
                else if ((intRecdata == 0)&& (Recdata[1] == 5))
                {
                     SeriaPortLm.Write(OkTwo, 0, 5);
                     this.Invoke(new Action(() =>
                        {
                            labelResult.BackColor = Color.Coral;
                            labelResult.Text = "测试OK";
                     }));
                }
                else
                {
                    intProFail = Int32.Parse(textBoxProductionOfFail.Text);
                    intProFail++;
                    SeriaPortLm.Write(NgData, 0, 5);
                    this.Invoke(new Action(() =>
                    {
                        textBoxProductionOfFail.Text = intProFail.ToString();
                        labelResult.BackColor = Color.Red;
                        labelResult.Text = "测试fail";
                        tgklimitForm = new limitForm
                        {
                            Owner = this,
                            StartPosition = FormStartPosition.CenterScreen
                        };
                        tgklimitForm.ShowDialog(this);
                    })); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请检查串口线！");
            }
        }
        /// <summary>
        /// 具体位置颜色显示
        /// </summary>
        /// <param name="intRecdata"></param>
        /// <param name="Colorset"></param>
        private void DataCompare(Int16 intRecdata)
        {           
            Int16 intRecdataSplit;
            for (int i = 1; i < 11; i++)
            {
                Control flagLabel = this.Controls.Find("Flag_label" + i.ToString(), true)[0];//通过空间名称搜索控件
                Label flagLabe = flagLabel as Label;
                intRecdataSplit = (Int16)((intRecdata >> (i-1)) & 0x01);
                if (intRecdataSplit == 1)
                {
                    flagLabe.BackColor = Color.Blue;
                }
                else
                {
                    flagLabe.BackColor = Color.Red;
                }
            }
        }
/// <summary>
/// 保存数据
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fileName = @"H:\TGK\Port_Upper_Computer\UpperComputer\UpperComputer\bin\Debug\password.XML";
            XDocument document = XDocument.Load("password.XML");
            XElement root = document.Root;
            XElement proCount = root.Element("proCount");  //读取表格产量数据
            XElement failCount = root.Element("failCount");//读取不良数据           
            proCount.SetValue(textBox_POfAmount.Text);
            failCount.SetValue(textBoxProductionOfFail.Text);
            document.Save(fileName);
        }
    }
}
