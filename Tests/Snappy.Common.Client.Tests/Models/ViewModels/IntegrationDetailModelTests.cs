using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class IntegrationDetailModelTests : BaseViewModelTest<IntegrationDetailModel>
    {
        public IntegrationDetailModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void IntegrationDetailModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "integration_detail_title");
        }
    }
}