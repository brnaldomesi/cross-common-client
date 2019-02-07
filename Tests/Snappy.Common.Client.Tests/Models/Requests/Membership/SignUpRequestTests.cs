using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership.Organization.User;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    class SignUpRequestTests
    {
        [Test]
        public void SignUpRequest_Constructor()
        {
            var request = new SignUpRequest(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.UID,
                                                     TestDataHelper.EMAIL, TestDataHelper.PASSWORD);
            Assert.AreEqual(TestDataHelper.STRING, request.FirstName);
            Assert.AreEqual(TestDataHelper.STRING_1, request.LastName);
            Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
            Assert.AreEqual(TestDataHelper.UID, request.OrganizationName);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.Password);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1, TestDataHelper.UID, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.UID, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.EMPTY_STRING, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.UID, "testtest.com", TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.UID, TestDataHelper.EMAIL, "wrongPass")]
        public void SignUpRequest_Argument_Validations(string firstName, string lastName,string organizationUid,
                                                       string email, string password)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new SignUpRequest(firstName, lastName, organizationUid, email, password);
            });
        }
    }
}
