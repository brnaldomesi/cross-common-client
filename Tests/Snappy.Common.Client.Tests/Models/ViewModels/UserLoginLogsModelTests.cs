using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class UserLoginLogsModelTests : BaseViewModelTest<UserLoginLogsModel>
    {
        public UserLoginLogsModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void UserLoginLogsModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "user_login_logs_title");
        }
    }
}