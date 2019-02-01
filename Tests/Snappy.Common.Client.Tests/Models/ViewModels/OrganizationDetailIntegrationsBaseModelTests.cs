using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class OrganizationDetailIntegrationsBaseModelTests : BaseViewModelTest<OrganizationDetailIntegrationsBaseModel>
    {
        public OrganizationDetailIntegrationsBaseModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void OrganizationDetailIntegrationsBaseModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "organization_integrations_title");
        }
    }
}