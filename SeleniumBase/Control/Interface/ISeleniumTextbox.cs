namespace SeleniumBase.Control.Interface
{
    internal interface ISeleniumTextbox : ISeleniumControl
    {
        void SetText(string text);

        string GetText();
    }
}