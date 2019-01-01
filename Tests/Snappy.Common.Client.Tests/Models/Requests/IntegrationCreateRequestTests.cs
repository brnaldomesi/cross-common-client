using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    class IntegrationCreateRequestTests
    {
        [Test]
        public void IntegrationCreateRequest_Constructor()
        {
            var request = new IntegrationCreateRequest(TestDataHelper.NAME, TestDataHelper.DESCRIPTION);
            Assert.AreEqual(TestDataHelper.NAME, request.IntegrationName);
            Assert.AreEqual(TestDataHelper.DESCRIPTION, request.Description);
        }

        [TestCase(TestDataHelper.EMPTYSTRING, TestDataHelper.EMPTYSTRING),
         TestCase(TestDataHelper.EMPTYSTRING, TestDataHelper.DESCRIPTION)]
        public void IntegrationCreateRequest_Argument_Validations(string integrationName, string description)
        {
            Assert.Throws<ArgumentException>(() => { new IntegrationCreateRequest(integrationName, description); });
        }
    }
}
