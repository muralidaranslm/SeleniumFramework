using System.IO;

namespace SeleniumBase.Utils
{
    public class ReadXML
    {
        public static string ReadXmlFile(string path)
        {
            string xml = "";
            StreamReader reader = new StreamReader(path);
            xml = reader.ReadToEnd();
            reader.Close();
            return xml;
        }
    }
}