using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    class LogOnModelTests
    {
        [Test]
        public void LogOnRequest_Constructor()
        {
            var request = new LogOnRequest(TestDataHelper.EMAIL, TestDataHelper.PASSWORD);
            Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
            Assert.AreEqual(TestDataHelper.PASSWORD, request.Password);
        }

        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD)]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING)]
        public void LogOnRequest_Argument_Validations(string email, string password)
        {
            Assert.Throws<ArgumentException>(() => { new LogOnRequest(email, password); });
        }
    }
}
