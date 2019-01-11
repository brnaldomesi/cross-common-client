using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class UserLoginLogsModelTests
    {
        [Test]
        public void UserLoginLogsModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "user_login_logs_title");
        }

        private static UserLoginLogsModel GetModel()
        {
            return new UserLoginLogsModel();
        }
    }
}