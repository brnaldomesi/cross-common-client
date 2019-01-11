using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class PermissionLogsModelTests
    {
        [Test]
        public void PermissionLogsModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "permission_logs_title");
        }

        private static PermissionLogsModel GetModel()
        {
            return new PermissionLogsModel();
        }
    }
}