using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class UserPasswordResetRequestTests
    {
        [Test]
        public void UserPasswordResetRequest_Constructor()
        {
            var request = new Snappy.Common.Client.Models.Requests.UserPasswordResetRequest(TestDataHelper.EMAIL, TestDataHelper.TOKEN, TestDataHelper.PASSWORD);
            Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
            Assert.AreEqual(TestDataHelper.TOKEN, request.Token);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.Password);
        }

        [TestCase("testtest.com", TestDataHelper.TOKEN, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.EMAIL, "wrongToken", TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.TOKEN, "wrongPassword")]
        public void UserPasswordResetRequest_Argument_Validations(string email, string token, string password)
        {
            Assert.Throws<ArgumentException>(() => { new UserPasswordResetRequest(email, token, password); });
        }
    }
}