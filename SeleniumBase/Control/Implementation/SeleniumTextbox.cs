using OpenQA.Selenium;
using SeleniumBase.Control.Interface;

namespace SeleniumBase.Control.Implementation
{
    public class SeleniumTextbox : SeleniumControl, ISeleniumTextbox
    {
        public string GetText()
        {
            IWebElement element = GetElement();
            return element.GetAttribute("value");
        }

        public void SetText(string text)
        {
            IWebElement element = GetElement();
            element.Clear();
            element.SendKeys(text.Trim());
        }
    }
}