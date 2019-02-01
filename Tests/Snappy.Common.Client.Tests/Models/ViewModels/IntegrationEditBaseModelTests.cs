using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class IntegrationEditBaseModelTests : BaseViewModelTest<IntegrationEditBaseModel>
    {
        public IntegrationEditBaseModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void IntegrationEditBaseModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "integration_edit_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, new[] { "integration_name_required_error_message" })]
        public void IntegrationEditBaseModel_InputErrorMessages(string integrationName, string[] errorMessage)
        {
            SystemUnderTest.IntegrationName = integrationName;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void IntegrationEditBaseModel_IntegrationNameInput()
        {
            AssertInputModel(SystemUnderTest.IntegrationNameInput, "IntegrationName", "integration_name", true);
        }

        [Test]
        public void IntegrationEditBaseModel_DescriptionInput()
        {
            AssertInputModel(SystemUnderTest.DescriptionInput, "Description", "description", false);
        }
    }
}