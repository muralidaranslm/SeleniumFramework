using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Framework.Driver
{
    public class Application
    {
        public void start()
        {
            KillProcess("chromedriver");
            KillProcess("chrome");

        }
        private void KillProcess(string processName)
        {
            Process[] process = Process.GetProcessesByName(processName);
            foreach (Process pr in process)
            {
                try
                {
                    pr.Kill();
                }
                catch (Exception exe)
                {
                    throw exe;
                    //Console.WriteLine(LogGen.GetExceptionOccurrence(exe.Message));
                    //Console.WriteLine(LogGen.GetExceptionStackTrace(exe.StackTrace));
                }
            }
        }
    }
}
