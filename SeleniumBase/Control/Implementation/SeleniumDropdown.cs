using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBase.Control.Interface;

namespace SeleniumBase.Control.Implementation
{
    public class SeleniumDropdown : SeleniumControl, ISeleniumDropdown
    {
        public void SelectByVisibleText(string text)
        {
            IWebElement element = GetElement();
            if (element != null)
            {
                SelectElement SelectElement = new SelectElement(element);
                SelectElement.SelectByText(text);
            }
        }
    }
}