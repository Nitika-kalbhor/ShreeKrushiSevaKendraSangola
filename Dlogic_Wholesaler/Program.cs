using System;
using System.Collections.Generic;
using System.Linq;

using Dlogic_Wholesaler.Forms;
using System.Windows.Forms;
using Dlogic_Wholesaler.ReportFrom;

namespace Dlogic_Wholesaler
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
           Application.Run(new frmLogin());
           // Application.Run(new ImportExcel());
        }
    }
}
