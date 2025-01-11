using Newtonsoft.Json;
using PBSpyGUI.PBSpy;
using PBSpyGUI.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBSpyGUI
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
//            TestClass.Test();
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
