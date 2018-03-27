using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SynFiles
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            string str = System.Windows.Forms.Application.StartupPath+"\\" + "setting.ini";
            if (!File.Exists(str))
            {
                File.Create(str);
            }

            Application.Run(new Form1());
        }
    }
}
