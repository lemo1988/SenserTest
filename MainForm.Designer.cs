namespace UpperComputer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPortset = new System.Windows.Forms.Panel();
            this.label6_PortBadurate = new System.Windows.Forms.Label();
            this.comboBox_PortStopbits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Portparity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Portdatebits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_PortBadurate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PortSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxMonitor = new System.Windows.Forms.TextBox();
            this.ParaSet = new System.Windows.Forms.GroupBox();
            this.textBoxProductionOfFail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_POfAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.Flag_label1 = new System.Windows.Forms.Label();
            this.Flag_label2 = new System.Windows.Forms.Label();
            this.Flag_label5 = new System.Windows.Forms.Label();
            this.Flag_label4 = new System.Windows.Forms.Label();
            this.Flag_label3 = new System.Windows.Forms.Label();
            this.Flag_label10 = new System.Windows.Forms.Label();
            this.Flag_label9 = new System.Windows.Forms.Label();
            this.Flag_label8 = new System.Windows.Forms.Label();
            this.Flag_label7 = new System.Windows.Forms.Label();
            this.Flag_label6 = new System.Windows.Forms.Label();
            this.panelPortset.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ParaSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPortset
            // 
            this.panelPortset.BackColor = System.Drawing.Color.Silver;
            this.panelPortset.Controls.Add(this.label6_PortBadurate);
            this.panelPortset.Controls.Add(this.comboBox_PortStopbits);
            this.panelPortset.Controls.Add(this.label5);
            this.panelPortset.Controls.Add(this.comboBox_Portparity);
            this.panelPortset.Controls.Add(this.label4);
            this.panelPortset.Controls.Add(this.comboBox_Portdatebits);
            this.panelPortset.Controls.Add(this.label3);
            this.panelPortset.Controls.Add(this.comboBox_PortBadurate);
            this.panelPortset.Controls.Add(this.label2);
            this.panelPortset.Controls.Add(this.comboBox_PortName);
            this.panelPortset.Controls.Add(this.label1);
            this.panelPortset.Location = new System.Drawing.Point(0, 40);
            this.panelPortset.Name = "panelPortset";
            this.panelPortset.Size = new System.Drawing.Size(857, 42);
            this.panelPortset.TabIndex = 0;
            this.panelPortset.Visible = false;
            // 
            // label6_PortBadurate
            // 
            this.label6_PortBadurate.AutoSize = true;
            this.label6_PortBadurate.Location = new System.Drawing.Point(162, 15);
            this.label6_PortBadurate.Name = "label6_PortBadurate";
            this.label6_PortBadurate.Size = new System.Drawing.Size(47, 12);
            this.label6_PortBadurate.TabIndex = 10;
            this.label6_PortBadurate.Text = "波特率:";
            // 
            // comboBox_PortStopbits
            // 
            this.comboBox_PortStopbits.FormattingEnabled = true;
            this.comboBox_PortStopbits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_PortStopbits.Location = new System.Drawing.Point(652, 12);
            this.comboBox_PortStopbits.Name = "comboBox_PortStopbits";
            this.comboBox_PortStopbits.Size = new System.Drawing.Size(71, 20);
            this.comboBox_PortStopbits.TabIndex = 9;
            this.comboBox_PortStopbits.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "停止位:";
            // 
            // comboBox_Portparity
            // 
            this.comboBox_Portparity.FormattingEnabled = true;
            this.comboBox_Portparity.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox_Portparity.Location = new System.Drawing.Point(502, 12);
            this.comboBox_Portparity.Name = "comboBox_Portparity";
            this.comboBox_Portparity.Size = new System.Drawing.Size(71, 20);
            this.comboBox_Portparity.TabIndex = 7;
            this.comboBox_Portparity.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "校验位:";
            // 
            // comboBox_Portdatebits
            // 
            this.comboBox_Portdatebits.FormattingEnabled = true;
            this.comboBox_Portdatebits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBox_Portdatebits.Location = new System.Drawing.Point(360, 12);
            this.comboBox_Portdatebits.Name = "comboBox_Portdatebits";
            this.comboBox_Portdatebits.Size = new System.Drawing.Size(71, 20);
            this.comboBox_Portdatebits.TabIndex = 5;
            this.comboBox_Portdatebits.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据位:";
            // 
            // comboBox_PortBadurate
            // 
            this.comboBox_PortBadurate.FormattingEnabled = true;
            this.comboBox_PortBadurate.Items.AddRange(new object[] {
            "115200",
            "9600",
            "4800"});
            this.comboBox_PortBadurate.Location = new System.Drawing.Point(215, 12);
            this.comboBox_PortBadurate.Name = "comboBox_PortBadurate";
            this.comboBox_PortBadurate.Size = new System.Drawing.Size(71, 20);
            this.comboBox_PortBadurate.TabIndex = 3;
            this.comboBox_PortBadurate.Text = "115200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 2;
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(65, 12);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(71, 20);
            this.comboBox_PortName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口名:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortSetToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PortSetToolStripMenuItem
            // 
            this.PortSetToolStripMenuItem.Name = "PortSetToolStripMenuItem";
            this.PortSetToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.PortSetToolStripMenuItem.Text = "PortSet";
            this.PortSetToolStripMenuItem.Click += new System.EventHandler(this.PortSetToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.帮助ToolStripMenuItem.Text = "Help";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelResult.Font = new System.Drawing.Font("华文隶书", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(8, 40);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(435, 315);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "等待测试";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMonitor
            // 
            this.textBoxMonitor.Location = new System.Drawing.Point(12, 400);
            this.textBoxMonitor.Multiline = true;
            this.textBoxMonitor.Name = "textBoxMonitor";
            this.textBoxMonitor.Size = new System.Drawing.Size(738, 150);
            this.textBoxMonitor.TabIndex = 3;
            // 
            // ParaSet
            // 
            this.ParaSet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ParaSet.Controls.Add(this.textBoxProductionOfFail);
            this.ParaSet.Controls.Add(this.label9);
            this.ParaSet.Controls.Add(this.textBox_POfAmount);
            this.ParaSet.Controls.Add(this.label7);
            this.ParaSet.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ParaSet.Location = new System.Drawing.Point(449, 40);
            this.ParaSet.Name = "ParaSet";
            this.ParaSet.Size = new System.Drawing.Size(301, 357);
            this.ParaSet.TabIndex = 4;
            this.ParaSet.TabStop = false;
            this.ParaSet.Text = "测试数据";
            // 
            // textBoxProductionOfFail
            // 
            this.textBoxProductionOfFail.Font = new System.Drawing.Font("华文楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxProductionOfFail.Location = new System.Drawing.Point(148, 171);
            this.textBoxProductionOfFail.Name = "textBoxProductionOfFail";
            this.textBoxProductionOfFail.Size = new System.Drawing.Size(115, 39);
            this.textBoxProductionOfFail.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(26, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "不良数：";
            // 
            // textBox_POfAmount
            // 
            this.textBox_POfAmount.Font = new System.Drawing.Font("华文楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_POfAmount.Location = new System.Drawing.Point(148, 116);
            this.textBox_POfAmount.Name = "textBox_POfAmount";
            this.textBox_POfAmount.Size = new System.Drawing.Size(115, 39);
            this.textBox_POfAmount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "总产量：";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonStart.Location = new System.Drawing.Point(756, 151);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(101, 51);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "开始";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClean.Location = new System.Drawing.Point(756, 457);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(101, 51);
            this.buttonClean.TabIndex = 6;
            this.buttonClean.Text = "清除";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.ButtonClean_Click);
            // 
            // Flag_label1
            // 
            this.Flag_label1.AutoSize = true;
            this.Flag_label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label1.Location = new System.Drawing.Point(62, 367);
            this.Flag_label1.Name = "Flag_label1";
            this.Flag_label1.Size = new System.Drawing.Size(21, 21);
            this.Flag_label1.TabIndex = 7;
            this.Flag_label1.Text = "1";
            // 
            // Flag_label2
            // 
            this.Flag_label2.AutoSize = true;
            this.Flag_label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label2.Location = new System.Drawing.Point(89, 367);
            this.Flag_label2.Name = "Flag_label2";
            this.Flag_label2.Size = new System.Drawing.Size(21, 21);
            this.Flag_label2.TabIndex = 8;
            this.Flag_label2.Text = "2";
            // 
            // Flag_label5
            // 
            this.Flag_label5.AutoSize = true;
            this.Flag_label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label5.Location = new System.Drawing.Point(170, 367);
            this.Flag_label5.Name = "Flag_label5";
            this.Flag_label5.Size = new System.Drawing.Size(21, 21);
            this.Flag_label5.TabIndex = 9;
            this.Flag_label5.Text = "5";
            // 
            // Flag_label4
            // 
            this.Flag_label4.AutoSize = true;
            this.Flag_label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label4.Location = new System.Drawing.Point(143, 367);
            this.Flag_label4.Name = "Flag_label4";
            this.Flag_label4.Size = new System.Drawing.Size(21, 21);
            this.Flag_label4.TabIndex = 10;
            this.Flag_label4.Text = "4";
            // 
            // Flag_label3
            // 
            this.Flag_label3.AutoSize = true;
            this.Flag_label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label3.Location = new System.Drawing.Point(116, 367);
            this.Flag_label3.Name = "Flag_label3";
            this.Flag_label3.Size = new System.Drawing.Size(21, 21);
            this.Flag_label3.TabIndex = 11;
            this.Flag_label3.Text = "3";
            // 
            // Flag_label10
            // 
            this.Flag_label10.AutoSize = true;
            this.Flag_label10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label10.Location = new System.Drawing.Point(305, 367);
            this.Flag_label10.Name = "Flag_label10";
            this.Flag_label10.Size = new System.Drawing.Size(32, 21);
            this.Flag_label10.TabIndex = 12;
            this.Flag_label10.Text = "10";
            // 
            // Flag_label9
            // 
            this.Flag_label9.AutoSize = true;
            this.Flag_label9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label9.Location = new System.Drawing.Point(278, 367);
            this.Flag_label9.Name = "Flag_label9";
            this.Flag_label9.Size = new System.Drawing.Size(21, 21);
            this.Flag_label9.TabIndex = 13;
            this.Flag_label9.Text = "9";
            // 
            // Flag_label8
            // 
            this.Flag_label8.AutoSize = true;
            this.Flag_label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label8.Location = new System.Drawing.Point(251, 367);
            this.Flag_label8.Name = "Flag_label8";
            this.Flag_label8.Size = new System.Drawing.Size(21, 21);
            this.Flag_label8.TabIndex = 14;
            this.Flag_label8.Text = "8";
            // 
            // Flag_label7
            // 
            this.Flag_label7.AutoSize = true;
            this.Flag_label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label7.Location = new System.Drawing.Point(224, 367);
            this.Flag_label7.Name = "Flag_label7";
            this.Flag_label7.Size = new System.Drawing.Size(21, 21);
            this.Flag_label7.TabIndex = 15;
            this.Flag_label7.Text = "7";
            // 
            // Flag_label6
            // 
            this.Flag_label6.AutoSize = true;
            this.Flag_label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Flag_label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flag_label6.Location = new System.Drawing.Point(197, 367);
            this.Flag_label6.Name = "Flag_label6";
            this.Flag_label6.Size = new System.Drawing.Size(21, 21);
            this.Flag_label6.TabIndex = 16;
            this.Flag_label6.Text = "6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(866, 562);
            this.Controls.Add(this.Flag_label6);
            this.Controls.Add(this.Flag_label7);
            this.Controls.Add(this.Flag_label8);
            this.Controls.Add(this.Flag_label9);
            this.Controls.Add(this.Flag_label10);
            this.Controls.Add(this.Flag_label3);
            this.Controls.Add(this.Flag_label4);
            this.Controls.Add(this.Flag_label5);
            this.Controls.Add(this.Flag_label2);
            this.Controls.Add(this.Flag_label1);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.textBoxMonitor);
            this.Controls.Add(this.panelPortset);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.ParaSet);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelPortset.ResumeLayout(false);
            this.panelPortset.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ParaSet.ResumeLayout(false);
            this.ParaSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPortset;
        private System.Windows.Forms.ComboBox comboBox_PortStopbits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Portparity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Portdatebits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_PortBadurate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PortSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Label label6_PortBadurate;
        private System.Windows.Forms.TextBox textBoxMonitor;
        private System.Windows.Forms.GroupBox ParaSet;
        private System.Windows.Forms.TextBox textBoxProductionOfFail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_POfAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Flag_label1;
        private System.Windows.Forms.Label Flag_label2;
        private System.Windows.Forms.Label Flag_label5;
        private System.Windows.Forms.Label Flag_label4;
        private System.Windows.Forms.Label Flag_label3;
        private System.Windows.Forms.Label Flag_label10;
        private System.Windows.Forms.Label Flag_label9;
        private System.Windows.Forms.Label Flag_label8;
        private System.Windows.Forms.Label Flag_label7;
        private System.Windows.Forms.Label Flag_label6;
        private System.Windows.Forms.Button buttonClean;
        public System.Windows.Forms.Label labelResult;
        public System.Windows.Forms.Button ButtonStart;
    }
}

