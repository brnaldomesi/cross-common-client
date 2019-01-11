using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class UserDetailRequestTests
    {
        [Test]
        public void UserDetailRequest_Constructor()
        {
            var request = new UserDetailRequest(TestDataHelper.CURRENT_USER_ID);
            Assert.AreEqual(TestDataHelper.CURRENT_USER_ID, request.CurrentUserId);
        }
    }
}