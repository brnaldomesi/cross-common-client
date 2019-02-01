using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class IntegrationDetailClientsDataModelTests : BaseViewModelTest<IntegrationDetailClientsDataModel>
    {
        public IntegrationDetailClientsDataModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void IntegrationDetailClientsModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "integration_clients_title");
        }
    }
}