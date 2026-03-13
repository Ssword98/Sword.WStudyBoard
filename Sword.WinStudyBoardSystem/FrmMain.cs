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

namespace Sword.WinStudyBoardSystem
{
    public partial class FrmMain : Form
    {
        // 窗口拖动相关变量
        private bool _isDragging = false;
        private Point _offset;
        // 边框宽度（可自定义）
        private readonly int _borderWidth = 1;
        // 圆角半径（可自定义）
        private readonly int _cornerRadius = 10;

        public FrmMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Btn_RefreshCom_Click(null, null);
            //下拉框初始化
            InitCombox();
        }

        #region 下拉框初始化
        private void InitCombox()
        {
            CB_BaudRate.Items.AddRange(new object[] { "9600", "19200", "38400", "115200" });
            CB_BaudRate.SelectedIndex = 0;
            CB_DataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            CB_DataBits.SelectedIndex = 3;
            CB_Parity.Items.AddRange(Enum.GetNames(typeof(Models.Parity))
                            .Select(name => Program.GetDescription((Models.Parity)Enum.Parse(typeof(Models.Parity), name)))
                            .ToArray());
            CB_Parity.SelectedIndex = 0;
            CB_StopBits.Items.AddRange(Enum.GetNames(typeof(Models.StopBits))
                            .Select(name => Program.GetDescription((Models.StopBits)Enum.Parse(typeof(Models.StopBits), name)))
                            .ToArray());
            CB_StopBits.SelectedIndex = 1;
        }
        #endregion

        #region 按钮事件
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void Btn_RefreshCom_Click(object sender, EventArgs e)
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

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            // 不在事件处理器中调用 base.OnPaint(e) —— 这会触发 Paint 事件并可能导致递归
            Graphics g = e.Graphics;
            // 抗锯齿，让边框/圆角更平滑
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 计算用于绘制的矩形（按边框宽度做内缩，避免被截断）
            Rectangle rect = new Rectangle(_borderWidth / 2,
                                           _borderWidth / 2,
                                           Math.Max(0, this.ClientSize.Width - _borderWidth),
                                           Math.Max(0, this.ClientSize.Height - _borderWidth));

            using (Pen borderPen = new Pen(Color.FromArgb(51, 153, 255), _borderWidth))
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, _cornerRadius))
            {
                g.DrawPath(borderPen, path);
            }
        }

        // Helper: create a rounded rectangle path
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(rect);
                path.CloseFigure();
                return path;
            }

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);

            Rectangle arc = new Rectangle(rect.Location, size);

            // top-left arc
            path.AddArc(arc, 180, 90);

            // top-right arc
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom-right arc
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom-left arc
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
