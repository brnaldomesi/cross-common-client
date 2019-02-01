using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class OrganizationDetailBaseModelTests:BaseViewModelTest<OrganizationDetailBaseModel>
    {
        public OrganizationDetailBaseModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void OrganizationDetailBaseModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "organization_detail_title");
        }
    }
}