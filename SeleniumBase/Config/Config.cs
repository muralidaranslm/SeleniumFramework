using System.Collections.Generic;

namespace SeleniumBase
{
    public class Config
    {
        private Dictionary<string, EnvironmentDetails> Environments { get; set; }
    }

    internal class EnvironmentDetails
    {
        private string Url;
        private List<User> Users { get; set; }
    }

    internal class User
    {
        private string UserName { get; set; }
        private string Password { get; set; }
    }
}