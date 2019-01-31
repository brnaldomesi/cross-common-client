using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;
using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class UserDetailRequestTests
    {
        [Test]
        public void UserDetailRequest_Constructor()
        {
            var request = new UserDetailRequest(TestDataHelper.UID);
            Assert.AreEqual(TestDataHelper.UID, request.UserUid);
        }
    }
}