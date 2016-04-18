using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Shutdown_Helper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isFirstInstance;
			// Please use a unique name for the mutex to prevent conflicts with other programs
            using (Mutex mtx = new Mutex(true, "e68ce0a4-b253-407e-aee6-81abd2986443", out isFirstInstance))
            {
				if (isFirstInstance)
				{
		        	Application.EnableVisualStyles();
		            Application.SetCompatibleTextRenderingDefault(false);
		            Application.Run(new FormMonitor());
				}
			}
        }
    }
}
