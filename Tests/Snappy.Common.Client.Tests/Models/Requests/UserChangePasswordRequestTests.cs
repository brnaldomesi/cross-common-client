using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    class UserChangePasswordRequestTests
    {
        [Test]
        public void UserChangePasswordRequest_Constructor()
        {
            var request = new UserChangePasswordRequest(TestDataHelper.CURRENT_USER_ID, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.OldPassword);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.NewPassword);
        }

        [TestCase("wrongPassword", TestDataHelper.PASSWORD, TestDataHelper.CURRENT_USER_ID)]
        [TestCase(TestDataHelper.PASSWORD, "wrongPassword", TestDataHelper.CURRENT_USER_ID)]
        [TestCase(TestDataHelper.PASSWORD, "wrongPassword")]
        public void UserChangePasswordRequest_Argument_Validations(string oldPassword, string newPassword, int currentUserId = 0)
        {
            Assert.Throws<ArgumentException>(() => { new UserChangePasswordRequest(currentUserId, oldPassword, newPassword); });
        }
    }
}
