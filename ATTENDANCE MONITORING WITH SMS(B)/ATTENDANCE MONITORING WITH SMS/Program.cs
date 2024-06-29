using LUBANG_ATTENDANCE;
using LUBANG_ATTENDANCE.FormAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUBANG_ATTENDANCE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormReport.FormReport());
            Application.Run(new FormStudent());
            //Application.Run(new FormAdmin.FormStudent());
        }
    }
}
