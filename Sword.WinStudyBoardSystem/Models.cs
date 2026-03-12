using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sword.WinStudyBoardSystem
{
    internal class Models
    {
        public enum Parity
        {
            [Description("无校验")]
            None,

            [Description("奇校验")]
            Odd,

            [Description("偶校验")]
            Even,

            [Description("标记校验")]
            Mark,

            [Description("空格校验")]
            Space
        }

        public enum StopBits
        {
            [Description("无")]
            None,
            [Description("1位")]
            One,
            [Description("1.5位")]
            OnePointFive,
            [Description("2位")]
            Two
        }
    }
}
