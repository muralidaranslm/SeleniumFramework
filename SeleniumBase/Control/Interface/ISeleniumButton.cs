namespace SeleniumBase.Control.Interface
{
    internal interface ISeleniumButton : ISeleniumControl
    {
        void ClickElementByJS();

        void SendKeys(string text);
    }
}