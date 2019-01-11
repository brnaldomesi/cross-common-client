using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class JournalRequestTests
    {
        [Test]
        public void DemandPasswordResetRequest_Constructor()
        {
            var request = new JournalRequest(TestDataHelper.CURRENT_USER_ID);
            Assert.AreEqual(TestDataHelper.CURRENT_USER_ID, request.CurrentUserId);
        }
    }
}