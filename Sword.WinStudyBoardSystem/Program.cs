using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sword.WinStudyBoardSystem
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        public static string GetDescription(Enum value)
        {
            // 获取枚举类型
            Type type = value.GetType();
            // 获取枚举常量的名称（如 "Even"）
            string name = Enum.GetName(type, value);

            if (name != null)
            {
                // 通过反射获取该常量对应的字段信息
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    // 查找该字段上的 DescriptionAttribute 特性
                    DescriptionAttribute attr =
                        Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                        as DescriptionAttribute;

                    // 如果找到了特性，并且描述不为空，则返回描述内容
                    if (attr != null && !string.IsNullOrEmpty(attr.Description))
                    {
                        return attr.Description;
                    }
                }
            }

            // 如果没有找到描述，则直接返回枚举名称（如 "Even"）
            return value.ToString();
        }

    }
}
