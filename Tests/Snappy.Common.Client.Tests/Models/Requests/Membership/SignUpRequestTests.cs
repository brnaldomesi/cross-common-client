using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    class SignUpRequestTests
    {
        [Test]
        public void SignUpRequest_Constructor()
        {
            var request = new SignUpRequest(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.STRING_2,
                                                     TestDataHelper.EMAIL, TestDataHelper.PASSWORD);
            Assert.AreEqual(TestDataHelper.STRING, request.FirstName);
            Assert.AreEqual(TestDataHelper.STRING_1, request.LastName);
            Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
            Assert.AreEqual(TestDataHelper.STRING_2, request.OrganizationName);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.Password);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1, TestDataHelper.STRING_2, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_2, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.EMPTY_STRING, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.STRING_2, "testtest.com", TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.STRING_2, TestDataHelper.EMAIL, "wrongPass")]
        public void SignUpRequest_Argument_Validations(string firstName, string lastName, string email,
                                                       string organizationName, string password)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new SignUpRequest(firstName, lastName, email, organizationName, password);
            });
        }
    }
}
