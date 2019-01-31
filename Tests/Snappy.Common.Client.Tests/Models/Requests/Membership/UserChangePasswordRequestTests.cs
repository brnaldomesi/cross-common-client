﻿using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
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
                                                                    TestDataHelper.PASSWORD, TestDataHelper.PASSWORD);

            Assert.AreEqual(TestDataHelper.POSITIVE_NUMBER, request.CurrentUserId);
            Assert.AreEqual(TestDataHelper.PASSWORD_1, request.OldPassword);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.NewPassword);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.ReEnterNewPassword);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD_1)]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1)]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD_2)]
        public void UserChangePasswordRequest_Argument_Validations(string oldPassword, string newPassword, string reEnterNewPassword,
                                                                   int currentUserId = 0)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new UserChangePasswordRequest(currentUserId, oldPassword, newPassword, reEnterNewPassword);
            });
        }
    }
}