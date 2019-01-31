using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class IntegrationReadRequestTests
    {
        [Test]
        public void IntegrationReadRequest_Constructor()
        {
            var request = new IntegrationReadRequest(TestDataHelper.UID);

            Assert.AreEqual(TestDataHelper.UID, request.IntegrationUid);
        }

        [TestCase(TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.STRING)]
        public void IntegrationReadRequest_Argument_Validations(string integrationUid)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new IntegrationReadRequest(integrationUid);
            });
        }
    }
}