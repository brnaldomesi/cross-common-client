using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    public class JournalRequestTests
    {
        [Test]
        public void DemandPasswordResetRequest_Constructor()
        {
            var request = new JournalRequest(TestDataHelper.POSITIVE_NUMBER);
            Assert.AreEqual(TestDataHelper.POSITIVE_NUMBER, request.CurrentUserId);
        }
    }
}