using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sword.WinStudyBoardSystem
{
    public partial class FrmMain : Form
    {
        private bool _isDragging = false;
        private Point _offset;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void uMeter1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Link_Click(object sender, EventArgs e)
        {
            
        }

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
    }
}
