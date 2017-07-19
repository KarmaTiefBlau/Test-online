using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_online
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
            FLogin f = new FLogin();
            switch (f.ShowDialog())
            {
                case DialogResult.Abort:
                    FTeacher fteacher = new FTeacher();
                    Application.Run(fteacher);
                    break;
                case DialogResult.OK:
                    FAdmin fadmin = new FAdmin();
                    Application.Run(fadmin);
                    break;
                default:
                    break;
            }
        }
    }
}
