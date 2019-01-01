using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    class SignUpRequestTests
    {
        [Test]
        public void SignUpRequest_Constructor()
        {
            var request = new SignUpRequest(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.NAME
                , TestDataHelper.EMAIL, TestDataHelper.PASSWORD);
            Assert.AreEqual(TestDataHelper.FIRSTNAME, request.FirstName);
            Assert.AreEqual(TestDataHelper.LASTNAME, request.LastName);
            Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
            Assert.AreEqual(TestDataHelper.NAME, request.OrganizationName);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.Password);
        }

        [TestCase(TestDataHelper.EMPTYSTRING, TestDataHelper.LASTNAME, TestDataHelper.NAME, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.EMPTYSTRING, TestDataHelper.NAME, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.EMPTYSTRING, TestDataHelper.EMAIL, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.NAME, "testtest.com", TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.NAME, TestDataHelper.EMAIL, "wrongPass")]
        public void SignUpRequest_Argument_Validations(string firstName, string lastName, string email, string organizationName, string password)
        {
            Assert.Throws<ArgumentException>(() => { new SignUpRequest(firstName, lastName, email, organizationName, password); });
        }


    }
}
