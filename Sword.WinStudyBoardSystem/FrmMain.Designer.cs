namespace Sword.WinStudyBoardSystem
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.LB_LinkText = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.CB_StopBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_DataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_BaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_RefreshCom = new System.Windows.Forms.Button();
            this.CB_ComList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_SendText = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uMeter3 = new Zhaoxi.CustControls.UMeter();
            this.uMeter2 = new Zhaoxi.CustControls.UMeter();
            this.uMeter1 = new Zhaoxi.CustControls.UMeter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.PV_Lines = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sword.WinStudyBoardSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_Top
            // 
            this.Panel_Top.Controls.Add(this.LB_LinkText);
            this.Panel_Top.Controls.Add(this.Btn_Close);
            this.Panel_Top.Controls.Add(this.label1);
            this.Panel_Top.Controls.Add(this.pictureBox1);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(1140, 70);
            this.Panel_Top.TabIndex = 1;
            this.Panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseDown);
            this.Panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseMove);
            this.Panel_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseUp);
            // 
            // LB_LinkText
            // 
            this.LB_LinkText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_LinkText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_LinkText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LB_LinkText.Location = new System.Drawing.Point(829, 22);
            this.LB_LinkText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LinkText.Name = "LB_LinkText";
            this.LB_LinkText.Size = new System.Drawing.Size(214, 24);
            this.LB_LinkText.TabIndex = 3;
            this.LB_LinkText.Text = "连接成功,正在监控学习卡数据信息!";
            this.LB_LinkText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Close.Location = new System.Drawing.Point(1047, 17);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(65, 35);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modbus学习卡监控系统";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.Btn_Connect);
            this.panel2.Controls.Add(this.CB_StopBits);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CB_DataBits);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CB_Parity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CB_BaudRate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Btn_RefreshCom);
            this.panel2.Controls.Add(this.CB_ComList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(22, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 45);
            this.panel2.TabIndex = 2;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(941, 8);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(80, 30);
            this.Btn_Connect.TabIndex = 11;
            this.Btn_Connect.Text = "连接设备";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // CB_StopBits
            // 
            this.CB_StopBits.FormattingEnabled = true;
            this.CB_StopBits.Location = new System.Drawing.Point(772, 12);
            this.CB_StopBits.Name = "CB_StopBits";
            this.CB_StopBits.Size = new System.Drawing.Size(100, 25);
            this.CB_StopBits.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "停止位";
            // 
            // CB_DataBits
            // 
            this.CB_DataBits.FormattingEnabled = true;
            this.CB_DataBits.Location = new System.Drawing.Point(608, 12);
            this.CB_DataBits.Name = "CB_DataBits";
            this.CB_DataBits.Size = new System.Drawing.Size(100, 25);
            this.CB_DataBits.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "数据位";
            // 
            // CB_Parity
            // 
            this.CB_Parity.FormattingEnabled = true;
            this.CB_Parity.Location = new System.Drawing.Point(445, 12);
            this.CB_Parity.Name = "CB_Parity";
            this.CB_Parity.Size = new System.Drawing.Size(100, 25);
            this.CB_Parity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "校验位";
            // 
            // CB_BaudRate
            // 
            this.CB_BaudRate.FormattingEnabled = true;
            this.CB_BaudRate.Location = new System.Drawing.Point(279, 12);
            this.CB_BaudRate.Name = "CB_BaudRate";
            this.CB_BaudRate.Size = new System.Drawing.Size(100, 25);
            this.CB_BaudRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "波特率";
            // 
            // Btn_RefreshCom
            // 
            this.Btn_RefreshCom.Location = new System.Drawing.Point(156, 12);
            this.Btn_RefreshCom.Name = "Btn_RefreshCom";
            this.Btn_RefreshCom.Size = new System.Drawing.Size(70, 23);
            this.Btn_RefreshCom.TabIndex = 2;
            this.Btn_RefreshCom.Text = "刷新";
            this.Btn_RefreshCom.UseVisualStyleBackColor = true;
            this.Btn_RefreshCom.Click += new System.EventHandler(this.Btn_RefreshCom_Click);
            // 
            // CB_ComList
            // 
            this.CB_ComList.FormattingEnabled = true;
            this.CB_ComList.Location = new System.Drawing.Point(50, 12);
            this.CB_ComList.Name = "CB_ComList";
            this.CB_ComList.Size = new System.Drawing.Size(100, 25);
            this.CB_ComList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "串口";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.uMeter3);
            this.panel3.Controls.Add(this.uMeter2);
            this.panel3.Controls.Add(this.uMeter1);
            this.panel3.Location = new System.Drawing.Point(22, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 330);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.Btn_SendText);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(810, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 300);
            this.panel1.TabIndex = 3;
            // 
            // Btn_SendText
            // 
            this.Btn_SendText.Location = new System.Drawing.Point(7, 262);
            this.Btn_SendText.Name = "Btn_SendText";
            this.Btn_SendText.Size = new System.Drawing.Size(252, 35);
            this.Btn_SendText.TabIndex = 5;
            this.Btn_SendText.Text = "发送文本";
            this.Btn_SendText.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 108);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "NiHao";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GrayText;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(253, 96);
            this.label11.TabIndex = 3;
            this.label11.Text = "NiHao";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(4, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "输入显示的字符串(英文-60)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "OLED显示屏";
            // 
            // uMeter3
            // 
            this.uMeter3.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.uMeter3.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.uMeter3.Header = "Temperature";
            this.uMeter3.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.uMeter3.Location = new System.Drawing.Point(473, 38);
            this.uMeter3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uMeter3.MaxValue = 50;
            this.uMeter3.MinValue = 0;
            this.uMeter3.Name = "uMeter3";
            this.uMeter3.PointColor = System.Drawing.Color.Red;
            this.uMeter3.ScaleLineColor = System.Drawing.Color.Gray;
            this.uMeter3.ScaleValueColor = System.Drawing.Color.Gray;
            this.uMeter3.Size = new System.Drawing.Size(148, 148);
            this.uMeter3.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.uMeter3.TabIndex = 2;
            this.uMeter3.Unit = "℃";
            this.uMeter3.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.uMeter3.Value = 0D;
            this.uMeter3.ValueColor = System.Drawing.Color.White;
            // 
            // uMeter2
            // 
            this.uMeter2.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.uMeter2.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.uMeter2.Header = "Temperature";
            this.uMeter2.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.uMeter2.Location = new System.Drawing.Point(248, 36);
            this.uMeter2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uMeter2.MaxValue = 50;
            this.uMeter2.MinValue = 0;
            this.uMeter2.Name = "uMeter2";
            this.uMeter2.PointColor = System.Drawing.Color.Red;
            this.uMeter2.ScaleLineColor = System.Drawing.Color.Gray;
            this.uMeter2.ScaleValueColor = System.Drawing.Color.Gray;
            this.uMeter2.Size = new System.Drawing.Size(148, 148);
            this.uMeter2.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.uMeter2.TabIndex = 1;
            this.uMeter2.Unit = "℃";
            this.uMeter2.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.uMeter2.Value = 0D;
            this.uMeter2.ValueColor = System.Drawing.Color.White;
            // 
            // uMeter1
            // 
            this.uMeter1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.uMeter1.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.uMeter1.Header = "Temperature";
            this.uMeter1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.uMeter1.Location = new System.Drawing.Point(32, 36);
            this.uMeter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uMeter1.MaxValue = 50;
            this.uMeter1.MinValue = 0;
            this.uMeter1.Name = "uMeter1";
            this.uMeter1.PointColor = System.Drawing.Color.Red;
            this.uMeter1.ScaleLineColor = System.Drawing.Color.Gray;
            this.uMeter1.ScaleValueColor = System.Drawing.Color.Gray;
            this.uMeter1.Size = new System.Drawing.Size(148, 148);
            this.uMeter1.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.uMeter1.TabIndex = 0;
            this.uMeter1.Unit = "℃";
            this.uMeter1.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.uMeter1.Value = 0D;
            this.uMeter1.ValueColor = System.Drawing.Color.White;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(18, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = ">>实时曲线";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(757, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = ">>状态监控";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBox1.Location = new System.Drawing.Point(522, 461);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "温度";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBox2.Location = new System.Drawing.Point(576, 461);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "湿度";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.ForeColor = System.Drawing.Color.Orange;
            this.checkBox3.Location = new System.Drawing.Point(630, 461);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 21);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "亮度";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // PV_Lines
            // 
            this.PV_Lines.BackColor = System.Drawing.Color.White;
            this.PV_Lines.Location = new System.Drawing.Point(22, 488);
            this.PV_Lines.Name = "PV_Lines";
            this.PV_Lines.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PV_Lines.Size = new System.Drawing.Size(706, 156);
            this.PV_Lines.TabIndex = 9;
            this.PV_Lines.Text = "plotView1";
            this.PV_Lines.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PV_Lines.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PV_Lines.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1140, 680);
            this.Controls.Add(this.PV_Lines);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Top);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modbus学习卡监控系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_LinkText;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CB_ComList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.ComboBox CB_StopBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_DataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_RefreshCom;
        private Zhaoxi.CustControls.UMeter uMeter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private OxyPlot.WindowsForms.PlotView PV_Lines;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private Zhaoxi.CustControls.UMeter uMeter3;
        private Zhaoxi.CustControls.UMeter uMeter2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_SendText;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

