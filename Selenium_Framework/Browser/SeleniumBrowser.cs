using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Framework.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Selenium_Framework.Browser
{
    public class SeleniumBrowser
    {
        IWebDriver driver;
        public void Start(string browserType)
        {
            switch (browserType)
            {
                case "Chrome":
                    StartChrome("www.google.com", "External\\chromedriver.exe");
                    break;
            }
        }
        public void StartChrome(string url,string driverPath)
        {
            ChromeOptions options = new ChromeOptions();
            string path = "Browser\\BrowserCapabilities.xml";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(ReadXML.ReadXmlFile(path));
            XmlNodeList nodes = doc.SelectNodes("//AppSettings/ChromeBrowser/UserProfilePreferences");
            foreach (XmlNode node in nodes)
            {
                XmlElement envNode = (XmlElement)node;
                XmlNodeList xmlCollection = envNode.ChildNodes;
                for (int i = 0; i < xmlCollection.Count; i++)
                {
                    XmlElement element = (XmlElement)xmlCollection[i];
                    string key = element.GetAttribute("key");
                    string value = element.GetAttribute("value");
                    options.AddUserProfilePreference(key, value);
                }
            }
            XmlNodeList argumentNodes = doc.SelectNodes("//AppSettings/ChromeBrowser/Arguments");
            foreach (XmlNode node in argumentNodes)
            {
                XmlElement envNode = (XmlElement)node;
                XmlNodeList xmlCollection = envNode.ChildNodes;
                for (int i = 0; i < xmlCollection.Count; i++)
                {
                    XmlElement element = (XmlElement)xmlCollection[i];
                    string key = element.GetAttribute("key");
                    options.AddArgument(key);
                }
            }
            driver = new ChromeDriver(driverPath, options, TimeSpan.FromMinutes(4));
            driver.Url = url;
            driver.Navigate();
        }
        public IWebDriver GetDriver()
        {
            return this.driver;
        }

        public void SetDriver(object driver)
        {
            this.driver = (IWebDriver)driver;
        }

    }
}
