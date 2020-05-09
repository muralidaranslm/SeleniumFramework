using Selenium_Framework.Browser;
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
        public static void start()
        {
            KillProcess("chromedriver");
            KillProcess("chrome");
            SeleniumBrowser browser = new SeleniumBrowser();
            browser.Start("Chrome");
            browser.SetDriver(browser.GetDriver());
        }

        private static void KillProcess(string processName)
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
