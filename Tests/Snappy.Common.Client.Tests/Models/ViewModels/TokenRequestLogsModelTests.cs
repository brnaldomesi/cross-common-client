using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class TokenRequestLogsModelTests
    {
        [Test]
        public void TokenRequestLogsModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "token_request_logs_title");
        }

        private static TokenRequestLogsModel GetModel()
        {
            return new TokenRequestLogsModel();
        }
    }
}