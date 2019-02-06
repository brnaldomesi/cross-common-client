using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership.Organization.User;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class UserDetailRequestTests
    {
        [Test]
        public void UserDetailRequest_Constructor()
        {
            var request = new UserDetailRequest(TestDataHelper.Uid);
            Assert.AreEqual(TestDataHelper.Uid, request.UserUid);
        }
    }
}