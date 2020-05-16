using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTest.Test
{
    [DeploymentItem("Config", "Config")]
    [DeploymentItem("Browser", "Browser")]
    [DeploymentItem("External", "External")]
    public class TestBase
    {
        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void Cleanup()
        {
        }
    }
}