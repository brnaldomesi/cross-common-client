using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class UserLoginLogsRequestTests
    {
        [Test]
        public void UserLoginLogsRequest_Constructor()
        {
            var request = new UserLoginLogsRequest(TestDataHelper.CURRENT_USER_ID);
            Assert.AreEqual(TestDataHelper.CURRENT_USER_ID, request.CurrentUserId);
        }
    }
}