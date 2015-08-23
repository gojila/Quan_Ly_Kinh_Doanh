using System;
using System.Collections.Generic;

using System.Windows.Forms;
using Do_An_Quan_Ly_Kho.Main;

namespace quanlykho_quang_make
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
            //Application.Run(new CauHinhCSDL());
            Application.Run(new FrmMain());
            
        }
    }
}
