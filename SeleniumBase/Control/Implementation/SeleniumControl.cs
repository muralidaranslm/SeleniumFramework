using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBase.Control.Interface;
using System;

namespace SeleniumBase.Control.Implementation
{
    public class SeleniumControl : ISeleniumControl
    {
        private readonly IWebElement nativeElement;

        public string xpath { get; set; }

        public SeleniumControl(IWebElement element)
        {
            nativeElement = element;
        }

        public SeleniumControl()
        {
        }

        public string GetAttribute(string attributeName)
        {
            IWebElement element = GetElement();
            return element.GetAttribute(attributeName);
        }

        public string GetCssValue(string property)
        {
            IWebElement element = GetElement();
            return element.GetCssValue(property);
        }

        public IWebElement GetElement()
        {
            IWebElement element = null;
            IWebDriver driver = Base.GetDriver();
            element = driver.FindElement(By.XPath(xpath));
            return element;
        }

        public void ScrollElement()
        {
            IWebElement element = GetElement();
            IWebDriver driver = Base.GetDriver();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public bool WaitForElement(int seconds)
        {
            IWebElement element = GetElement();
            IWebDriver driver = Base.GetDriver();
            var wait = new WebDriverWait((IWebDriver)Base.GetDriver(), TimeSpan.FromSeconds(seconds));
            IWebElement clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(element));
            if (clickableElement != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}