using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Client;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class IntegrationTokenShowSecretRequestTests
    {
        [Test]
        public void IntegrationTokenShowSecretRequest_Constructor()
        {
            var request = new IntegrationClientSecretRequest(TestDataHelper.Uid);

            Assert.AreEqual(TestDataHelper.Uid, request.ClientUid);
        }

        [TestCase(TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.Uid)]
        public void IntegrationTokenShowSecretRequest_Argument_Validations(string clientUid)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new IntegrationClientSecretRequest(clientUid);
            });
        }
    }
}