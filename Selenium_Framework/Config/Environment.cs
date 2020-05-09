using System.Collections.Generic;
using System.Xml;

namespace Selenium_Framework.Config
{
    public class Environment
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<User> Users { get; set; }
        private static Dictionary<string, Environment> environments = new Dictionary<string, Environment>();

        public Environment()
        {
            Users = new List<User>();
        }

        /// <summary>
        /// Loads the test environment
        /// </summary>
        /// <param name="xml"> xml document as string</param>
        public void Load(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList nodes = doc.SelectNodes("//Environments/Environment");
            foreach (XmlNode node in nodes)
            {
                Environment env = new Environment();
                env.Load(node);
                bool result = !(environments.ContainsKey(env.Name)) ? SafeAdd(env.Name, env, environments) : false;
            }
        }

        public static bool SafeAdd(string key, Environment value, Dictionary<string, Environment> dictionary)
        {
            environments[key] = value;
            return true;
        }

        private void Load(XmlNode node)
        {
            XmlElement element = (XmlElement)node;
            this.Name = element.GetAttribute("Name");
            this.Url = element.GetAttribute("Url");

            XmlNodeList users = element.GetElementsByTagName("User");
            foreach (XmlNode userNode in users)
            {
                XmlElement userEl = (XmlElement)userNode;
                User user = new User();
                user.Load(userEl);
                Users.Add(user);
            }
        }

        public static Environment Get(string name)
        {
            return environments[name];
        }
    }
}