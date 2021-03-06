using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Models;
using System.Diagnostics;

namespace LibraryManagerPro
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
            Process[] processArray = Process.GetProcesses();
            int currentCount = 0;
            foreach (var item in processArray)
            {
                if (item.ProcessName == Process.GetCurrentProcess().ProcessName)
                {
                    currentCount++;
                }
                if (currentCount > 1)
                {
                    MessageBox.Show("当前系统已启动", "提示信息");
                    Application.Exit();
                    return;
                }
            }
            FrmAdminLogin frmLogin = new FrmAdminLogin();
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
        }
        public static SysAdmin currentAdmin = null;
    }
}
