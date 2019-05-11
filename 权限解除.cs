using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UpperComputer
{
    public partial class limitForm : Form
    {
        public limitForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                textBoxPassword.Clear();
            }));
        }
        /// <summary>
        /// 密码输入完成，确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Form1 a = (Form1)this.Owner;
        
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            //读取文件中的数据
            XDocument document = XDocument.Load("password.XML");
            XElement root = document.Root;
            XElement shuxing =root.Element("p");
            if (textBoxPassword.Text.Equals(shuxing.Value))
            {
                MainForm.pCurrentWin.labelResult.BackColor = Color.White;
                MainForm.pCurrentWin.labelResult.Text = "等待测试";
                MainForm.pCurrentWin.ButtonStart.Text = "开始";               
                MainForm.pCurrentWin.SeriaPortLm.Write(MainForm.pCurrentWin.OkTwo, 0, 5);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("请重新输入密码!");
            }
        }
    }
}
