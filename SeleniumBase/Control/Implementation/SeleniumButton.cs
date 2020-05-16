using OpenQA.Selenium;
using SeleniumBase.Control.Interface;

namespace SeleniumBase.Control.Implementation
{
    public class SeleniumButton : SeleniumControl, ISeleniumButton
    {
        public void ClickElementByJS()
        {
        }

        public void SendKeys(string text)
        {
            IWebElement element = GetElement();
            element.SendKeys(text);
        }
    }
}