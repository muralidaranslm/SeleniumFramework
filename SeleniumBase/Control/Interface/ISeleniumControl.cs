using OpenQA.Selenium;

namespace SeleniumBase.Control.Interface
{
    internal interface ISeleniumControl
    {
        IWebElement GetElement();

        void ScrollElement();

        string GetAttribute(string attributeName);

        string GetCssValue(string property);

        bool WaitForElement(int seconds);
    }
}