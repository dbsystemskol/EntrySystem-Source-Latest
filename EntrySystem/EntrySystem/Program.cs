using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EntrySystem;
using EntrySystem.Class;
using EntrySystem.Forms;
using log4net;
using log4net.Config;

namespace EntrySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmReportCardPrinting());
                Application.Run(new frmLogin());
                if (CommonVariables.isConnect == true)
                {
                    Application.Run(new MDIParent());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }
    }
}
