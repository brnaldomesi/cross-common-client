using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class PermissionLogsRequestTests
    {
        [Test]
        public void PermissionLogsRequest_Constructor()
        {
            var request = new PermissionLogsRequest(TestDataHelper.CURRENT_USER_ID);
            Assert.AreEqual(TestDataHelper.CURRENT_USER_ID, request.CurrentUserId);
        }
    }
}