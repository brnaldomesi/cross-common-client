using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership.Organization.User;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    class UserInviteRequestTests
    {
        [Test]
        public void UserInviteRequest_Constructor()
        {
            var request = new UserInviteRequest(TestDataHelper.POSITIVE_NUMBER, TestDataHelper.EMAIL,
                                                TestDataHelper.STRING, TestDataHelper.STRING_1);
            Assert.AreEqual(TestDataHelper.POSITIVE_NUMBER, request.CurrentUserId);
            Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
            Assert.AreEqual(TestDataHelper.STRING, request.FirstName);
            Assert.AreEqual(TestDataHelper.STRING_1, request.LastName);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.STRING_1)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, TestDataHelper.STRING_1)]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1)]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, TestDataHelper.EMPTY_STRING)]
        public void UserInviteRequest_Argument_Validations(string email, string firstName, string lastName, int currentUserId = 0)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new UserInviteRequest(currentUserId, email, firstName, lastName);
            });
        }
    }
}
