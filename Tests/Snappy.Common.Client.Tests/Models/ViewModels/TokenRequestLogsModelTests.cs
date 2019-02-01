using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class TokenRequestLogsModelTests:BaseViewModelTest<TokenRequestLogsModel>
    {
        public TokenRequestLogsModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void TokenRequestLogsModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "token_request_logs_title");
        }
    }
}