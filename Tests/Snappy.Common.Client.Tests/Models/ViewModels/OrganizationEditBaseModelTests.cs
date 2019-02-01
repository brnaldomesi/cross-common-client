using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class OrganizationEditBaseModelTests : BaseViewModelTest<OrganizationEditBaseModel>
    {
        public OrganizationEditBaseModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void OrganizationDetailIntegrationsBaseModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "organization_edit_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, new[] { "organization_name_required_error_message" })]
        public void OrganizationEditBaseModel_InputErrorMessages(string organizationName, string[] errorMessage)
        {
            SystemUnderTest.OrganizationName = organizationName;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void OrganizationEditBaseModel_OrganizationNameInput()
        {
            AssertInputModel(SystemUnderTest.OrganizationNameInput, "OrganizationName", "organization_name", true);
        }

        [Test]
        public void OrganizationEditBaseModel_DescriptionInput()
        {
            AssertInputModel(SystemUnderTest.DescriptionInput, "Description", "description", false);
        }
    }
}