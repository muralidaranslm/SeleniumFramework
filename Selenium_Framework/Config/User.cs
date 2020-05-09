using System.Xml;

namespace Selenium_Framework.Config
{
    public class User
    {
        /// <summary>
        /// Get or sets the user name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public string Password { get; set; }

        public void Load(XmlElement element)
        {
            this.UserName = element.GetAttribute("User");
            this.Password = element.GetAttribute("Pass");
        }
    }
}