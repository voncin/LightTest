namespace LightTest
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.groupBoxSet = new System.Windows.Forms.GroupBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.groupBoxLight = new System.Windows.Forms.GroupBox();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.buttonOpenCom = new System.Windows.Forms.Button();
            this.buttonCloseCom = new System.Windows.Forms.Button();
            this.labelCom = new System.Windows.Forms.Label();
            this.textBoxRecived = new System.Windows.Forms.TextBox();
            this.labelRecived = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxSet.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxLight.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(16, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1段灯光";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(97, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2段灯光";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(178, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3段灯光";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(259, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "4段灯光";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(16, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "5段灯光";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(97, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "6段灯光";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(178, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "7段灯光";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(259, 49);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "8段灯光";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(340, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "9段灯光";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(16, 20);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "打开灯光";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Enabled = false;
            this.buttonClose.Location = new System.Drawing.Point(97, 20);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "关闭灯光";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Enabled = false;
            this.buttonRed.Location = new System.Drawing.Point(16, 20);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(75, 23);
            this.buttonRed.TabIndex = 11;
            this.buttonRed.Text = "打开红灯";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.Enabled = false;
            this.buttonGreen.Location = new System.Drawing.Point(97, 20);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(75, 23);
            this.buttonGreen.TabIndex = 12;
            this.buttonGreen.Text = "打开绿灯";
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.Enabled = false;
            this.buttonBlue.Location = new System.Drawing.Point(178, 20);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(75, 23);
            this.buttonBlue.TabIndex = 13;
            this.buttonBlue.Text = "打开黄灯";
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // groupBoxSet
            // 
            this.groupBoxSet.Controls.Add(this.button1);
            this.groupBoxSet.Controls.Add(this.button2);
            this.groupBoxSet.Controls.Add(this.button3);
            this.groupBoxSet.Controls.Add(this.button4);
            this.groupBoxSet.Controls.Add(this.button5);
            this.groupBoxSet.Controls.Add(this.button6);
            this.groupBoxSet.Controls.Add(this.button9);
            this.groupBoxSet.Controls.Add(this.button7);
            this.groupBoxSet.Controls.Add(this.button8);
            this.groupBoxSet.Location = new System.Drawing.Point(12, 141);
            this.groupBoxSet.Name = "groupBoxSet";
            this.groupBoxSet.Size = new System.Drawing.Size(560, 93);
            this.groupBoxSet.TabIndex = 14;
            this.groupBoxSet.TabStop = false;
            this.groupBoxSet.Text = "设置灯光段";
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.buttonRed);
            this.groupBoxColor.Controls.Add(this.buttonGreen);
            this.groupBoxColor.Controls.Add(this.buttonBlue);
            this.groupBoxColor.Location = new System.Drawing.Point(12, 75);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(560, 60);
            this.groupBoxColor.TabIndex = 17;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "颜色开关";
            // 
            // groupBoxLight
            // 
            this.groupBoxLight.Controls.Add(this.buttonOpen);
            this.groupBoxLight.Controls.Add(this.buttonClose);
            this.groupBoxLight.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLight.Name = "groupBoxLight";
            this.groupBoxLight.Size = new System.Drawing.Size(560, 57);
            this.groupBoxLight.TabIndex = 18;
            this.groupBoxLight.TabStop = false;
            this.groupBoxLight.Text = "灯光开关";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(109, 255);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(75, 20);
            this.comboBoxCom.TabIndex = 19;
            // 
            // buttonOpenCom
            // 
            this.buttonOpenCom.Location = new System.Drawing.Point(28, 281);
            this.buttonOpenCom.Name = "buttonOpenCom";
            this.buttonOpenCom.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenCom.TabIndex = 21;
            this.buttonOpenCom.Text = "打开串口";
            this.buttonOpenCom.UseVisualStyleBackColor = true;
            this.buttonOpenCom.Click += new System.EventHandler(this.buttonOpenCom_Click);
            // 
            // buttonCloseCom
            // 
            this.buttonCloseCom.Enabled = false;
            this.buttonCloseCom.Location = new System.Drawing.Point(109, 281);
            this.buttonCloseCom.Name = "buttonCloseCom";
            this.buttonCloseCom.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseCom.TabIndex = 22;
            this.buttonCloseCom.Text = "关闭串口";
            this.buttonCloseCom.UseVisualStyleBackColor = true;
            this.buttonCloseCom.Click += new System.EventHandler(this.buttonCloseCom_Click);
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(56, 258);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(47, 12);
            this.labelCom.TabIndex = 23;
            this.labelCom.Text = "串口号:";
            // 
            // textBoxRecived
            // 
            this.textBoxRecived.Location = new System.Drawing.Point(277, 255);
            this.textBoxRecived.Multiline = true;
            this.textBoxRecived.Name = "textBoxRecived";
            this.textBoxRecived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecived.Size = new System.Drawing.Size(295, 95);
            this.textBoxRecived.TabIndex = 24;
            // 
            // labelRecived
            // 
            this.labelRecived.AutoSize = true;
            this.labelRecived.Location = new System.Drawing.Point(188, 258);
            this.labelRecived.Name = "labelRecived";
            this.labelRecived.Size = new System.Drawing.Size(83, 12);
            this.labelRecived.TabIndex = 25;
            this.labelRecived.Text = "收到串口数据:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(196, 281);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "清空数据";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelRecived);
            this.Controls.Add(this.textBoxRecived);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.buttonCloseCom);
            this.Controls.Add(this.buttonOpenCom);
            this.Controls.Add(this.comboBoxCom);
            this.Controls.Add(this.groupBoxLight);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxSet);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "流水灯测试";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBoxSet.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxLight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.GroupBox groupBoxSet;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.GroupBox groupBoxLight;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Button buttonOpenCom;
        private System.Windows.Forms.Button buttonCloseCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textBoxRecived;
        private System.Windows.Forms.Label labelRecived;
        private System.Windows.Forms.Button buttonClear;
    }
}

