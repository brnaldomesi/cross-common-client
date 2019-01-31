using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    class UserAcceptInviteRequestTests
    {
        [Test]
        public void UserAcceptInviteRequest_Constructor()
        {
            var request = new UserAcceptInviteRequest(TestDataHelper.STRING, TestDataHelper.STRING_1,
                                                               TestDataHelper.PASSWORD, TestDataHelper.PASSWORD);
            Assert.AreEqual(TestDataHelper.STRING, request.FirstName);
            Assert.AreEqual(TestDataHelper.STRING_1, request.LastName);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.Password);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.ReEnterPassword);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1)]
        public void UserAcceptInviteRequest_Argument_Validations(string firstName, string lastName, string password,
                                                                 string reEnterPassword)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new UserAcceptInviteRequest(firstName, lastName, password, reEnterPassword);
            });
        }
    }
}
