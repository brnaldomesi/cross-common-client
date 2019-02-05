using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership.Organization.User;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    class UserChangePasswordRequestTests
    {
        [Test]
        public void UserChangePasswordRequest_Constructor()
        {
            var request = new UserChangePasswordRequest(TestDataHelper.POSITIVE_NUMBER, TestDataHelper.PASSWORD_1,
                                                                    TestDataHelper.PASSWORD);

            Assert.AreEqual(TestDataHelper.POSITIVE_NUMBER, request.CurrentUserId);
            Assert.AreEqual(TestDataHelper.PASSWORD_1, request.OldPassword);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.NewPassword);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1)]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING)]
        public void UserChangePasswordRequest_Argument_Validations(string oldPassword, string newPassword,
                                                                   int currentUserId = 0)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new UserChangePasswordRequest(currentUserId, oldPassword, newPassword);
            });
        }
    }
}
