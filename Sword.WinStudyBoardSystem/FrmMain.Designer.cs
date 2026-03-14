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
            this.PNL_Mid = new System.Windows.Forms.Panel();
            this.CB_Bright_Start = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.LB_Bright_Min = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.LB_Bright_Max = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.CB_Humi_Start = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LB_Humi_Min = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.LB_Humi_Max = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.CB_Temp_Start = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LB_Temp_Min = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LB_Temp_Max = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_SendText = new System.Windows.Forms.Button();
            this.txt_SendMsg = new System.Windows.Forms.RichTextBox();
            this.txt_ShowMsg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.umBrightness = new Zhaoxi.CustControls.UMeter();
            this.umHumidity = new Zhaoxi.CustControls.UMeter();
            this.umTemperature = new Zhaoxi.CustControls.UMeter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Line_Temp = new System.Windows.Forms.CheckBox();
            this.cb_Line_Humi = new System.Windows.Forms.CheckBox();
            this.CB_Line_Bright = new System.Windows.Forms.CheckBox();
            this.PV_Lines = new OxyPlot.WindowsForms.PlotView();
            this.chkState_01 = new System.Windows.Forms.CheckBox();
            this.chkState_02 = new System.Windows.Forms.CheckBox();
            this.chkState_03 = new System.Windows.Forms.CheckBox();
            this.chkState_04 = new System.Windows.Forms.CheckBox();
            this.chkState_05 = new System.Windows.Forms.CheckBox();
            this.chkState_All = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PNL_Mid.SuspendLayout();
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
            this.Panel_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Top.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Top.Controls.Add(this.LB_LinkText);
            this.Panel_Top.Controls.Add(this.Btn_Close);
            this.Panel_Top.Controls.Add(this.label1);
            this.Panel_Top.Controls.Add(this.pictureBox1);
            this.Panel_Top.Location = new System.Drawing.Point(1, 1);
            this.Panel_Top.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(1138, 70);
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
            this.LB_LinkText.Location = new System.Drawing.Point(827, 22);
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
            this.Btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Close.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Close.Location = new System.Drawing.Point(1045, 17);
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
            // PNL_Mid
            // 
            this.PNL_Mid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Mid.BackColor = System.Drawing.Color.White;
            this.PNL_Mid.Controls.Add(this.CB_Bright_Start);
            this.PNL_Mid.Controls.Add(this.label29);
            this.PNL_Mid.Controls.Add(this.label30);
            this.PNL_Mid.Controls.Add(this.LB_Bright_Min);
            this.PNL_Mid.Controls.Add(this.label32);
            this.PNL_Mid.Controls.Add(this.label33);
            this.PNL_Mid.Controls.Add(this.LB_Bright_Max);
            this.PNL_Mid.Controls.Add(this.label35);
            this.PNL_Mid.Controls.Add(this.CB_Humi_Start);
            this.PNL_Mid.Controls.Add(this.label21);
            this.PNL_Mid.Controls.Add(this.label22);
            this.PNL_Mid.Controls.Add(this.LB_Humi_Min);
            this.PNL_Mid.Controls.Add(this.label25);
            this.PNL_Mid.Controls.Add(this.label26);
            this.PNL_Mid.Controls.Add(this.LB_Humi_Max);
            this.PNL_Mid.Controls.Add(this.label28);
            this.PNL_Mid.Controls.Add(this.CB_Temp_Start);
            this.PNL_Mid.Controls.Add(this.label23);
            this.PNL_Mid.Controls.Add(this.label18);
            this.PNL_Mid.Controls.Add(this.LB_Temp_Min);
            this.PNL_Mid.Controls.Add(this.label20);
            this.PNL_Mid.Controls.Add(this.label17);
            this.PNL_Mid.Controls.Add(this.LB_Temp_Max);
            this.PNL_Mid.Controls.Add(this.label15);
            this.PNL_Mid.Controls.Add(this.label14);
            this.PNL_Mid.Controls.Add(this.label13);
            this.PNL_Mid.Controls.Add(this.label12);
            this.PNL_Mid.Controls.Add(this.panel1);
            this.PNL_Mid.Controls.Add(this.umBrightness);
            this.PNL_Mid.Controls.Add(this.umHumidity);
            this.PNL_Mid.Controls.Add(this.umTemperature);
            this.PNL_Mid.Location = new System.Drawing.Point(22, 125);
            this.PNL_Mid.Name = "PNL_Mid";
            this.PNL_Mid.Size = new System.Drawing.Size(1090, 330);
            this.PNL_Mid.TabIndex = 3;
            this.PNL_Mid.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Mid_Paint);
            // 
            // CB_Bright_Start
            // 
            this.CB_Bright_Start.AutoSize = true;
            this.CB_Bright_Start.Location = new System.Drawing.Point(699, 271);
            this.CB_Bright_Start.Name = "CB_Bright_Start";
            this.CB_Bright_Start.Size = new System.Drawing.Size(15, 14);
            this.CB_Bright_Start.TabIndex = 30;
            this.CB_Bright_Start.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(561, 271);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 17);
            this.label29.TabIndex = 29;
            this.label29.Text = "[启用模拟]";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(696, 234);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 17);
            this.label30.TabIndex = 28;
            this.label30.Text = "cd/m2";
            // 
            // LB_Bright_Min
            // 
            this.LB_Bright_Min.AutoSize = true;
            this.LB_Bright_Min.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Bright_Min.Location = new System.Drawing.Point(641, 234);
            this.LB_Bright_Min.Name = "LB_Bright_Min";
            this.LB_Bright_Min.Size = new System.Drawing.Size(27, 19);
            this.LB_Bright_Min.TabIndex = 27;
            this.LB_Bright_Min.Text = "66";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(561, 234);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 17);
            this.label32.TabIndex = 26;
            this.label32.Text = "[历史最低]";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(696, 198);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(45, 17);
            this.label33.TabIndex = 25;
            this.label33.Text = "cd/m2";
            // 
            // LB_Bright_Max
            // 
            this.LB_Bright_Max.AutoSize = true;
            this.LB_Bright_Max.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Bright_Max.Location = new System.Drawing.Point(641, 198);
            this.LB_Bright_Max.Name = "LB_Bright_Max";
            this.LB_Bright_Max.Size = new System.Drawing.Size(27, 19);
            this.LB_Bright_Max.TabIndex = 24;
            this.LB_Bright_Max.Text = "66";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(561, 198);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(64, 17);
            this.label35.TabIndex = 23;
            this.label35.Text = "[历史最高]";
            // 
            // CB_Humi_Start
            // 
            this.CB_Humi_Start.AutoSize = true;
            this.CB_Humi_Start.Location = new System.Drawing.Point(444, 271);
            this.CB_Humi_Start.Name = "CB_Humi_Start";
            this.CB_Humi_Start.Size = new System.Drawing.Size(15, 14);
            this.CB_Humi_Start.TabIndex = 22;
            this.CB_Humi_Start.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(306, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 17);
            this.label21.TabIndex = 21;
            this.label21.Text = "[启用模拟]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(441, 234);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 17);
            this.label22.TabIndex = 20;
            this.label22.Text = "%";
            // 
            // LB_Humi_Min
            // 
            this.LB_Humi_Min.AutoSize = true;
            this.LB_Humi_Min.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Humi_Min.Location = new System.Drawing.Point(386, 234);
            this.LB_Humi_Min.Name = "LB_Humi_Min";
            this.LB_Humi_Min.Size = new System.Drawing.Size(27, 19);
            this.LB_Humi_Min.TabIndex = 19;
            this.LB_Humi_Min.Text = "66";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(306, 234);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 17);
            this.label25.TabIndex = 18;
            this.label25.Text = "[历史最低]";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(441, 198);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 17);
            this.label26.TabIndex = 17;
            this.label26.Text = "%";
            // 
            // LB_Humi_Max
            // 
            this.LB_Humi_Max.AutoSize = true;
            this.LB_Humi_Max.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Humi_Max.Location = new System.Drawing.Point(386, 198);
            this.LB_Humi_Max.Name = "LB_Humi_Max";
            this.LB_Humi_Max.Size = new System.Drawing.Size(27, 19);
            this.LB_Humi_Max.TabIndex = 16;
            this.LB_Humi_Max.Text = "66";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(306, 198);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 17);
            this.label28.TabIndex = 15;
            this.label28.Text = "[历史最高]";
            // 
            // CB_Temp_Start
            // 
            this.CB_Temp_Start.AutoSize = true;
            this.CB_Temp_Start.Location = new System.Drawing.Point(181, 271);
            this.CB_Temp_Start.Name = "CB_Temp_Start";
            this.CB_Temp_Start.Size = new System.Drawing.Size(15, 14);
            this.CB_Temp_Start.TabIndex = 14;
            this.CB_Temp_Start.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(43, 271);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 17);
            this.label23.TabIndex = 13;
            this.label23.Text = "[启用模拟]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 17);
            this.label18.TabIndex = 12;
            this.label18.Text = "℃";
            // 
            // LB_Temp_Min
            // 
            this.LB_Temp_Min.AutoSize = true;
            this.LB_Temp_Min.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Temp_Min.Location = new System.Drawing.Point(123, 234);
            this.LB_Temp_Min.Name = "LB_Temp_Min";
            this.LB_Temp_Min.Size = new System.Drawing.Size(27, 19);
            this.LB_Temp_Min.TabIndex = 11;
            this.LB_Temp_Min.Text = "66";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 234);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 10;
            this.label20.Text = "[历史最低]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(178, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 17);
            this.label17.TabIndex = 9;
            this.label17.Text = "℃";
            // 
            // LB_Temp_Max
            // 
            this.LB_Temp_Max.AutoSize = true;
            this.LB_Temp_Max.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Temp_Max.Location = new System.Drawing.Point(123, 198);
            this.LB_Temp_Max.Name = "LB_Temp_Max";
            this.LB_Temp_Max.Size = new System.Drawing.Size(27, 19);
            this.LB_Temp_Max.TabIndex = 8;
            this.LB_Temp_Max.Text = "66";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "[历史最高]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightGray;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(622, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "亮度";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(366, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "湿度";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(108, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "温度";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.Btn_SendText);
            this.panel1.Controls.Add(this.txt_SendMsg);
            this.panel1.Controls.Add(this.txt_ShowMsg);
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
            this.Btn_SendText.Click += new System.EventHandler(this.Btn_SendText_Click);
            // 
            // txt_SendMsg
            // 
            this.txt_SendMsg.Location = new System.Drawing.Point(7, 149);
            this.txt_SendMsg.Name = "txt_SendMsg";
            this.txt_SendMsg.Size = new System.Drawing.Size(252, 108);
            this.txt_SendMsg.TabIndex = 4;
            this.txt_SendMsg.Text = "NiHao";
            // 
            // txt_ShowMsg
            // 
            this.txt_ShowMsg.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_ShowMsg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ShowMsg.ForeColor = System.Drawing.Color.Aqua;
            this.txt_ShowMsg.Location = new System.Drawing.Point(6, 22);
            this.txt_ShowMsg.Name = "txt_ShowMsg";
            this.txt_ShowMsg.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txt_ShowMsg.Size = new System.Drawing.Size(253, 96);
            this.txt_ShowMsg.TabIndex = 3;
            this.txt_ShowMsg.Text = "NiHao";
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
            // umBrightness
            // 
            this.umBrightness.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.umBrightness.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.umBrightness.Header = "Brightness";
            this.umBrightness.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umBrightness.Location = new System.Drawing.Point(564, 38);
            this.umBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.umBrightness.MaxValue = 100;
            this.umBrightness.MinValue = 0;
            this.umBrightness.Name = "umBrightness";
            this.umBrightness.PointColor = System.Drawing.Color.Red;
            this.umBrightness.ScaleLineColor = System.Drawing.Color.Gray;
            this.umBrightness.ScaleValueColor = System.Drawing.Color.Gray;
            this.umBrightness.Size = new System.Drawing.Size(148, 148);
            this.umBrightness.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.umBrightness.TabIndex = 2;
            this.umBrightness.Unit = "cd/m2";
            this.umBrightness.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umBrightness.Value = 0D;
            this.umBrightness.ValueColor = System.Drawing.Color.White;
            // 
            // umHumidity
            // 
            this.umHumidity.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.umHumidity.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.umHumidity.Header = "Humidity";
            this.umHumidity.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umHumidity.Location = new System.Drawing.Point(309, 38);
            this.umHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.umHumidity.MaxValue = 100;
            this.umHumidity.MinValue = 0;
            this.umHumidity.Name = "umHumidity";
            this.umHumidity.PointColor = System.Drawing.Color.Red;
            this.umHumidity.ScaleLineColor = System.Drawing.Color.Gray;
            this.umHumidity.ScaleValueColor = System.Drawing.Color.Gray;
            this.umHumidity.Size = new System.Drawing.Size(148, 148);
            this.umHumidity.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.umHumidity.TabIndex = 1;
            this.umHumidity.Unit = "%";
            this.umHumidity.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umHumidity.Value = 0D;
            this.umHumidity.ValueColor = System.Drawing.Color.White;
            // 
            // umTemperature
            // 
            this.umTemperature.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.umTemperature.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.umTemperature.Header = "Temperature";
            this.umTemperature.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umTemperature.Location = new System.Drawing.Point(50, 38);
            this.umTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.umTemperature.MaxValue = 90;
            this.umTemperature.MinValue = -10;
            this.umTemperature.Name = "umTemperature";
            this.umTemperature.PointColor = System.Drawing.Color.Red;
            this.umTemperature.ScaleLineColor = System.Drawing.Color.Gray;
            this.umTemperature.ScaleValueColor = System.Drawing.Color.Gray;
            this.umTemperature.Size = new System.Drawing.Size(148, 148);
            this.umTemperature.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.umTemperature.TabIndex = 0;
            this.umTemperature.Unit = "℃";
            this.umTemperature.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umTemperature.Value = 0D;
            this.umTemperature.ValueColor = System.Drawing.Color.White;
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
            // cb_Line_Temp
            // 
            this.cb_Line_Temp.AutoSize = true;
            this.cb_Line_Temp.Checked = true;
            this.cb_Line_Temp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Line_Temp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_Line_Temp.ForeColor = System.Drawing.Color.OrangeRed;
            this.cb_Line_Temp.Location = new System.Drawing.Point(522, 461);
            this.cb_Line_Temp.Name = "cb_Line_Temp";
            this.cb_Line_Temp.Size = new System.Drawing.Size(51, 21);
            this.cb_Line_Temp.TabIndex = 6;
            this.cb_Line_Temp.Text = "温度";
            this.cb_Line_Temp.UseVisualStyleBackColor = true;
            // 
            // cb_Line_Humi
            // 
            this.cb_Line_Humi.AutoSize = true;
            this.cb_Line_Humi.Checked = true;
            this.cb_Line_Humi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Line_Humi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_Line_Humi.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Line_Humi.Location = new System.Drawing.Point(576, 461);
            this.cb_Line_Humi.Name = "cb_Line_Humi";
            this.cb_Line_Humi.Size = new System.Drawing.Size(51, 21);
            this.cb_Line_Humi.TabIndex = 7;
            this.cb_Line_Humi.Text = "湿度";
            this.cb_Line_Humi.UseVisualStyleBackColor = true;
            // 
            // CB_Line_Bright
            // 
            this.CB_Line_Bright.AutoSize = true;
            this.CB_Line_Bright.Checked = true;
            this.CB_Line_Bright.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Line_Bright.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_Line_Bright.ForeColor = System.Drawing.Color.Orange;
            this.CB_Line_Bright.Location = new System.Drawing.Point(630, 461);
            this.CB_Line_Bright.Name = "CB_Line_Bright";
            this.CB_Line_Bright.Size = new System.Drawing.Size(51, 21);
            this.CB_Line_Bright.TabIndex = 8;
            this.CB_Line_Bright.Text = "亮度";
            this.CB_Line_Bright.UseVisualStyleBackColor = true;
            // 
            // PV_Lines
            // 
            this.PV_Lines.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            // chkState_01
            // 
            this.chkState_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.chkState_01.Location = new System.Drawing.Point(761, 489);
            this.chkState_01.Name = "chkState_01";
            this.chkState_01.Padding = new System.Windows.Forms.Padding(10);
            this.chkState_01.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkState_01.Size = new System.Drawing.Size(75, 60);
            this.chkState_01.TabIndex = 10;
            this.chkState_01.Tag = "0";
            this.chkState_01.Text = "1号灯珠";
            this.chkState_01.UseVisualStyleBackColor = false;
            // 
            // chkState_02
            // 
            this.chkState_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.chkState_02.Location = new System.Drawing.Point(894, 489);
            this.chkState_02.Name = "chkState_02";
            this.chkState_02.Padding = new System.Windows.Forms.Padding(10);
            this.chkState_02.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkState_02.Size = new System.Drawing.Size(75, 60);
            this.chkState_02.TabIndex = 11;
            this.chkState_02.Tag = "1";
            this.chkState_02.Text = "2号灯珠";
            this.chkState_02.UseVisualStyleBackColor = false;
            // 
            // chkState_03
            // 
            this.chkState_03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.chkState_03.Location = new System.Drawing.Point(1023, 489);
            this.chkState_03.Name = "chkState_03";
            this.chkState_03.Padding = new System.Windows.Forms.Padding(10);
            this.chkState_03.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkState_03.Size = new System.Drawing.Size(75, 60);
            this.chkState_03.TabIndex = 11;
            this.chkState_03.Tag = "2";
            this.chkState_03.Text = "3号灯珠";
            this.chkState_03.UseVisualStyleBackColor = false;
            // 
            // chkState_04
            // 
            this.chkState_04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.chkState_04.Location = new System.Drawing.Point(761, 555);
            this.chkState_04.Name = "chkState_04";
            this.chkState_04.Padding = new System.Windows.Forms.Padding(10);
            this.chkState_04.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkState_04.Size = new System.Drawing.Size(75, 60);
            this.chkState_04.TabIndex = 10;
            this.chkState_04.Tag = "3";
            this.chkState_04.Text = "4号灯珠";
            this.chkState_04.UseVisualStyleBackColor = false;
            // 
            // chkState_05
            // 
            this.chkState_05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.chkState_05.Location = new System.Drawing.Point(894, 555);
            this.chkState_05.Name = "chkState_05";
            this.chkState_05.Padding = new System.Windows.Forms.Padding(10);
            this.chkState_05.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkState_05.Size = new System.Drawing.Size(75, 60);
            this.chkState_05.TabIndex = 11;
            this.chkState_05.Tag = "4";
            this.chkState_05.Text = "5号灯珠";
            this.chkState_05.UseVisualStyleBackColor = false;
            // 
            // chkState_All
            // 
            this.chkState_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.chkState_All.Location = new System.Drawing.Point(1023, 555);
            this.chkState_All.Name = "chkState_All";
            this.chkState_All.Padding = new System.Windows.Forms.Padding(10);
            this.chkState_All.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkState_All.Size = new System.Drawing.Size(75, 60);
            this.chkState_All.TabIndex = 11;
            this.chkState_All.Tag = "all";
            this.chkState_All.Text = "统一控制";
            this.chkState_All.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.Btn_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.Btn_Close;
            this.ClientSize = new System.Drawing.Size(1140, 680);
            this.Controls.Add(this.chkState_All);
            this.Controls.Add(this.chkState_03);
            this.Controls.Add(this.chkState_05);
            this.Controls.Add(this.chkState_02);
            this.Controls.Add(this.chkState_04);
            this.Controls.Add(this.chkState_01);
            this.Controls.Add(this.PV_Lines);
            this.Controls.Add(this.CB_Line_Bright);
            this.Controls.Add(this.cb_Line_Humi);
            this.Controls.Add(this.cb_Line_Temp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PNL_Mid);
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
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PNL_Mid.ResumeLayout(false);
            this.PNL_Mid.PerformLayout();
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
        private System.Windows.Forms.Panel PNL_Mid;
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
        private Zhaoxi.CustControls.UMeter umTemperature;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_Line_Temp;
        private System.Windows.Forms.CheckBox cb_Line_Humi;
        private System.Windows.Forms.CheckBox CB_Line_Bright;
        private OxyPlot.WindowsForms.PlotView PV_Lines;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private Zhaoxi.CustControls.UMeter umBrightness;
        private Zhaoxi.CustControls.UMeter umHumidity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_ShowMsg;
        private System.Windows.Forms.Button Btn_SendText;
        private System.Windows.Forms.RichTextBox txt_SendMsg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LB_Temp_Max;
        private System.Windows.Forms.CheckBox CB_Temp_Start;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LB_Temp_Min;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox CB_Bright_Start;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label LB_Bright_Min;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label LB_Bright_Max;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox CB_Humi_Start;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LB_Humi_Min;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label LB_Humi_Max;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox chkState_01;
        private System.Windows.Forms.CheckBox chkState_02;
        private System.Windows.Forms.CheckBox chkState_03;
        private System.Windows.Forms.CheckBox chkState_04;
        private System.Windows.Forms.CheckBox chkState_05;
        private System.Windows.Forms.CheckBox chkState_All;
    }
}

