using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class IntegrationTokenRevokeRequestTests
    {
        [Test]
        public void IntegrationTokenRevokeRequest_Constructor()
        {
            var request = new IntegrationTokenRevokeRequest(TestDataHelper.UID, TestDataHelper.UID_1);

            Assert.AreEqual(TestDataHelper.UID, request.IntegrationUid);
            Assert.AreEqual(TestDataHelper.UID_1, request.TokenUid);
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.UID_1)]
        [TestCase(TestDataHelper.UID, TestDataHelper.EMPTY_STRING)]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING)]
        public void IntegrationTokenRevokeRequest_Argument_Validations(string integrationUid, string tokenUid)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new IntegrationTokenRevokeRequest(integrationUid, tokenUid);
            });
        }
    }
}