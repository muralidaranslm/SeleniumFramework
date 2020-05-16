using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumBase
{
    public class Base
    {
        private static IWebDriver webdriver;

        public void Init()
        {
            OpenBrowser(GetBrowserOption(BrowserType.Chrome));
        }

        public void OpenBrowser(DriverOptions driverOptions)
        {
            switch (driverOptions)
            {
                case InternetExplorerOptions internetExplorerOptions:
                    driverOptions = new InternetExplorerOptions();
                    break;

                case FirefoxOptions firefoxOptions:
                    driverOptions = new FirefoxOptions();
                    firefoxOptions.AddAdditionalCapability(CapabilityType.BrowserName, "Firefox");
                    firefoxOptions.BrowserExecutableLocation = "";
                    driverOptions = firefoxOptions;
                    break;

                case ChromeOptions chromeOptions:
                    driverOptions = new ChromeOptions();
                    chromeOptions.AddAdditionalCapability(CapabilityType.BrowserName, "Chrome");
                    chromeOptions.BinaryLocation = "";
                    driverOptions = chromeOptions;
                    break;
            }
            webdriver = new RemoteWebDriver(new Uri("http://www.google.com"), driverOptions.ToCapabilities());
        }

        public DriverOptions GetBrowserOption(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeOptions();

                case BrowserType.Firefox:
                    return new FirefoxOptions();

                case BrowserType.IE:
                    return new InternetExplorerOptions();

                default:
                    return new ChromeOptions();
            }
        }
        public static IWebDriver GetDriver()
        {
            return webdriver;
        }
    }



    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }
}