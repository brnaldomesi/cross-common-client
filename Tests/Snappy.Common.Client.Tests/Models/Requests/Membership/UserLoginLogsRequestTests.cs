using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;
using Snappy.Service.Common.Model.Requests.Admin;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
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