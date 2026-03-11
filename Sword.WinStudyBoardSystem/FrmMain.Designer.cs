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
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_RefreshCom = new System.Windows.Forms.Button();
            this.CB_ComList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uMeter1 = new Zhaoxi.CustControls.UMeter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel2.Controls.Add(this.comboBox5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox2);
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
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(765, 14);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 20);
            this.comboBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "停止位";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(606, 14);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 20);
            this.comboBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "数据位";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(448, 15);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 20);
            this.comboBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "校验位";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
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
            this.CB_ComList.Location = new System.Drawing.Point(50, 14);
            this.CB_ComList.Name = "CB_ComList";
            this.CB_ComList.Size = new System.Drawing.Size(100, 20);
            this.CB_ComList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "串口";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.uMeter1);
            this.panel3.Location = new System.Drawing.Point(22, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 330);
            this.panel3.TabIndex = 3;
            // 
            // uMeter1
            // 
            this.uMeter1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.uMeter1.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.uMeter1.Header = "Temperature";
            this.uMeter1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.uMeter1.Location = new System.Drawing.Point(33, 55);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1140, 680);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Top);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_RefreshCom;
        private Zhaoxi.CustControls.UMeter uMeter1;
    }
}

