using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    class IntegrationCreateRequestTests
    {
        [Test]
        public void IntegrationCreateRequest_Constructor()
        {
            var request = new IntegrationCreateRequest(TestDataHelper.STRING, TestDataHelper.STRING_1);
            Assert.AreEqual(TestDataHelper.STRING, request.IntegrationName);
            Assert.AreEqual(TestDataHelper.STRING_1, request.Description);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING)]
        public void IntegrationCreateRequest_Argument_Validations(string integrationName, string description)
        {
            Assert.Throws<ArgumentException>(() => { new IntegrationCreateRequest(integrationName, description); });
        }
    }
}
