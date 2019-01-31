using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class PermissionLogsRequestTests
    {
        [Test]
        public void PermissionLogsRequest_Constructor()
        {
            var request = new PermissionLogsRequest(TestDataHelper.POSITIVE_NUMBER);

            Assert.AreEqual(TestDataHelper.POSITIVE_NUMBER, request.CurrentUserId);
        }
    }
}