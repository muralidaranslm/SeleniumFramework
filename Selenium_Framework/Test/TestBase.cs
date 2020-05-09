using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_Framework.Config;

namespace Selenium_Framework.Test
{
    [DeploymentItem("Config", "Config")]
    [DeploymentItem("Browser", "Browser")]
    [DeploymentItem("External", "Dlls")]

    public class TestBase
    {
        [TestInitialize]
        public void TestInit()
        {
            Config.Config.LoadAllConfig();
            //TO DO logger
        }

        [TestCleanup]
        public void Cleanup()
        {
        }
    }
}