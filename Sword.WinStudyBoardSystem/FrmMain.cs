using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;

namespace Sword.WinStudyBoardSystem
{
    public partial class FrmMain : Form
    {
        // 窗口拖动相关变量
        private bool _isDragging = false;
        private Point _offset;

        SerialPort serialPort;//串口对象

        public FrmMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            serialPort = new SerialPort();
            RefreshComList(); //刷新串口列表
            //下拉框初始化
            InitCombox();
        }

        #region 界面初始化
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //页面信息初始化
            InitFormInfo();
            //图表初始化
            InitPlot();
        }

        private void InitFormInfo()
        {
            //仪表值重置
            umTemperature.Value = 0;
            umHumidity.Value = 0;
            umBrightness.Value = 0;
            //历史值重置
            LB_Temp_Max.Text = "0.0";
            LB_Temp_Min.Text = "0.0";
            CB_Temp_Start.Checked = false;
            LB_Humi_Max.Text = "0";
            LB_Humi_Min.Text = "0";
            CB_Humi_Start.Checked = false;
            LB_Bright_Max.Text = "0";
            LB_Bright_Min.Text = "0";
            CB_Bright_Start.Checked = false;
            //曲线显示状态为true
            cb_Line_Temp.Checked = true;
            cb_Line_Humi.Checked = true;
            CB_Line_Bright.Checked = true;
            //消息显示区重置
            txt_ShowMsg.Text = "";
            txt_SendMsg.Text = "";
            //状态显示重置
            chkState_01.Checked = false;
            chkState_02.Checked = false;
            chkState_03.Checked = false;
            chkState_04.Checked = false;
            chkState_05.Checked = false;
            chkState_All.Checked = false;
            //连接状态默认
            LB_LinkText.Text = "等待学习卡连接";
            Btn_Connect.Text = "连接设备";
        }

        PlotModel plotModel=null; //图表模型
        DateTimeAxis dateTimeAxis; //时间轴
        LinearAxis valueAxis; //数值轴
        Random random = new Random();
        private void InitPlot()
        {
            plotModel = new PlotModel()
            {
                IsLegendVisible = false,
                PlotAreaBorderColor = OxyColors.LightGray,
                PlotAreaBackground = OxyColors.White
            };
            //时间轴
            dateTimeAxis = new DateTimeAxis()
            {
                MajorGridlineStyle = LineStyle.Dash,
                MajorGridlineThickness = 0,
                IntervalLength = 5,
                IntervalType = DateTimeIntervalType.Seconds,
                FontSize = 10,
                TextColor = OxyColors.Gray,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                AxislineColor = OxyColors.LightGray,
                StringFormat = "mm:ss"
            };
            plotModel.Axes.Add(dateTimeAxis);
            //数值轴
            valueAxis = new LinearAxis()
            {
                MajorGridlineStyle = LineStyle.Dash,
                IntervalLength = 20,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Maximum = 110,
                Minimum = -20,
                FontSize= 10,
                TextColor= OxyColors.Gray,
                AxislineColor= OxyColors.LightGray,
            };
            plotModel.Axes.Add(valueAxis);

            //添加3条曲线
            var seriesTemp = new OxyPlot.Series.LineSeries()
            {
                Color = OxyColors.OrangeRed,
                StrokeThickness = 1,
                MarkerType = MarkerType.None,
                Title = "温度",
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };
            var seriesHumi = new OxyPlot.Series.LineSeries()
            {
                Color = OxyColors.DeepSkyBlue,
                StrokeThickness = 1,
                MarkerType = MarkerType.None,
                Title = "湿度",
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };
            var seriesBright = new OxyPlot.Series.LineSeries()
            {
                Color = OxyColors.Orange,
                StrokeThickness = 1,
                MarkerType = MarkerType.None,
                Title = "亮度",
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };
            DateTime dateTime = DateTime.Now.AddSeconds(-20);
            plotModel.Axes[0].Minimum = DateTimeAxis.ToDouble(dateTime);
            for (int i = 0; i < 20; i++)
            {
                dateTime = dateTime.AddSeconds(1);
                seriesTemp.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(dateTime), random.Next(0,100)));
                seriesHumi.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(dateTime), random.Next(0, 100)));
                seriesBright.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(dateTime), random.Next(0, 100)));
                
            }
            plotModel.Axes[0].Maximum = DateTimeAxis.ToDouble(dateTime);
            plotModel.Series.Add(seriesTemp);
            plotModel.Series.Add(seriesHumi);
            plotModel.Series.Add(seriesBright);

            PV_Lines.Model = plotModel;
        }
        #endregion


        #region 下拉框初始化
        private void InitCombox()
        {
            //波特率
            CB_BaudRate.Items.Clear();
            CB_BaudRate.Items.AddRange(new object[] { "9600", "19200", "38400", "115200" });
            CB_BaudRate.SelectedIndex = 0;
            //数据位
            CB_DataBits.Items.Clear();
            CB_DataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            CB_DataBits.SelectedIndex = 3;
            //校验位
            CB_Parity.Items.Clear();
            CB_Parity.Items.AddRange(Enum.GetNames(typeof(Models.Parity))
                            .Select(name => Program.GetDescription((Models.Parity)Enum.Parse(typeof(Models.Parity), name)))
                            .ToArray());
            CB_Parity.SelectedIndex = 0;
            //停止位
            CB_StopBits.Items.Clear();
            CB_StopBits.Items.AddRange(Enum.GetNames(typeof(Models.StopBits))
                            .Select(name => Program.GetDescription((Models.StopBits)Enum.Parse(typeof(Models.StopBits), name)))
                            .ToArray());
            CB_StopBits.SelectedIndex = 1;
        }

        private void RefreshComList()
        {
            string currentSelection = CB_ComList.SelectedItem?.ToString();
            //刷新串口
            CB_ComList.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                CB_ComList.Items.AddRange(ports);
                if (!string.IsNullOrEmpty(currentSelection) && ports.Contains(currentSelection))
                {
                    CB_ComList.SelectedItem = currentSelection;
                }
                else
                {
                    CB_ComList.SelectedIndex = 0;
                }
            }
            else
            {
                CB_ComList.Items.Add("无可用串口");
                CB_ComList.SelectedIndex = 0;
            }
        }
        #endregion

        #region 边框绘制
        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(Pens.LightGray, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void PNL_Mid_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
        }
        #endregion

        #region 窗体移动
        private void Panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _offset = new Point(e.X, e.Y);
                Panel_Top.Capture = true;
            }
        }

        private void Panel_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                this.Left += e.X - _offset.X;
                this.Top += e.Y - _offset.Y;
            }
        }

        private void Panel_Top_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            Panel_Top.Capture = false;
        }
        #endregion

        #region 按钮事件
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {

        }

        private void Btn_SendText_Click(object sender, EventArgs e)
        {

        }

        private void Btn_RefreshCom_Click(object sender, EventArgs e)
        {
            RefreshComList();
        }
        #endregion


    }
}
