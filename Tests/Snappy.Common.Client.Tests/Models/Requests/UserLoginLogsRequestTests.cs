using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;
using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class UserLoginLogsRequestTests
    {
        [Test]
        public void UserLoginLogsRequest_Constructor()
        {
            var request = new UserLoginLogsRequest(TestDataHelper.POSITIVE_NUMBER);
            Assert.AreEqual(TestDataHelper.POSITIVE_NUMBER, request.CurrentUserId);
        }
    }
}