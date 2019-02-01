using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class ActiveTokensModelTests : BaseViewModelTest<ActiveTokensModel>
    {
        public ActiveTokensModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void ActiveTokensModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "active_tokens_title");
        }
    }
}