using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Leitner
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

            File.Copy(Directory.GetCurrentDirectory() + @"\Leitner.mdf", Directory.GetCurrentDirectory() + @"\BackUp\Leitner.mdf", true);
            File.Copy(Directory.GetCurrentDirectory() + @"\Leitner_log.ldf", Directory.GetCurrentDirectory() + @"\BackUp\Leitner_log.ldf", true);

        Login:
            LoginForm LoginFrm = new LoginForm();
            Application.Run(LoginFrm);

            if (LoginFrm.Valid_User == true)
            {
                MainForm MainFrm = new MainForm();
                Application.Run(MainFrm);

                if (MainFrm.Goto_Login == true)
                    goto Login;
            }
        }
    }
}
