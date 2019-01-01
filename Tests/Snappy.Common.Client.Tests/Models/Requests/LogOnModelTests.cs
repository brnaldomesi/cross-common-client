using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
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

        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTYSTRING)]
        [TestCase(TestDataHelper.EMPTYSTRING, TestDataHelper.PASSWORD)]
        public void LogOnRequest_Argument_Validations(string email, string password)
        {
            Assert.Throws<ArgumentException>(() => { new LogOnRequest(email, password); });
        }
    }
}
