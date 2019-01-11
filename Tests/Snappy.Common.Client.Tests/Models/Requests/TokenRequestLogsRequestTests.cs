using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class TokenRequestLogsRequestTests
    {
        [Test]
        public void TokenRequestLogsRequest_Constructor()
        {
            var request = new TokenRequestLogsRequest(TestDataHelper.CURRENT_USER_ID);
            Assert.AreEqual(TestDataHelper.CURRENT_USER_ID, request.CurrentUserId);
        }
    }
}