using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership.Organization.User;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class PasswordResetRequestTests
    {
        [Test]
        public void PasswordResetRequest_Constructor()
        {
            var request = new PasswordResetRequest(TestDataHelper.Uid, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD);

            Assert.AreEqual(TestDataHelper.Uid, request.UserUid);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.Password);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.ReEnterPassword);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.Uid, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.Uid, TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.Uid, TestDataHelper.STRING, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.Uid, TestDataHelper.PASSWORD, TestDataHelper.STRING)]
        [TestCase(TestDataHelper.Uid, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1)]
        public void PasswordResetRequest_Argument_Validations(string userUid, string password, string reEnterPassword)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new PasswordResetRequest(userUid, password, reEnterPassword);
            });
        }
    }
}