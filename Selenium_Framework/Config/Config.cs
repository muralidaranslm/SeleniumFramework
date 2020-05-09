using System.IO;

namespace Selenium_Framework.Config
{
    public class Config
    {
        private static string GetAppConfigXml()
        {
            string path = "Config\\AppConfig.xml";
            return Read(path);
        }

        private static string GetEnvXml()
        {
            string path = "Config\\EnvironmentConfig.xml";
            return Read(path);
        }

        public static string Read(string file)
        {
            StreamReader reader = new StreamReader(file);
            string xml = reader.ReadToEnd();
            reader.Close();
            return xml;
        }

        public static void LoadAllConfig()
        {
            new Environment().Load(GetEnvXml());
        }
    }
}