using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class IntegrationBaseRequestTests
    {
        [Test]
        public void IntegrationBaseRequest_Constructor()
        {
            var request = new IntegrationBaseRequest(TestDataHelper.UID);

            Assert.AreEqual(TestDataHelper.UID, request.IntegrationUid);
        }

        [TestCase(TestDataHelper.STRING)]
        [TestCase(TestDataHelper.EMPTY_STRING)]
        public void IntegrationBaseRequest_Argument_Validations(string integrationUid)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new IntegrationBaseRequest(integrationUid);
            });
        }
    }
}