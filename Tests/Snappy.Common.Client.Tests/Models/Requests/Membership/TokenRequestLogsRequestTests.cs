using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class TokenRequestLogsRequestTests
    {
        [Test]
        public void TokenRequestLogsRequest_Constructor()
        {
            var request = new TokenRequestLogsRequest(TestDataHelper.POSITIVE_NUMBER);

            Assert.AreEqual(TestDataHelper.POSITIVE_NUMBER, request.CurrentUserId);
        }
    }
}