using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    class UserAcceptInviteRequestTests
    {
        [Test]
        public void UserAcceptInviteRequest_Constructor()
        {
            var request = new UserAcceptInviteRequest(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.PASSWORD);
            Assert.AreEqual(TestDataHelper.FIRSTNAME, request.FirstName);
            Assert.AreEqual(TestDataHelper.LASTNAME, request.LastName);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.Password);
        }

        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, "Test+")]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.LASTNAME, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.EMPTY_STRING)]
        public void UserAcceptInviteRequest_Argument_Validations(string firstName, string lastName, string password)
        {
            Assert.Throws<ArgumentException>(() => { new UserAcceptInviteRequest(firstName, lastName, password); });
        }

    }
}
