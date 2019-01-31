using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    class DemandPasswordResetRequestTests
    {
        [Test]
        public void DemandPasswordResetRequest_Constructor()
        {
            var request = new DemandPasswordResetRequest(TestDataHelper.EMAIL);
            Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
        }

        [TestCase(TestDataHelper.EMPTY_STRING)]
        [TestCase("testtest.com")]
        public void DemandPasswordResetRequest_Argument_Validations(string email)
        {
            Assert.Throws<ArgumentException>(() => { new DemandPasswordResetRequest(email); });
        }
    }
}
