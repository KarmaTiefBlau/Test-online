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
                case DialogResult.OK:
                    FStuMain fmain = new FStuMain();
                    fmain.stuNumber = f.stuNumber;
                    Application.Run(fmain);
                    break;
                default:
                    break;
            }
        }
    }
}
