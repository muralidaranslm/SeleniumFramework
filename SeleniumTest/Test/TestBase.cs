using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumBase;

namespace SeleniumTest.Test
{
    [DeploymentItem("Config", "Config")]
    [DeploymentItem("Browser", "Browser")]
    [DeploymentItem("External", "External")]
    public class TestBase : Base
    {
        [TestInitialize]
        public void TestInit()
        {
            base.Init();
        }

        [TestCleanup]
        public void Cleanup()
        {
        }
    }
}